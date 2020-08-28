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
namespace WalleProject.Web.t_picture
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int pic_ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(pic_ID);
				}
			}
		}
			
	private void ShowInfo(int pic_ID)
	{
		WalleProject.BLL.t_picture bll=new WalleProject.BLL.t_picture();
		WalleProject.Model.t_picture model=bll.GetModel(pic_ID);
		this.txtpic_cate_ID.Text=model.pic_cate_ID.ToString();
		this.lblpic_ID.Text=model.pic_ID.ToString();
		this.txtpic_date.Text=model.pic_date.ToString();
		this.txtpic_name.Text=model.pic_name;
		this.txtpic_valid.Text=model.pic_valid;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtpic_cate_ID.Text))
			{
				strErr+="pic_cate_ID格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtpic_date.Text))
			{
				strErr+="pic_date格式错误！\\n";	
			}
			if(this.txtpic_name.Text.Trim().Length==0)
			{
				strErr+="pic_name不能为空！\\n";	
			}
			if(this.txtpic_valid.Text.Trim().Length==0)
			{
				strErr+="pic_valid不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int pic_cate_ID=int.Parse(this.txtpic_cate_ID.Text);
			int pic_ID=int.Parse(this.lblpic_ID.Text);
			DateTime pic_date=DateTime.Parse(this.txtpic_date.Text);
			string pic_name=this.txtpic_name.Text;
			string pic_valid=this.txtpic_valid.Text;


			WalleProject.Model.t_picture model=new WalleProject.Model.t_picture();
			model.pic_cate_ID=pic_cate_ID;
			model.pic_ID=pic_ID;
			model.pic_date=pic_date;
			model.pic_name=pic_name;
			model.pic_valid=pic_valid;

			WalleProject.BLL.t_picture bll=new WalleProject.BLL.t_picture();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
