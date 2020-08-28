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
namespace WalleProject.Web.t_staff
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtsta_userName.Text.Trim().Length==0)
			{
				strErr+="sta_userName不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtsta_entryDate.Text))
			{
				strErr+="sta_entryDate格式错误！\\n";	
			}
			if(this.txtsta_passWord.Text.Trim().Length==0)
			{
				strErr+="sta_passWord不能为空！\\n";	
			}
			if(this.txtsta_maritalStatus.Text.Trim().Length==0)
			{
				strErr+="sta_maritalStatus不能为空！\\n";	
			}
			if(this.txtsta_IDNumber.Text.Trim().Length==0)
			{
				strErr+="sta_IDNumber不能为空！\\n";	
			}
			if(this.txtsta_homeAddress.Text.Trim().Length==0)
			{
				strErr+="sta_homeAddress不能为空！\\n";	
			}
			if(this.txtsta_phone.Text.Trim().Length==0)
			{
				strErr+="sta_phone不能为空！\\n";	
			}
			if(this.txtsta_name.Text.Trim().Length==0)
			{
				strErr+="sta_name不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtsta__pic_id.Text))
			{
				strErr+="sta__pic_id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsta_tra_id.Text))
			{
				strErr+="sta_tra_id格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtsta_lastLogindate.Text))
			{
				strErr+="sta_lastLogindate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtsta_salary.Text))
			{
				strErr+="sta_salary格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string sta_userName=this.txtsta_userName.Text;
			DateTime sta_entryDate=DateTime.Parse(this.txtsta_entryDate.Text);
			string sta_passWord=this.txtsta_passWord.Text;
			string sta_maritalStatus=this.txtsta_maritalStatus.Text;
			string sta_IDNumber=this.txtsta_IDNumber.Text;
			string sta_homeAddress=this.txtsta_homeAddress.Text;
			string sta_phone=this.txtsta_phone.Text;
			string sta_name=this.txtsta_name.Text;
			int sta__pic_id=int.Parse(this.txtsta__pic_id.Text);
			int sta_tra_id=int.Parse(this.txtsta_tra_id.Text);
			DateTime sta_lastLogindate=DateTime.Parse(this.txtsta_lastLogindate.Text);
			decimal sta_salary=decimal.Parse(this.txtsta_salary.Text);

			WalleProject.Model.t_staff model=new WalleProject.Model.t_staff();
			model.sta_userName=sta_userName;
			model.sta_entryDate=sta_entryDate;
			model.sta_passWord=sta_passWord;
			model.sta_maritalStatus=sta_maritalStatus;
			model.sta_IDNumber=sta_IDNumber;
			model.sta_homeAddress=sta_homeAddress;
			model.sta_phone=sta_phone;
			model.sta_name=sta_name;
			model.sta__pic_id=sta__pic_id;
			model.sta_tra_id=sta_tra_id;
			model.sta_lastLogindate=sta_lastLogindate;
			model.sta_salary=sta_salary;

			WalleProject.BLL.t_staff bll=new WalleProject.BLL.t_staff();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
