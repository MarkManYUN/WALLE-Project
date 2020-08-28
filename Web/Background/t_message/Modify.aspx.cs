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
namespace WalleProject.Web.t_message
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int mess_ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(mess_ID);
				}
			}
		}
			
	private void ShowInfo(int mess_ID)
	{
		WalleProject.BLL.t_message bll=new WalleProject.BLL.t_message();
		WalleProject.Model.t_message model=bll.GetModel(mess_ID);
		this.lblmess_ID.Text=model.mess_ID.ToString();
		this.txtmess_content.Text=model.mess_content;
		this.txtmess_date.Text=model.mess_date.ToString();
		this.txtmess_inpotance.Text=model.mess_inpotance.ToString();
		this.txtmess_valid.Text=model.mess_valid;
		this.txtmess_type.Text=model.mess_type;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtmess_content.Text.Trim().Length==0)
			{
				strErr+="mess_content不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtmess_date.Text))
			{
				strErr+="mess_date格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtmess_inpotance.Text))
			{
				strErr+="mess_inpotance格式错误！\\n";	
			}
			if(this.txtmess_valid.Text.Trim().Length==0)
			{
				strErr+="mess_valid不能为空！\\n";	
			}
			if(this.txtmess_type.Text.Trim().Length==0)
			{
				strErr+="mess_type不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int mess_ID=int.Parse(this.lblmess_ID.Text);
			string mess_content=this.txtmess_content.Text;
			DateTime mess_date=DateTime.Parse(this.txtmess_date.Text);
			int mess_inpotance=int.Parse(this.txtmess_inpotance.Text);
			string mess_valid=this.txtmess_valid.Text;
			string mess_type=this.txtmess_type.Text;


			WalleProject.Model.t_message model=new WalleProject.Model.t_message();
			model.mess_ID=mess_ID;
			model.mess_content=mess_content;
			model.mess_date=mess_date;
			model.mess_inpotance=mess_inpotance;
			model.mess_valid=mess_valid;
			model.mess_type=mess_type;

			WalleProject.BLL.t_message bll=new WalleProject.BLL.t_message();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
