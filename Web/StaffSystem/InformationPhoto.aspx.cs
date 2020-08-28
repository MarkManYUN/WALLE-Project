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
    public partial class InformationPhoto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Model.t_staff staff = (Model.t_staff)Session["UserInfo"];
            if (staff != null)
            {

                staffid.InnerText = staff.sta_id.ToString();
            }
            else {
                Response.Redirect("Default.aspx?menuid=1");
            }


        }
        protected int UploadFile(HttpPostedFile _file)
        {
            string fileName = _file.FileName;
            Model.t_picture picture = new Model.t_picture();
            int id = new BLL.t_picture().GetMaxId();

            string sqlwhere = " pic_name like '%" + fileName + "%'";

            DataSet datas = new BLL.t_picture().GetList(sqlwhere);
            if (datas != null && datas.Tables[0].Rows.Count > 0)
            {
                string js = "alert('文件已存在');";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "", js, true);
                return -1;
            }
            string Img_Path = Page.MapPath("~/StaffSystem/PhotoImage/") + fileName;


            try
            {
                //创建没有存在的目录
                Directory.CreateDirectory(Page.MapPath("~/StaffSystem/PhotoImage/"));
                _file.SaveAs(Img_Path);

            }
            catch
            { }

            if (File.Exists(Img_Path))
            {
                DateTime img_Date = DateTime.Now;
                picture.pic_ID = id;
                picture.pic_date = img_Date;
                picture.pic_name = fileName;
                picture.pic_valid = "~/StaffSystem/PhotoImage/" + fileName;
                picture.pic_cate_ID = 2;


                if (!new BLL.t_picture().Add(picture))
                {
                    return -1;
                }
                return id;
            }
            else
            {

                return -1;
            }


        }
        protected void btn_submit_ServerClick(object sender, EventArgs e)
        {
            Model.t_staff staff = new BLL.t_staff().GetModel(Convert.ToInt32(staffid.InnerText));
            HttpPostedFile file = fup_com_img.PostedFile;
            int imgId = UploadFile(file);
            if (imgId >= 0)
            {
                staff.sta__pic_id = imgId;
            }
            else
            {
                staff.sta__pic_id = 1;
            }
            new BLL.t_staff().Update(staff);
            Session["UserInfo"] = staff;
            Response.Redirect("Default.aspx?menuid=1" );
        }
        protected void EditPhoto(object sender, CommandEventArgs e)
        {
            
        }
    }
}