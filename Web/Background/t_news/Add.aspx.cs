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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtnew_title.Text.Trim().Length==0)
			{
				strErr+="new_title不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtnew_creatDate.Text))
			{
				strErr+="new_creatDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtnew_cate_id.Text))
			{
				strErr+="new_cate_id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtnew_pic_id.Text))
			{
				strErr+="new_pic_id格式错误！\\n";	
			}
			if(this.txtnew_content.Text.Trim().Length==0)
			{
				strErr+="new_content不能为空！\\n";	
			}
			if(this.txtnew_valid.Text.Trim().Length==0)
			{
				strErr+="new_valid不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string new_title=this.txtnew_title.Text;
			DateTime new_creatDate=DateTime.Parse(this.txtnew_creatDate.Text);
			int new_cate_id=int.Parse(this.txtnew_cate_id.Text);
			int new_pic_id=int.Parse(this.txtnew_pic_id.Text);
			string new_content=this.txtnew_content.Text;
			string new_valid=this.txtnew_valid.Text;

			WalleProject.Model.t_news model=new WalleProject.Model.t_news();
			model.new_title=new_title;
			model.new_creatDate=new_creatDate;
			model.new_cate_id=new_cate_id;
			model.new_pic_id=new_pic_id;
			model.new_content=new_content;
			model.new_valid=new_valid;

			WalleProject.BLL.t_news bll=new WalleProject.BLL.t_news();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
