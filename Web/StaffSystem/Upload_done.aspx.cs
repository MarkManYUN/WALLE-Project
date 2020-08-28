using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.StaffSystem
{
    public partial class Upload_done : System.Web.UI.Page
    {
        int i = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

            HttpPostedFile _pstFile;
            TableRow _tr; TableCell _td;

            for (i = 0; i < 10; i++)
            {
                if (((HttpPostedFile[])Session["postedFiles"])[i] != null)
                {
                    _pstFile = ((HttpPostedFile[])Session["postedFiles"])[i];

                    if (UploadFile(_pstFile))
                    {
                        //插入表格内容,清除SESSION
                        _tr = new TableRow();
                        _td = new TableCell();
                        _td.Text = _pstFile.FileName;
                        _tr.Cells.Add(_td);

                        _td = new TableCell();
                        _td.Text = "上传成功!";
                        _tr.Cells.Add(_td);

                        tbl_sessionList.Rows.Add(_tr);

                        ((HttpPostedFile[])Session["postedFiles"])[i] = null;

                        //string js = "<script>alert('上传成功');location.href='Upload_done.aspx';</script>";
                        //ScriptManager.RegisterStartupScript(this, this.GetType(), "", js, true);

                    }
                    else
                    {
                        //出错信息
                        string jsF = "<script>alert('上传失败!');location.href='Upload_info.aspx';</script>";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "", jsF, true);
                    }
                }
                //string js = "<script>window.location.reload(true); </script>";
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "", js, true);
            }


        }
        protected Boolean UploadFile(HttpPostedFile _file)
        {
            string fileName = _file.FileName;
            string sqlwhere = " file_title like '%" + fileName + "%'";

            DataSet datas = new BLL.t_file().GetList(sqlwhere);
            if (datas != null && datas.Tables[0].Rows.Count > 0)
            {
                ((HttpPostedFile[])Session["postedFiles"])[i] = null;
                string js = "alert('文件已存在');";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "", js, true);
                return false;
            }
            string FileType_Name, _fname, FileType_Id, FileType_Path, _title, _fPath;


            FileType_Name = Path.GetExtension(_file.FileName).ToLower();//获取文件扩展名
            FileType_Id = "1";//默认文件类型
            FileType_Path = "~/_uploadFiles/other/";//默认本地存储路径 
            string sql = " file_ext like '%" + FileType_Name + "%'";//通过文件扩展名查找文件类型
            BLL.t_filecategory filecategory = new BLL.t_filecategory();
            DataSet ds = filecategory.GetList(sql);
            Model.t_filecategory t_Filecategory = new Model.t_filecategory();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                t_Filecategory.filec_ID = Convert.ToInt32(dr["filec_ID"]);
                t_Filecategory.filec_name = dr["filec_name"].ToString();
                t_Filecategory.filec_path = dr["filec_path"].ToString();
                t_Filecategory.file_ext = dr["file_ext"].ToString();
                FileType_Id = t_Filecategory.filec_ID.ToString();
                FileType_Path = t_Filecategory.filec_path;
            }
            _title = Path.GetFileName(_file.FileName);
            _fname = DateTime.Now.ToOADate() + FileType_Name;
            _fPath = MapPath(FileType_Path) + _fname;
            try
            {
                //创建没有存在的目录
                Directory.CreateDirectory(MapPath(FileType_Path));
                _file.SaveAs(_fPath); 
            }
            catch 
            {  }

            if (File.Exists(_fPath))
            {
                _fname = Path.GetFileName(_fname);
                Model.t_file file = new Model.t_file();
                file.file_catefory_ID = t_Filecategory.filec_ID;
                file.file_date = DateTime.Now;
                file.file_Name = _fname;
                file.file_title = _title;

                BLL.t_file addfile = new BLL.t_file();
                if (!addfile.Add(file))
                {
                    return false;
                }
                return true;
            }
            else
            {

                return false;
            }


        }
    }
}