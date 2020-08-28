using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace WalleProject.Web.t_salarytaxrate
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDecimal(txtSta_threshold.Text))
			{
				strErr+="Sta_threshold格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtStr_date.Text))
			{
				strErr+="Str_date格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtStr_aged.Text))
			{
				strErr+="Str_aged格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtStr_medical.Text))
			{
				strErr+="Str_medical格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtStr_unemployment.Text))
			{
				strErr+="Str_unemployment格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtStr_housing.Text))
			{
				strErr+="Str_housing格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtSta_supplement.Text))
			{
				strErr+="Sta_supplement格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtSta_individualTax.Text))
			{
				strErr+="Sta_individualTax格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			decimal Sta_threshold=decimal.Parse(this.txtSta_threshold.Text);
			DateTime Str_date=DateTime.Parse(this.txtStr_date.Text);
			decimal Str_aged=decimal.Parse(this.txtStr_aged.Text);
			decimal Str_medical=decimal.Parse(this.txtStr_medical.Text);
			decimal Str_unemployment=decimal.Parse(this.txtStr_unemployment.Text);
			decimal Str_housing=decimal.Parse(this.txtStr_housing.Text);
			decimal Sta_supplement=decimal.Parse(this.txtSta_supplement.Text);
			decimal Sta_individualTax=decimal.Parse(this.txtSta_individualTax.Text);

			WalleProject.Model.t_salarytaxrate model=new WalleProject.Model.t_salarytaxrate();
			model.Sta_threshold=Sta_threshold;
			model.Str_date=Str_date;
			model.Str_aged=Str_aged;
			model.Str_medical=Str_medical;
			model.Str_unemployment=Str_unemployment;
			model.Str_housing=Str_housing;
			model.Sta_supplement=Sta_supplement;
			model.Sta_individualTax=Sta_individualTax;

			WalleProject.BLL.t_salarytaxrate bll=new WalleProject.BLL.t_salarytaxrate();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
