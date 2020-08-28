using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.User
{
    public partial class PurseView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
                Model.t_user user = (Model.t_user)Session["UserInfo"];

                if (user == null)
                {
                    Response.Redirect("UserLogin.aspx");
                }
                integral.InnerText= user.u_integral.ToString();

        }
    }
}