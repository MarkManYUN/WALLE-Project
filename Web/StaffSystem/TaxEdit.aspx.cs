using Maticsoft.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.StaffSystem
{
    public partial class TaxEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
                {
                    int Str_ID = (Convert.ToInt32(Request.Params["id"]));
                  
                }
                ShowInfo();
            }
        }

        private void ShowInfo()
        {
            WalleProject.BLL.t_salarytaxrate bll = new WalleProject.BLL.t_salarytaxrate();
            WalleProject.Model.t_salarytaxrate model = bll.GetModel(bll.GetMaxId()-1);
            this.txtStr_aged.Text = model.Str_aged.ToString();
            this.txtSta_threshold.Text = model.Sta_threshold.ToString();
            this.txtStr_medical.Text = model.Str_medical.ToString();
            this.txtStr_unemployment.Text = model.Str_unemployment.ToString();
            this.txtStr_housing.Text = model.Str_housing.ToString();
            this.txtSta_supplement.Text = model.Sta_supplement.ToString();
            this.txtSta_individualTax.Text = model.Sta_individualTax.ToString();

        }

        public void btnSave_Click(object sender, EventArgs e)
        {

            string strErr = "";
           
            if (!PageValidate.IsDecimal(txtStr_aged.Text))
            {
                strErr += "Str_aged格式错误！\\n";
            }
            if (!PageValidate.IsDecimal(txtStr_medical.Text))
            {
                strErr += "Str_medical格式错误！\\n";
            }
            if (!PageValidate.IsDecimal(txtStr_unemployment.Text))
            {
                strErr += "Str_unemployment格式错误！\\n";
            }
            if (!PageValidate.IsDecimal(txtStr_housing.Text))
            {
                strErr += "Str_housing格式错误！\\n";
            }
            if (!PageValidate.IsDecimal(txtSta_supplement.Text))
            {
                strErr += "Sta_supplement格式错误！\\n";
            }
            if (!PageValidate.IsDecimal(txtSta_individualTax.Text))
            {
                strErr += "Sta_individualTax格式错误！\\n";
            }
            if (!PageValidate.IsDecimal(txtSta_threshold.Text))
            {
                strErr += "txtSta_threshold格式错误！\\n";
            }
            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            decimal Str_aged = decimal.Parse(this.txtStr_aged.Text);
            decimal Str_medical = decimal.Parse(this.txtStr_medical.Text);
            decimal Str_unemployment = decimal.Parse(this.txtStr_unemployment.Text);
            decimal Str_housing = decimal.Parse(this.txtStr_housing.Text);
            decimal Sta_supplement = decimal.Parse(this.txtSta_supplement.Text);
            decimal Sta_individualTax = decimal.Parse(this.txtSta_individualTax.Text);
            decimal Sta_threshold = decimal.Parse(this.txtSta_threshold.Text);

            WalleProject.Model.t_salarytaxrate model = new WalleProject.Model.t_salarytaxrate();
            model.Sta_threshold = Sta_threshold;
            model.Str_aged = Str_aged;
            model.Str_medical = Str_medical;
            model.Str_date = DateTime.Now;
            model.Str_unemployment = Str_unemployment;
            model.Str_housing = Str_housing;
            model.Sta_supplement = Sta_supplement;
            model.Sta_individualTax = Sta_individualTax;

            WalleProject.BLL.t_salarytaxrate bll = new WalleProject.BLL.t_salarytaxrate();
            bll.Add(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "SalaryManage.aspx");

        }


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("SalaryManage.aspx");
        }
    }
}