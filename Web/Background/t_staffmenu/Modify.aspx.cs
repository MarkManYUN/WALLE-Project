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
namespace WalleProject.Web.t_staffmenu
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int StaM_ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(StaM_ID);
				}
			}
		}
			
	private void ShowInfo(int StaM_ID)
	{
		WalleProject.BLL.t_staffmenu bll=new WalleProject.BLL.t_staffmenu();
		WalleProject.Model.t_staffmenu model=bll.GetModel(StaM_ID);
		this.txtStaM_User.Text=model.StaM_User.ToString();
		this.txtStaM_Boss.Text=model.StaM_Boss.ToString();
		this.txtStaM_Admin.Text=model.StaM_Admin.ToString();
		this.txtStaM_Staff.Text=model.StaM_Staff.ToString();
		this.txtStaM_Url.Text=model.StaM_Url;
		this.txtStaM_Name.Text=model.StaM_Name;
		this.lblStaM_ID.Text=model.StaM_ID.ToString();
		this.txtStaM_Delete.Text=model.StaM_Delete.ToString();
		this.txtStaM_MenuClass.Text=model.StaM_MenuClass.ToString();
		this.txtStaM_Valid.Text=model.StaM_Valid.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtStaM_User.Text))
			{
				strErr+="StaM_User格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtStaM_Boss.Text))
			{
				strErr+="StaM_Boss格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtStaM_Admin.Text))
			{
				strErr+="StaM_Admin格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtStaM_Staff.Text))
			{
				strErr+="StaM_Staff格式错误！\\n";	
			}
			if(this.txtStaM_Url.Text.Trim().Length==0)
			{
				strErr+="StaM_Url不能为空！\\n";	
			}
			if(this.txtStaM_Name.Text.Trim().Length==0)
			{
				strErr+="StaM_Name不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtStaM_Delete.Text))
			{
				strErr+="StaM_Delete格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtStaM_MenuClass.Text))
			{
				strErr+="StaM_MenuClass格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtStaM_Valid.Text))
			{
				strErr+="StaM_Valid格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int StaM_User=int.Parse(this.txtStaM_User.Text);
			int StaM_Boss=int.Parse(this.txtStaM_Boss.Text);
			int StaM_Admin=int.Parse(this.txtStaM_Admin.Text);
			int StaM_Staff=int.Parse(this.txtStaM_Staff.Text);
			string StaM_Url=this.txtStaM_Url.Text;
			string StaM_Name=this.txtStaM_Name.Text;
			int StaM_ID=int.Parse(this.lblStaM_ID.Text);
			int StaM_Delete=int.Parse(this.txtStaM_Delete.Text);
			int StaM_MenuClass=int.Parse(this.txtStaM_MenuClass.Text);
			int StaM_Valid=int.Parse(this.txtStaM_Valid.Text);


			WalleProject.Model.t_staffmenu model=new WalleProject.Model.t_staffmenu();
			model.StaM_User=StaM_User;
			model.StaM_Boss=StaM_Boss;
			model.StaM_Admin=StaM_Admin;
			model.StaM_Staff=StaM_Staff;
			model.StaM_Url=StaM_Url;
			model.StaM_Name=StaM_Name;
			model.StaM_ID=StaM_ID;
			model.StaM_Delete=StaM_Delete;
			model.StaM_MenuClass=StaM_MenuClass;
			model.StaM_Valid=StaM_Valid;

			WalleProject.BLL.t_staffmenu bll=new WalleProject.BLL.t_staffmenu();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
