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
namespace WalleProject.Web.t_filecategory
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int filec_ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(filec_ID);
				}
			}
		}
			
	private void ShowInfo(int filec_ID)
	{
		WalleProject.BLL.t_filecategory bll=new WalleProject.BLL.t_filecategory();
		WalleProject.Model.t_filecategory model=bll.GetModel(filec_ID);
		this.lblfilec_ID.Text=model.filec_ID.ToString();
		this.txtfilec_name.Text=model.filec_name;
		this.txtfilec_path.Text=model.filec_path;
		this.txtfile_ext.Text=model.file_ext;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtfilec_name.Text.Trim().Length==0)
			{
				strErr+="文件名不能为空！\\n";	
			}
			if(this.txtfilec_path.Text.Trim().Length==0)
			{
				strErr+="文件类型不能为空！\\n";	
			}
			if(this.txtfile_ext.Text.Trim().Length==0)
			{
				strErr+="文件后缀不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int filec_ID=int.Parse(this.lblfilec_ID.Text);
			string filec_name=this.txtfilec_name.Text;
			string filec_path=this.txtfilec_path.Text;
			string file_ext=this.txtfile_ext.Text;


			WalleProject.Model.t_filecategory model=new WalleProject.Model.t_filecategory();
			model.filec_ID=filec_ID;
			model.filec_name=filec_name;
			model.filec_path=filec_path;
			model.file_ext=file_ext;

			WalleProject.BLL.t_filecategory bll=new WalleProject.BLL.t_filecategory();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
