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
namespace WalleProject.Web.t_news
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int new_ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(new_ID);
				}
			}
		}
			
	private void ShowInfo(int new_ID)
	{
		WalleProject.BLL.t_news bll=new WalleProject.BLL.t_news();
		WalleProject.Model.t_news model=bll.GetModel(new_ID);
		this.txtEditnew_title.Text=model.new_title;
		this.txtEditnew_creatDate.Text=model.new_creatDate.ToString();
		this.txtEditnew_cate_id.Text=model.new_cate_id.ToString();
		this.txtEditnew_pic_id.Text=model.new_pic_id.ToString();
		this.txtEditnew_content.Text=model.new_content;
		this.txtEditnew_valid.Text=model.new_valid;
		this.lblnew_ID.Text=model.new_ID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtEditnew_title.Text.Trim().Length==0)
			{
				strErr+="new_title不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtEditnew_creatDate.Text))
			{
				strErr+="new_creatDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtEditnew_cate_id.Text))
			{
				strErr+="new_cate_id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtEditnew_pic_id.Text))
			{
				strErr+="new_pic_id格式错误！\\n";	
			}
			if(this.txtEditnew_content.Text.Trim().Length==0)
			{
				strErr+="new_content不能为空！\\n";	
			}
			if(this.txtEditnew_valid.Text.Trim().Length==0)
			{
				strErr+="new_valid不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string new_title=this.txtEditnew_title.Text;
			DateTime new_creatDate=DateTime.Parse(this.txtEditnew_creatDate.Text);
			int new_cate_id=int.Parse(this.txtEditnew_cate_id.Text);
			int new_pic_id=int.Parse(this.txtEditnew_pic_id.Text);
			string new_content=this.txtEditnew_content.Text;
			string new_valid=this.txtEditnew_valid.Text;
			int new_ID=int.Parse(this.lblnew_ID.Text);


			WalleProject.Model.t_news model=new WalleProject.Model.t_news();
			model.new_title=new_title;
			model.new_creatDate=new_creatDate;
			model.new_cate_id=new_cate_id;
			model.new_pic_id=new_pic_id;
			model.new_content=new_content;
			model.new_valid=new_valid;
			model.new_ID=new_ID;

			WalleProject.BLL.t_news bll=new WalleProject.BLL.t_news();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
