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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			model.StaM_Delete=StaM_Delete;
			model.StaM_MenuClass=StaM_MenuClass;
			model.StaM_Valid=StaM_Valid;

			WalleProject.BLL.t_staffmenu bll=new WalleProject.BLL.t_staffmenu();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
