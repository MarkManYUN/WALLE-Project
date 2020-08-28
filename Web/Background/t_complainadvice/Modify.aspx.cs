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
namespace WalleProject.Web.t_complainadvice
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int comd_ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(comd_ID);
				}
			}
		}
			
	private void ShowInfo(int comd_ID)
	{
		WalleProject.BLL.t_complainadvice bll=new WalleProject.BLL.t_complainadvice();
		WalleProject.Model.t_complainadvice model=bll.GetModel(comd_ID);
		this.txtcomd_date.Text=model.comd_date.ToString();
		this.lblcomd_ID.Text=model.comd_ID.ToString();
		this.txtcomd_u_id.Text=model.comd_u_id.ToString();
		this.txtcomd_staff_id.Text=model.comd_staff_id.ToString();
		this.txtcomd_content.Text=model.comd_content;
		this.txtcomd_valid.Text=model.comd_valid;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDateTime(txtcomd_date.Text))
			{
				strErr+="comd_date格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcomd_u_id.Text))
			{
				strErr+="comd_u_id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcomd_staff_id.Text))
			{
				strErr+="comd_staff_id格式错误！\\n";	
			}
			if(this.txtcomd_content.Text.Trim().Length==0)
			{
				strErr+="comd_content不能为空！\\n";	
			}
			if(this.txtcomd_valid.Text.Trim().Length==0)
			{
				strErr+="comd_valid不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			DateTime comd_date=DateTime.Parse(this.txtcomd_date.Text);
			int comd_ID=int.Parse(this.lblcomd_ID.Text);
			int comd_u_id=int.Parse(this.txtcomd_u_id.Text);
			int comd_staff_id=int.Parse(this.txtcomd_staff_id.Text);
			string comd_content=this.txtcomd_content.Text;
			string comd_valid=this.txtcomd_valid.Text;


			WalleProject.Model.t_complainadvice model=new WalleProject.Model.t_complainadvice();
			model.comd_date=comd_date;
			model.comd_ID=comd_ID;
			model.comd_u_id=comd_u_id;
			model.comd_staff_id=comd_staff_id;
			model.comd_content=comd_content;
			model.comd_valid=comd_valid;

			WalleProject.BLL.t_complainadvice bll=new WalleProject.BLL.t_complainadvice();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
