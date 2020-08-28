using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.User
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                Model.t_user user=(Model.t_user) Session["UserInfo"];
                if (user == null) {
                    Response.Redirect("UserLogin.aspx");
                }
                lab_Name.Text = user.u_name;
                d_lab_user.Text = user.u_nickName;
                d_img_user.Src = new BLL.t_picture().GetModel(user.u_pic_ID).pic_valid;
                lab_lasttime.Text = user.u_lastLoginDate.ToString();
            }
        }
    }
}