using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.StaffSystem
{
    public partial class SalaryView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Model.t_staff staff = (Model.t_staff)Session["UserInfo"];
                ShowInfo();
                if (staff == null || Session["UserInfo"] == null)
                {
                    Response.Redirect(@"..\Admin\Login.aspx");
                }
                else
                {

                    salary.InnerText = staff.sta_salary.ToString();
                    staffID.Text = staff.sta_id.ToString();
                    staffName.InnerText = staff.sta_name;
                }
            }

        }
        private void ShowInfo()
        {
            WalleProject.BLL.t_salarytaxrate bll = new WalleProject.BLL.t_salarytaxrate();
            WalleProject.Model.t_salarytaxrate model = bll.GetModel(bll.GetMaxId() - 1);
            this.lblStr_date.Text = model.Str_date.ToString();
            this.lblStr_aged.Text = model.Str_aged.ToString();
            this.lblStr_ID.Text = model.Str_ID.ToString();
            this.lblStr_medical.Text = model.Str_medical.ToString();
            this.lblStr_unemployment.Text = model.Str_unemployment.ToString();
            this.lblStr_housing.Text = model.Str_housing.ToString();
            this.lblSta_supplement.Text = model.Sta_supplement.ToString();
            this.lblSta_individualTax.Text = model.Sta_individualTax.ToString();

        }
    }
}