using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.User
{
    public partial class User : System.Web.UI.MasterPage
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            lab_menu.Value = Request.Params["id"];
            Model.t_user user = (Model.t_user)Session["UserInfo"];
            if (user == null || Session["UserInfo"] == null)
            {
                Response.Redirect("UserLogin.aspx");
            }
            else
            {

                if (!IsPostBack)
                {
                    this.UserName.Text= user.u_nickName;
                     imgPhoto.Src = new BLL.t_picture().GetModel(user.u_pic_ID).pic_valid;
                    if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
                    {

                    }
                }
            }
            
            
        }
    }
}