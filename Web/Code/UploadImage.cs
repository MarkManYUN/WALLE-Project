using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WalleProject.Web.Code
{
    //文件管理类
    public class SuperFile
    {

        public string _fileName;
        public string _fileTitle;
        public string _fileDir = "~/_uploadFiles";

        //1
        public SuperFile()
        {
            _fileName = _fileTitle = "";
        }

        //2
        public SuperFile(int _id)
        {
            BLL.t_file file = new BLL.t_file();
           Model.t_file filem= file.GetModel(_id);
            _fileName =  filem.file_title;
            _fileTitle =filem.file_Name;
            _fileDir =new  BLL.t_filecategory().GetModel(Convert.ToInt32( filem.file_catefory_ID)).filec_path;
        }

        //下载
        public void fileDownload()
        {
            string _path = System.IO.Path.Combine(HttpContext.Current.Server.MapPath(_fileDir), _fileTitle); 
            if (System.IO.File.Exists(_path))
            { 
                HttpContext.Current.Response.Clear();
                HttpContext.Current.Response.Buffer = true; 
                HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment;filename=" + _fileName);
                HttpContext.Current.Response.ContentType = "application/unknow";
                HttpContext.Current.Response.TransmitFile(_path);
                HttpContext.Current.Response.End(); 
            }

        }

    }

    //图片管理类
    //1. 静态类,图片上传类,只提供对应的方法
    public static class SuperImgUploader
    {



        /// <summary>
        /// 返回待上传文件的数量
        /// </summary>
        /// <returns></returns>
        public static int imgsCount()
        {
            int _count = 0;
            foreach (SuperImg _img in (SuperImg[])HttpContext.Current.Session["UploadImgs"])
            {
                if (_img != null) { _count++; }
            }
            return _count;
        }

        /// <summary>
        /// 添加一个图片对象到列表中
        /// </summary>
        /// <param name="ObjectImg">图片对象superImg</param>
        /// <returns>返回添加结果</returns>
        public static Boolean addImg(SuperImg ObjectImg)
        {
            Boolean _added = false;
            for (int i = 0; i < 10; i++)
            {
                if (((SuperImg[])HttpContext.Current.Session["UploadImgs"])[i] == null)
                {
                    ((SuperImg[])HttpContext.Current.Session["UploadImgs"])[i] = ObjectImg;
                    _added = true;
                    break;
                }
            }
            return _added;
        }


        /// <summary>
        /// 从列表中移除指定图片对象
        /// </summary>
        /// <param name="imgIndex">0-9 图片列表编号索引</param>
        public static void removeImg(int imgIndex)
        {
            ((SuperImg[])HttpContext.Current.Session["UploadImgs"])[imgIndex] = null;
        }


        /// <summary>
        /// 清除所有上传列表
        /// </summary>
        public static void clear()
        {
            HttpContext.Current.Session["UploadImgs"] = new SuperImg[10];
        }


        /// <summary>
        /// 上传列表中的所有文件
        /// </summary>
        public static void uploadAll()
        {
            foreach (SuperImg si in (SuperImg[])HttpContext.Current.Session["UploadImgs"])
            {
                if (si != null)
                {
                    if (si.readToUpload() == true)
                    {
                        string targPath = HttpContext.Current.Server.MapPath("~/test/" + si.targFname);
                        si.pstImgFile.SaveAs(targPath);

                        if (File.Exists(targPath))
                        {
                            si.uploaded();
                        }

                    }
                }
            }
            clear();
        }



        public static void setCID(int i, int value)
        {
            ((SuperImg[])HttpContext.Current.Session["UploadImgs"])[i].setCID(value);
        }

    }
    public class UploadImage
    {
        public HttpPostedFile pstImgFile;
        public string Title;
        public string orgFname;
        public string targFname;

        private int img_id;             //
        public int img_cid;             //需要默认值
        private string img_cname;       //

        private Boolean uploadDone;     //默认FALSH



        /// <summary>
        /// 通过postedFile构建一个superImg对象
        /// </summary>
        /// <param name="pstFile"></param>
        public UploadImage(HttpPostedFile _pstFile)
        {
            pstImgFile = _pstFile;
            Title = "新上传文件";
            orgFname = _pstFile.FileName;
            targFname = DateTime.Now.ToFileTime().ToString() + Path.GetExtension(orgFname);
            img_cid = 1;
            uploadDone = false;
        }

        /// <summary>
        /// 检测属性,并返回对象是否具备上传条件
        /// </summary>
        /// <returns></returns>
        public Boolean ReadToUpload()
        {
            Boolean _ready = true;
            if (pstImgFile == null) { _ready = false; }
            if (Title == null || Title == "") { _ready = false; }
            if (orgFname == "" || orgFname == null) { _ready = false; }
            if (targFname == "" || targFname == null) { _ready = false; }
            if (uploadDone == true) { _ready = false; }

            return _ready;
        }


        public void Uploaded()
        {
            uploadDone = true;
        }


        public void SetCID(int cidValue)
        {
            img_cid = cidValue;
        }

    }



    //2.图片对象类
    public class SuperImg
    {

        public HttpPostedFile pstImgFile;
        public string Title;
        public string orgFname;
        public string targFname;

        private int img_id;             //
        public int img_cid;             //需要默认值
        private string img_cname;       //

        private Boolean uploadDone;     //默认FALSH





        /// <summary>
        /// 构建一个空superImg对象
        /// </summary>
        public SuperImg()
        {

        }


        /// <summary>
        /// 通过postedFile构建一个superImg对象
        /// </summary>
        /// <param name="pstFile"></param>
        public SuperImg(HttpPostedFile _pstFile)
        {
            pstImgFile = _pstFile;
            Title = "新上传文件";
            orgFname = _pstFile.FileName;
            targFname = DateTime.Now.ToFileTime().ToString() + Path.GetExtension(orgFname);
            img_cid = 1;
            uploadDone = false;
        }


        /// <summary>
        /// 通过数据库img_id构建对应的superImg对象
        /// </summary>
        /// <param name="imgID">数据表T_imgMng.img_id的值</param>
        public SuperImg(int imgID)
        {

        }


        /// <summary>
        /// 检测属性,并返回对象是否具备上传条件
        /// </summary>
        /// <returns></returns>
        public Boolean readToUpload()
        {
            Boolean _ready = true;
            if (pstImgFile == null) { _ready = false; }
            if (Title == null || Title == "") { _ready = false; }
            if (orgFname == "" || orgFname == null) { _ready = false; }
            if (targFname == "" || targFname == null) { _ready = false; }
            if (uploadDone == true) { _ready = false; }

            return _ready;
        }


        public void uploaded()
        {
            uploadDone = true;
        }


        public void setCID(int cidValue)
        {
            img_cid = cidValue;
        }




    }
}