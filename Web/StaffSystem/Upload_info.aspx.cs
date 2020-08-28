using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.StaffSystem
{
    public partial class Upload_info : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            #region 单文件上传
            //单文件上传
            //if (Session["_tempfile"] == null) { Response.Redirect("i_upload.aspx"); }
            //else
            //{
            //    HttpPostedFile _myfile = (HttpPostedFile)Session["_tempfile"];
            //    string _ext = Path.GetExtension(_myfile.FileName).ToLower();
            //    string sql = "select * from List_FileType  where FileType_Ext like '%" + _ext + "%'";
            //    superConn cnn = new superConn("DATA.MDB");
            //    cnn.open();
            //    lbl_fcid.Text = "1";
            //    lbl_fcname.Text = "其他";
            //    lbl_tdir.Text = "~/_upfiles/other";
            //    OleDbDataReader rd= cnn.GetDataReader(sql);
            //    if (rd.Read())
            //    {
            //        lbl_fcid.Text = rd["FileType_Id"].ToString();
            //        lbl_fcname.Text = rd["FileType_Name"].ToString();
            //        lbl_tdir.Text = rd["FileType_Path"].ToString();
            //    }
            //    cnn.close();
            //    txt_title.Text = _myfile.FileName;
            //    lbl_tpath.Text = MapPath(lbl_tdir.Text) +"\\"+ DateTime.Now.ToOADate() + _ext;
            //}
            #endregion

            //多文件上传
            HttpPostedFile[] arr_Files = (HttpPostedFile[])Session["postedFiles"];


            int _count = 0;
            TableRow _tr; TableCell _td; Button _btn;

            for (int i = 0; i < 10; i++)
            {
                if (arr_Files[i] != null)
                {
                    _count++;

                    _tr = new TableRow();
                    _td = new TableCell();
                    _td.Text = arr_Files[i].FileName;
                    _tr.Cells.Add(_td);

                    _td = new TableCell();
                    _btn = new Button();
                    _btn.Command += new CommandEventHandler(_btn_Command);
                    _btn.CommandArgument = i.ToString();
                    _btn.Text = "取消文件";
                    _td.Controls.Add(_btn);
                    _tr.Cells.Add(_td);
                    tbl_sessionList.Rows.Add(_tr);

                }
            }
            if (_count == 0)
            {
                div_main.InnerText = "队列为空;请选择文件";
            }
            //Response.Write("<script>parent.document.getElementById("cph_content_temp_txt_FilesCount").value='" + _count + "'</script>");

        }
        void _btn_Command(object sender, CommandEventArgs e)
        {
            //throw new NotImplementedException();
            int i = Int32.Parse(e.CommandArgument.ToString());
            ((HttpPostedFile[])Session["postedFiles"])[i] = null;

            Response.Redirect(Request.RawUrl);
        }
        //单文件保存
        //protected void btn_save_Click(object sender, EventArgs e)
        //{
        //    string _targPath = lbl_tpath.Text;
        //    string _targDir = lbl_tdir.Text;

        //    try
        //    {
        //        Directory.CreateDirectory(MapPath(_targDir));
        //        ((HttpPostedFile)Session["_tempfile"]).SaveAs(_targPath);
        //    }
        //    catch { }

        //    if (File.Exists(_targPath))
        //    {
        //        string _fcid, _title, _fname;
        //        DateTime _fdate = DateTime.Now;
        //        _fcid = lbl_fcid.Text;
        //        _title = txt_title.Text;
        //        _fname = Path.GetFileName(lbl_tpath.Text);
        //        string str_sql = "INSERT INTO T_File(File_TypeId,File_Title,File_Name,File_Date) values " +
        //            "(" + _fcid + ",'" + _title + "','" + _fname + "','"+_fdate+"')";

        //        if (UpDate.IsUpDate(str_sql))
        //        {
        //            Session.Remove("_tempfile");
        //            Response.Write("<script>alert('报名失败!')</script>");
        //            Response.Redirect("../Base/Upload_done.aspx");
        //        }
        //        else
        //        {
        //            string js = "alert('上传失败');location.href='../Base/Upload.aspx.aspx';";
        //            ScriptManager.RegisterStartupScript(this, this.GetType(), "", js, true);
        //        }
        //    }

    }
}
