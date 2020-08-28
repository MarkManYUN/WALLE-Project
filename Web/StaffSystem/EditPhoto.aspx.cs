using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.StaffSystem
{
    public partial class EditPhoto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string _nid = (Request["pid"] == null) ? "1" : Request["pid"];
            EditPhotoData(_nid);
        }
        private void EditPhotoData(string i) {
            Model.t_staff staff = (Model.t_staff)Session["UserInfo"];
            int num = Convert.ToInt32(i);
            staff.sta__pic_id=num;
            
            new BLL.t_staff().Update(staff);
            Session["UserInfo"] = staff;
            Response.Redirect("Default.aspx");
        }
    }
}