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
namespace WalleProject.Web.t_usermenu
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtUserM_Icon.Text.Trim().Length==0)
			{
				strErr+="UserM_Icon不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtUserM_User.Text))
			{
				strErr+="UserM_User格式错误！\\n";	
			}
			if(this.txtUserM_Url.Text.Trim().Length==0)
			{
				strErr+="UserM_Url不能为空！\\n";	
			}
			if(this.txtUserM_Name.Text.Trim().Length==0)
			{
				strErr+="UserM_Name不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtUserM_Delete.Text))
			{
				strErr+="UserM_Delete格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtUserM_Valid.Text))
			{
				strErr+="UserM_Valid格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string UserM_Icon=this.txtUserM_Icon.Text;
			int UserM_User=int.Parse(this.txtUserM_User.Text);
			string UserM_Url=this.txtUserM_Url.Text;
			string UserM_Name=this.txtUserM_Name.Text;
			int UserM_Delete=int.Parse(this.txtUserM_Delete.Text);
			int UserM_Valid=int.Parse(this.txtUserM_Valid.Text);

			WalleProject.Model.t_usermenu model=new WalleProject.Model.t_usermenu();
			model.UserM_Icon=UserM_Icon;
			model.UserM_User=UserM_User;
			model.UserM_Url=UserM_Url;
			model.UserM_Name=UserM_Name;
			model.UserM_Delete=UserM_Delete;
			model.UserM_Valid=UserM_Valid;

			WalleProject.BLL.t_usermenu bll=new WalleProject.BLL.t_usermenu();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
