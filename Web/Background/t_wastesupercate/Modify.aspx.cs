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
namespace WalleProject.Web.t_wastesupercate
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int wastecc_ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(wastecc_ID);
				}
			}
		}
			
	private void ShowInfo(int wastecc_ID)
	{
		WalleProject.BLL.t_wastesupercate bll=new WalleProject.BLL.t_wastesupercate();
		WalleProject.Model.t_wastesupercate model=bll.GetModel(wastecc_ID);
		this.txtwastecc_name.Text=model.wastecc_name;
		this.lblwastecc_ID.Text=model.wastecc_ID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtwastecc_name.Text.Trim().Length==0)
			{
				strErr+="wastecc_name不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string wastecc_name=this.txtwastecc_name.Text;
			int wastecc_ID=int.Parse(this.lblwastecc_ID.Text);


			WalleProject.Model.t_wastesupercate model=new WalleProject.Model.t_wastesupercate();
			model.wastecc_name=wastecc_name;
			model.wastecc_ID=wastecc_ID;

			WalleProject.BLL.t_wastesupercate bll=new WalleProject.BLL.t_wastesupercate();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
