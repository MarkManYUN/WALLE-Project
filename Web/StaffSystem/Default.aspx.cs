using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.StaffSystem
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Model.t_staff staff = (Model.t_staff)Session["UserInfo"];

            if (staff != null)
            {
                default_img.Src =new BLL.t_picture().GetModel(Convert.ToInt32( staff.sta__pic_id)).pic_valid;
                usertype.InnerText = staff.staffcategory.stac_name;
                username.InnerText = "亲爱的" + staff.sta_name;
            }
        }
    }
}