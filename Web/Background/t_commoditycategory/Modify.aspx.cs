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
namespace WalleProject.Web.t_commoditycategory
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int comc_ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(comc_ID);
				}
			}
		}
			
	private void ShowInfo(int comc_ID)
	{
		WalleProject.BLL.t_commoditycategory bll=new WalleProject.BLL.t_commoditycategory();
		WalleProject.Model.t_commoditycategory model=bll.GetModel(comc_ID);
		this.txtcomc_name.Text=model.comc_name;
		this.lblcomc_ID.Text=model.comc_ID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtcomc_name.Text.Trim().Length==0)
			{
				strErr+="comc_name不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string comc_name=this.txtcomc_name.Text;
			int comc_ID=int.Parse(this.lblcomc_ID.Text);


			WalleProject.Model.t_commoditycategory model=new WalleProject.Model.t_commoditycategory();
			model.comc_name=comc_name;
			model.comc_ID=comc_ID;

			WalleProject.BLL.t_commoditycategory bll=new WalleProject.BLL.t_commoditycategory();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
