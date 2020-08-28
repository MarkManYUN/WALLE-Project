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
namespace WalleProject.Web.t_waste
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int was_ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(was_ID);
				}
			}
		}
			
	private void ShowInfo(int was_ID)
	{
		WalleProject.BLL.t_waste bll=new WalleProject.BLL.t_waste();
		WalleProject.Model.t_waste model=bll.GetModel(was_ID);
		this.txtwas_pic_ID.Text=model.was_pic_ID.ToString();
		this.lblwas_ID.Text=model.was_ID.ToString();
		this.txtwas_name.Text=model.was_name;
		this.txtwas_price.Text=model.was_price.ToString();
		this.txtwas_recoverable.Text= model.was_recoverable.ToString();
		this.txtwas_number.Text=model.was_number.ToString();
		this.txtwas_cate_ID.Text=model.was_cate_ID.ToString();
		this.txtwas_valid.Text=model.was_valid;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtwas_pic_ID.Text))
			{
				strErr+="was_pic_ID格式错误！\\n";	
			}
			if(this.txtwas_name.Text.Trim().Length==0)
			{
				strErr+="was_name不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtwas_price.Text))
			{
				strErr+="was_price格式错误！\\n";	
			}
			if(this.txtwas_recoverable.Text.Trim().Length==0)
			{
				strErr+="was_recoverable不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtwas_number.Text))
			{
				strErr+="was_number格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtwas_cate_ID.Text))
			{
				strErr+="was_cate_ID格式错误！\\n";	
			}
			if(this.txtwas_valid.Text.Trim().Length==0)
			{
				strErr+="was_valid不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int was_pic_ID=int.Parse(this.txtwas_pic_ID.Text);
			int was_ID=int.Parse(this.lblwas_ID.Text);
			string was_name=this.txtwas_name.Text;
			decimal was_price=decimal.Parse(this.txtwas_price.Text);
			string was_recoverable=this.txtwas_recoverable.Text;
			int was_number=int.Parse(this.txtwas_number.Text);
			int was_cate_ID=int.Parse(this.txtwas_cate_ID.Text);
			string was_valid=this.txtwas_valid.Text;


			WalleProject.Model.t_waste model=new WalleProject.Model.t_waste();
			model.was_pic_ID=was_pic_ID;
			model.was_ID=was_ID;
			model.was_name=was_name;
			model.was_price=was_price;
            model.was_recoverable = int.Parse(was_recoverable);
			model.was_number=was_number;
			model.was_cate_ID=was_cate_ID;
			model.was_valid=was_valid;

			WalleProject.BLL.t_waste bll=new WalleProject.BLL.t_waste();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
