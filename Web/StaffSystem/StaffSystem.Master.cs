using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.StaffSystem
{
    public partial class StaffSystem : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lab_menu.Value = Request.Params["menuid"];
            Model.t_staff staff = (Model.t_staff)Session["UserInfo"];
            
            if (staff == null || Session["UserInfo"] == null)
            {
                Response.Redirect(@"..\Admin\Login.aspx");
            }
            else
            {
                txt_name.InnerText = staff.sta_name;
                usertype.InnerText = staff.staffcategory.stac_name;
                string userType = staff.staffcategory.stac_name;
                username.InnerText = "亲爱的" + staff.sta_userName;
                img_photo.Src = new BLL.t_picture().GetModel(Convert.ToInt32( staff.sta__pic_id)).pic_valid;
                lastlogn.InnerText = " 您最后一次登陆本系统时间是：" + staff.sta_entryDate.ToString();

                if (!IsPostBack)
                {

                    if (userType.Equals("经理"))
                    {

                        Response.Cookies["USER_TYPE"].Value = "StaM_Boss=1";
                    }
                    else if (userType.Equals("管理员"))
                    {
                        Response.Cookies["USER_TYPE"].Value = "StaM_Admin=1";
                    }
                    else if (userType.Equals("回收员"))
                    {
                        Response.Cookies["USER_TYPE"].Value = "StaM_Staff=1";
                    }
                    else if (userType.Equals("财务"))
                    {
                        Response.Cookies["USER_TYPE"].Value = "StaM_Finance=1";
                    }
                    else if (userType.Equals("超级管理员"))
                    {
                        Response.Cookies["USER_TYPE"].Value = "StaM_SuperAdmin=1";

                    }
                }
            }
            //  SqlDataSource ds = (SqlDataSource)ListView1.FindControl("childDataSource");
        }

    }
}