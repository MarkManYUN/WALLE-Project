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
namespace WalleProject.Web.t_picturecategory
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int picca_ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(picca_ID);
				}
			}
		}
			
	private void ShowInfo(int picca_ID)
	{
		WalleProject.BLL.t_picturecategory bll=new WalleProject.BLL.t_picturecategory();
		WalleProject.Model.t_picturecategory model=bll.GetModel(picca_ID);
		this.lblpicca_ID.Text=model.picca_ID.ToString();
		this.txtpicca_name.Text=model.picca_name;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtpicca_name.Text.Trim().Length==0)
			{
				strErr+="picca_name不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int picca_ID=int.Parse(this.lblpicca_ID.Text);
			string picca_name=this.txtpicca_name.Text;


			WalleProject.Model.t_picturecategory model=new WalleProject.Model.t_picturecategory();
			model.picca_ID=picca_ID;
			model.picca_name=picca_name;

			WalleProject.BLL.t_picturecategory bll=new WalleProject.BLL.t_picturecategory();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
