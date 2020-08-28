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
namespace WalleProject.Web.t_command
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int command_ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(command_ID);
				}
			}
		}
			
	private void ShowInfo(int command_ID)
	{
		WalleProject.BLL.t_command bll=new WalleProject.BLL.t_command();
		WalleProject.Model.t_command model=bll.GetModel(command_ID);
		this.txtcommand_user_ID.Text=model.command_user_ID.ToString();
		this.txtcommand_staff_ID.Text=model.command_staff_ID.ToString();
		this.txtcommand_content.Text=model.command_content;
		this.lblcommand_ID.Text=model.command_ID.ToString();
		this.txtcommand_Delete.Text=model.command_Delete.ToString();
		this.txtcommand_Valid.Text=model.command_Valid.ToString();
		this.txtcommand_Date.Text=model.command_Date.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtcommand_user_ID.Text))
			{
				strErr+="command_user_ID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommand_staff_ID.Text))
			{
				strErr+="command_staff_ID格式错误！\\n";	
			}
			if(this.txtcommand_content.Text.Trim().Length==0)
			{
				strErr+="command_content不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommand_Delete.Text))
			{
				strErr+="command_Delete格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommand_Valid.Text))
			{
				strErr+="command_Valid格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtcommand_Date.Text))
			{
				strErr+="command_Date格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int command_user_ID=int.Parse(this.txtcommand_user_ID.Text);
			int command_staff_ID=int.Parse(this.txtcommand_staff_ID.Text);
			string command_content=this.txtcommand_content.Text;
			int command_ID=int.Parse(this.lblcommand_ID.Text);
			int command_Delete=int.Parse(this.txtcommand_Delete.Text);
			int command_Valid=int.Parse(this.txtcommand_Valid.Text);
			DateTime command_Date=DateTime.Parse(this.txtcommand_Date.Text);


			WalleProject.Model.t_command model=new WalleProject.Model.t_command();
			model.command_user_ID=command_user_ID;
			model.command_staff_ID=command_staff_ID;
			model.command_content=command_content;
			model.command_ID=command_ID;
			model.command_Delete=command_Delete;
			model.command_Valid=command_Valid;
			model.command_Date=command_Date;

			WalleProject.BLL.t_command bll=new WalleProject.BLL.t_command();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
