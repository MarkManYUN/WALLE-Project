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
namespace WalleProject.Web.t_file
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int file_ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(file_ID);
				}
			}
		}
			
	private void ShowInfo(int file_ID)
	{
		WalleProject.BLL.t_file bll=new WalleProject.BLL.t_file();
		WalleProject.Model.t_file model=bll.GetModel(file_ID);
		this.lblfile_ID.Text=model.file_ID.ToString();
		this.txtfile_date.Text=model.file_date.ToString();
		this.txtfile_title.Text=model.file_title;
		this.txtfile_catefory_ID.Text=model.file_catefory_ID.ToString();
		this.txtfile_Name.Text=model.file_Name;
		this.txtfile_valid.Text=model.file_valid;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDateTime(txtfile_date.Text))
			{
				strErr+="file_date格式错误！\\n";	
			}
			if(this.txtfile_title.Text.Trim().Length==0)
			{
				strErr+="file_title不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtfile_catefory_ID.Text))
			{
				strErr+="file_catefory_ID格式错误！\\n";	
			}
			if(this.txtfile_Name.Text.Trim().Length==0)
			{
				strErr+="file_Name不能为空！\\n";	
			}
			if(this.txtfile_valid.Text.Trim().Length==0)
			{
				strErr+="file_valid不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int file_ID=int.Parse(this.lblfile_ID.Text);
			DateTime file_date=DateTime.Parse(this.txtfile_date.Text);
			string file_title=this.txtfile_title.Text;
			int file_catefory_ID=int.Parse(this.txtfile_catefory_ID.Text);
			string file_Name=this.txtfile_Name.Text;
			string file_valid=this.txtfile_valid.Text;


			WalleProject.Model.t_file model=new WalleProject.Model.t_file();
			model.file_ID=file_ID;
			model.file_date=file_date;
			model.file_title=file_title;
			model.file_catefory_ID=file_catefory_ID;
			model.file_Name=file_Name;
			model.file_valid=file_valid;

			WalleProject.BLL.t_file bll=new WalleProject.BLL.t_file();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
