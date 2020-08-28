using Maticsoft.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.StaffSystem
{
    public partial class SalaryManage : System.Web.UI.Page
    {
        WalleProject.BLL.t_staffsalary bll = new WalleProject.BLL.t_staffsalary();
        BLL.t_staff bllStaff = new BLL.t_staff();
        public string strid = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
               
                ShowInfo();
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

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}