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
namespace WalleProject.Web.t_newscategory
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int newc_ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(newc_ID);
				}
			}
		}
			
	private void ShowInfo(int newc_ID)
	{
		WalleProject.BLL.t_newscategory bll=new WalleProject.BLL.t_newscategory();
		WalleProject.Model.t_newscategory model=bll.GetModel(newc_ID);
		this.txtnewc_name.Text=model.newc_name;
		this.lblnewc_ID.Text=model.newc_ID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtnewc_name.Text.Trim().Length==0)
			{
				strErr+="newc_name不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string newc_name=this.txtnewc_name.Text;
			int newc_ID=int.Parse(this.lblnewc_ID.Text);


			WalleProject.Model.t_newscategory model=new WalleProject.Model.t_newscategory();
			model.newc_name=newc_name;
			model.newc_ID=newc_ID;

			WalleProject.BLL.t_newscategory bll=new WalleProject.BLL.t_newscategory();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
