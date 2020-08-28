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
namespace WalleProject.Web.t_wastecategory
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int wasc_ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(wasc_ID);
				}
			}
		}
			
	private void ShowInfo(int wasc_ID)
	{
		WalleProject.BLL.t_wastecategory bll=new WalleProject.BLL.t_wastecategory();
		WalleProject.Model.t_wastecategory model=bll.GetModel(wasc_ID);
		this.txtwasc_name.Text=model.wasc_name;
		this.lblwasc_ID.Text=model.wasc_ID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtwasc_name.Text.Trim().Length==0)
			{
				strErr+="wasc_name不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string wasc_name=this.txtwasc_name.Text;
			int wasc_ID=int.Parse(this.lblwasc_ID.Text);


			WalleProject.Model.t_wastecategory model=new WalleProject.Model.t_wastecategory();
			model.wasc_name=wasc_name;
			model.wasc_ID=wasc_ID;

			WalleProject.BLL.t_wastecategory bll=new WalleProject.BLL.t_wastecategory();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
