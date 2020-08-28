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
namespace WalleProject.Web.t_user
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int u_ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(u_ID);
				}
			}
		}
			
	private void ShowInfo(int u_ID)
	{
		WalleProject.BLL.t_user bll=new WalleProject.BLL.t_user();
		WalleProject.Model.t_user model=bll.GetModel(u_ID);
		this.txtu_address.Text=model.u_address;
		this.txtu_lastLoginDate.Text=model.u_lastLoginDate.ToString();
		this.txtu_creaditsLogID.Text=model.u_creaditsLogID.ToString();
		this.txtu_registrationDate.Text=model.u_registrationDate.ToString();
		this.lblu_ID.Text=model.u_ID.ToString();
		this.txtu_nickName.Text=model.u_nickName;
		this.txtu_category.Text=model.u_category;
		this.txtu_birthDate.Text=model.u_birthDate.ToString();
		this.txtu_state.Text=model.u_state;
		this.txtu_passWord.Text=model.u_passWord;
		this.txtu_integral.Text=model.u_integral.ToString();
		this.txtu_creditGrade.Text=model.u_creditGrade;
		this.txtu_name.Text=model.u_name;
		this.txtu_pic_ID.Text=model.u_pic_ID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtu_address.Text.Trim().Length==0)
			{
				strErr+="u_address不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtu_lastLoginDate.Text))
			{
				strErr+="u_lastLoginDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtu_creaditsLogID.Text))
			{
				strErr+="u_creaditsLogID格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtu_registrationDate.Text))
			{
				strErr+="u_registrationDate格式错误！\\n";	
			}
			if(this.txtu_nickName.Text.Trim().Length==0)
			{
				strErr+="u_nickName不能为空！\\n";	
			}
			if(this.txtu_category.Text.Trim().Length==0)
			{
				strErr+="u_category不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtu_birthDate.Text))
			{
				strErr+="u_birthDate格式错误！\\n";	
			}
			if(this.txtu_state.Text.Trim().Length==0)
			{
				strErr+="u_state不能为空！\\n";	
			}
			if(this.txtu_passWord.Text.Trim().Length==0)
			{
				strErr+="u_passWord不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtu_integral.Text))
			{
				strErr+="u_integral格式错误！\\n";	
			}
			if(this.txtu_creditGrade.Text.Trim().Length==0)
			{
				strErr+="u_creditGrade不能为空！\\n";	
			}
			if(this.txtu_name.Text.Trim().Length==0)
			{
				strErr+="u_name不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtu_pic_ID.Text))
			{
				strErr+="u_pic_ID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string u_address=this.txtu_address.Text;
			DateTime u_lastLoginDate=DateTime.Parse(this.txtu_lastLoginDate.Text);
			int u_creaditsLogID=int.Parse(this.txtu_creaditsLogID.Text);
			DateTime u_registrationDate=DateTime.Parse(this.txtu_registrationDate.Text);
			int u_ID=int.Parse(this.lblu_ID.Text);
			string u_nickName=this.txtu_nickName.Text;
			string u_category=this.txtu_category.Text;
			DateTime u_birthDate=DateTime.Parse(this.txtu_birthDate.Text);
			string u_state=this.txtu_state.Text;
			string u_passWord=this.txtu_passWord.Text;
			int u_integral=int.Parse(this.txtu_integral.Text);
			string u_creditGrade=this.txtu_creditGrade.Text;
			string u_name=this.txtu_name.Text;
			int u_pic_ID=int.Parse(this.txtu_pic_ID.Text);


			WalleProject.Model.t_user model=new WalleProject.Model.t_user();
			model.u_address=u_address;
			model.u_lastLoginDate=u_lastLoginDate;
			model.u_creaditsLogID=u_creaditsLogID;
			model.u_registrationDate=u_registrationDate;
			model.u_ID=u_ID;
			model.u_nickName=u_nickName;
			model.u_category=u_category;
			model.u_birthDate=u_birthDate;
			model.u_state=u_state;
			model.u_passWord=u_passWord;
			model.u_integral=u_integral;
			model.u_creditGrade=u_creditGrade;
			model.u_name=u_name;
			model.u_pic_ID=u_pic_ID;

			WalleProject.BLL.t_user bll=new WalleProject.BLL.t_user();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
