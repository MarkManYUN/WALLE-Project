using Maticsoft.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.User
{
    public partial class WALLEcommunity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_submit_ServerClick(object sender, EventArgs e)
        {
            Model.t_systemleave systemleave = new Model.t_systemleave();
            systemleave.sl_date = DateTime.Now;
            systemleave.sl_per_id = ((Model.t_user)Session["UserInfo"]).u_ID;
           systemleave.sl_per_type = 0;
            systemleave.sl_content = inputNote.InnerText;
            HttpPostedFile file = fup_com_img.PostedFile;

            if (file != null)
            {
                systemleave.sl_pic_id = UploadFile(file);
            }
            else
            {

                systemleave.sl_pic_id = 1;
            }
            
            string errorStr = "";
            if (systemleave.sl_content=="") {
                errorStr = "请输入内容";
                MessageBox.Show(this, errorStr);
                return;
            }
            new BLL.t_systemleave().Add(systemleave);
            Response.Redirect("WALLEcommunity.aspx?id=12");
        }

        protected void btn_canel_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("WALLEcommunity.aspx?id=12");
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
            string Img_Path = Page.MapPath("../NewsImage/") + fileName;


            try
            {
                //创建没有存在的目录
                Directory.CreateDirectory(Page.MapPath("../NewsImage/"));
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
                picture.pic_valid = "../NewsImage/" + fileName;
                picture.pic_cate_ID = 5;


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
    }
}