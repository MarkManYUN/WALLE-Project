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
namespace WalleProject.Web.t_staffcategory
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int stac_ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(stac_ID);
				}
			}
		}
			
	private void ShowInfo(int stac_ID)
	{
		WalleProject.BLL.t_staffcategory bll=new WalleProject.BLL.t_staffcategory();
		WalleProject.Model.t_staffcategory model=bll.GetModel(stac_ID);
		this.txtstac_name.Text=model.stac_name;
		this.lblstac_ID.Text=model.stac_ID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtstac_name.Text.Trim().Length==0)
			{
				strErr+="stac_name不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string stac_name=this.txtstac_name.Text;
			int stac_ID=int.Parse(this.lblstac_ID.Text);


			WalleProject.Model.t_staffcategory model=new WalleProject.Model.t_staffcategory();
			model.stac_name=stac_name;
			model.stac_ID=stac_ID;

			WalleProject.BLL.t_staffcategory bll=new WalleProject.BLL.t_staffcategory();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
