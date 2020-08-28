using Maticsoft.Common;
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
    public partial class CommunityShow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request["cid"];
                if (id == null)
                {
                    Response.Redirect("WALLEcommunity.aspx?id=36");
                }
                else
                {
                    ShowInfo(id);
                }
            }
        }

        private void ShowInfo(string id)
        {
            Model.t_staff staff = (Model.t_staff)Session["UserInfo"];
            if (staff == null)
            {
                Response.Redirect("WALLEcommunity.aspx?id=36");

            }
            userid.Text = staff.sta_id.ToString();
            Model.t_systemleave systemleave = new BLL.t_systemleave().GetModel(int.Parse(id));

            // userid.Text = staff.sta_id.ToString();
            //staffImg.Src = new BLL.t_picture().GetModel(staff.u_pic_ID).pic_valid;
            content.InnerText = systemleave.sl_content;
            date.InnerText = systemleave.sl_date.ToString();
            main_img.Src = new BLL.t_picture().GetModel(int.Parse(systemleave.sl_pic_id.ToString())).pic_valid;


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
            string Img_Path = Page.MapPath("~/StaffSystem/CommodityImage/") + fileName;


            try
            {
                //创建没有存在的目录
                Directory.CreateDirectory(Page.MapPath("~/StaffSystem/CommodityImage/"));
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
                picture.pic_valid = "~/StaffSystem/CommodityImage/" + fileName;
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
        protected void btn_submit_ServerClick(object sender, EventArgs e)
        {
            Model.t_systeminterchange t_systeminterchange = new Model.t_systeminterchange();
            t_systeminterchange.si_date = DateTime.Now;
            t_systeminterchange.si_per_id = int.Parse(userid.Text);
            t_systeminterchange.si_per_type = "回收员";
            t_systeminterchange.si_content = inputNote.InnerText;
            HttpPostedFile file = fup_com_img.PostedFile;

            int imgId = UploadFile(file);
            if (imgId >= 0)
            {
                t_systeminterchange.si_pic_id = imgId;
            }
            else
            {
                t_systeminterchange.si_pic_id = 1;
            }
            t_systeminterchange.si_sl_id = int.Parse(Request["cid"]);
            string errorStr = "";
            if (t_systeminterchange.si_content == "")
            {
                errorStr = "请输入内容";
                MessageBox.Show(this, errorStr);
                return;
            }
            new BLL.t_systeminterchange().Add(t_systeminterchange);
            Response.Redirect("CommunityShow.aspx?cid=" + Request["cid"]);
        }

        protected void btn_canel_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("CommunityShow.aspx?id=36");
        }
    }
}