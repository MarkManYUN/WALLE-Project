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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					long sta_id=(Convert.ToInt64(Request.Params["id"]));
					ShowInfo(sta_id);
				}
			}
		}
			
	private void ShowInfo(long sta_id)
	{
		WalleProject.BLL.t_staff bll=new WalleProject.BLL.t_staff();
		WalleProject.Model.t_staff model=bll.GetModel(sta_id);
		this.lblsta_id.Text=model.sta_id.ToString();
		this.txtEdit_sta_userName.Text=model.sta_userName;
		this.txtEdit_sta_entryDate.Text=model.sta_entryDate.ToString();
		this.txtEdit_sta_passWord.Text=model.sta_passWord;
		this.txtEdit_sta_maritalStatus.Text=model.sta_maritalStatus;
		this.txtEdit_sta_IDNumber.Text=model.sta_IDNumber;
		this.txtEdit_sta_homeAddress.Text=model.sta_homeAddress;
		this.txtEdit_sta_phone.Text=model.sta_phone;
		this.txtEdit_sta_name.Text=model.sta_name;
		this.txtEdit_sta__pic_id.Text=model.sta__pic_id.ToString();
		this.txtEdit_sta_tra_id.Text=model.sta_tra_id.ToString();
		this.txtEdit_sta_lastLogindate.Text=model.sta_lastLogindate.ToString();
		this.txtEdit_sta_salary.Text=model.sta_salary.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtEdit_sta_userName.Text.Trim().Length==0)
			{
				strErr+="sta_userName不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtEdit_sta_entryDate.Text))
			{
				strErr+="sta_entryDate格式错误！\\n";	
			}
			if(this.txtEdit_sta_passWord.Text.Trim().Length==0)
			{
				strErr+="sta_passWord不能为空！\\n";	
			}
			if(this.txtEdit_sta_maritalStatus.Text.Trim().Length==0)
			{
				strErr+="sta_maritalStatus不能为空！\\n";	
			}
			if(this.txtEdit_sta_IDNumber.Text.Trim().Length==0)
			{
				strErr+="sta_IDNumber不能为空！\\n";	
			}
			if(this.txtEdit_sta_homeAddress.Text.Trim().Length==0)
			{
				strErr+="sta_homeAddress不能为空！\\n";	
			}
			if(this.txtEdit_sta_phone.Text.Trim().Length==0)
			{
				strErr+="sta_phone不能为空！\\n";	
			}
			if(this.txtEdit_sta_name.Text.Trim().Length==0)
			{
				strErr+="sta_name不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtEdit_sta__pic_id.Text))
			{
				strErr+="sta__pic_id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtEdit_sta_tra_id.Text))
			{
				strErr+="sta_tra_id格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtEdit_sta_lastLogindate.Text))
			{
				strErr+="sta_lastLogindate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtEdit_sta_salary.Text))
			{
				strErr+="sta_salary格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			long sta_id=long.Parse(this.lblsta_id.Text);
			string sta_userName=this.txtEdit_sta_userName.Text;
			DateTime sta_entryDate=DateTime.Parse(this.txtEdit_sta_entryDate.Text);
			string sta_passWord=this.txtEdit_sta_passWord.Text;
			string sta_maritalStatus=this.txtEdit_sta_maritalStatus.Text;
			string sta_IDNumber=this.txtEdit_sta_IDNumber.Text;
			string sta_homeAddress=this.txtEdit_sta_homeAddress.Text;
			string sta_phone=this.txtEdit_sta_phone.Text;
			string sta_name=this.txtEdit_sta_name.Text;
			int sta__pic_id=int.Parse(this.txtEdit_sta__pic_id.Text);
			int sta_tra_id=int.Parse(this.txtEdit_sta_tra_id.Text);
			DateTime sta_lastLogindate=DateTime.Parse(this.txtEdit_sta_lastLogindate.Text);
			decimal sta_salary=decimal.Parse(this.txtEdit_sta_salary.Text);


			WalleProject.Model.t_staff model=new WalleProject.Model.t_staff();
			model.sta_id=sta_id;
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
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","StaffManage.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
