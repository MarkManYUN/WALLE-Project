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
namespace WalleProject.Web.t_staffsalary
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtSal_absenteeismDay.Text))
			{
				strErr+="Sal_absenteeismDay格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtsal_bonusM.Text))
			{
				strErr+="sal_bonusM格式错误！\\n";	
			}
			if(this.txtsal_describe.Text.Trim().Length==0)
			{
				strErr+="sal_describe不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtsal_deductM.Text))
			{
				strErr+="sal_deductM格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtsal_totalM.Text))
			{
				strErr+="sal_totalM格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtsal_incrementM.Text))
			{
				strErr+="sal_incrementM格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsal_month.Text))
			{
				strErr+="sal_month格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsal_year.Text))
			{
				strErr+="sal_year格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtsal_date.Text))
			{
				strErr+="sal_date格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsal_sta_id.Text))
			{
				strErr+="sal_sta_id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtSal_leaveDay.Text))
			{
				strErr+="Sal_leaveDay格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Sal_absenteeismDay=int.Parse(this.txtSal_absenteeismDay.Text);
			decimal sal_bonusM=decimal.Parse(this.txtsal_bonusM.Text);
			string sal_describe=this.txtsal_describe.Text;
			decimal sal_deductM=decimal.Parse(this.txtsal_deductM.Text);
			decimal sal_totalM=decimal.Parse(this.txtsal_totalM.Text);
			decimal sal_incrementM=decimal.Parse(this.txtsal_incrementM.Text);
			int sal_month=int.Parse(this.txtsal_month.Text);
			int sal_year=int.Parse(this.txtsal_year.Text);
			DateTime sal_date=DateTime.Parse(this.txtsal_date.Text);
			int sal_sta_id=int.Parse(this.txtsal_sta_id.Text);
			int Sal_leaveDay=int.Parse(this.txtSal_leaveDay.Text);

			WalleProject.Model.t_staffsalary model=new WalleProject.Model.t_staffsalary();
			model.Sal_absenteeismDay=Sal_absenteeismDay;
			model.sal_bonusM=sal_bonusM;
			model.sal_describe=sal_describe;
			model.sal_deductM=sal_deductM;
			model.sal_totalM=sal_totalM;
			model.sal_incrementM=sal_incrementM;
			model.sal_month=sal_month;
			model.sal_year=sal_year;
			model.sal_date=sal_date;
			model.sal_sta_id=sal_sta_id;
			model.Sal_leaveDay=Sal_leaveDay;

			WalleProject.BLL.t_staffsalary bll=new WalleProject.BLL.t_staffsalary();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
