using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.StaffSystem
{
    public partial class InformationView : System.Web.UI.Page
    {
        public string strid = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Model.t_staff staff = (Model.t_staff)Session["UserInfo"];
                if (staff == null) {
                    Response.Redirect("Default.aspx?id=1");
                }
                ShowInfo(staff.sta_id);

            }
        }
        private void ShowInfo(long sta_id)
        {
            WalleProject.BLL.t_staff bll = new WalleProject.BLL.t_staff();
            WalleProject.Model.t_staff model = bll.GetModel(sta_id);
            this.imgPhoto.Src = new BLL.t_picture().GetModel(int.Parse( model.sta__pic_id.ToString())).pic_valid;
            this.lblsta_id.Text = model.sta_id.ToString();
            this.lblsta_userName.Text = model.sta_userName;
            this.lblsta_entryDate.Text = model.sta_entryDate.ToString();
            this.lblsta_maritalStatus.Text = model.sta_maritalStatus;
            this.lblsta_IDNumber.Text = model.sta_IDNumber;
            this.lblsta_homeAddress.Text = model.sta_homeAddress;
            this.lblsta_phone.Text = model.sta_phone;
            this.lblsta_name.Text = model.sta_name;
            this.lblsta_lastLogindate.Text = model.sta_lastLogindate.ToString();
            this.lblsta_salary.Text = model.sta_salary.ToString();

        }
    }
}