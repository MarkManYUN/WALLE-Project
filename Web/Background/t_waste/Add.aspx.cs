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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			string was_name=this.txtwas_name.Text;
			decimal was_price=decimal.Parse(this.txtwas_price.Text);
			string was_recoverable=this.txtwas_recoverable.Text;
			int was_number=int.Parse(this.txtwas_number.Text);
			int was_cate_ID=int.Parse(this.txtwas_cate_ID.Text);
			string was_valid=this.txtwas_valid.Text;

			WalleProject.Model.t_waste model=new WalleProject.Model.t_waste();
			model.was_pic_ID=was_pic_ID;
			model.was_name=was_name;
			model.was_price=was_price;
			model.was_recoverable=int.Parse( was_recoverable);
			model.was_number=was_number;
			model.was_cate_ID=was_cate_ID;
			model.was_valid=was_valid;

			WalleProject.BLL.t_waste bll=new WalleProject.BLL.t_waste();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
