using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.User
{
    public partial class EditPhoto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string _nid = (Request["pid"] == null) ? "1" : Request["pid"];
            EditPhotoData(_nid);
        }
        private void EditPhotoData(string i)
        {
            Model.t_user user = (Model.t_user)Session["UserInfo"];
            int num = Convert.ToInt32(i);
            user.u_pic_ID = num;

            new BLL.t_user().Update(user);
            Session["UserInfo"] = user;
            Response.Redirect("Default.aspx?id=1");
        }
    }
}