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
namespace WalleProject.Web.t_complainadvice
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDateTime(txtcomd_date.Text))
			{
				strErr+="comd_date格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcomd_u_id.Text))
			{
				strErr+="comd_u_id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcomd_staff_id.Text))
			{
				strErr+="comd_staff_id格式错误！\\n";	
			}
			if(this.txtcomd_content.Text.Trim().Length==0)
			{
				strErr+="comd_content不能为空！\\n";	
			}
			if(this.txtcomd_valid.Text.Trim().Length==0)
			{
				strErr+="comd_valid不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			DateTime comd_date=DateTime.Parse(this.txtcomd_date.Text);
			int comd_u_id=int.Parse(this.txtcomd_u_id.Text);
			int comd_staff_id=int.Parse(this.txtcomd_staff_id.Text);
			string comd_content=this.txtcomd_content.Text;
			string comd_valid=this.txtcomd_valid.Text;

			WalleProject.Model.t_complainadvice model=new WalleProject.Model.t_complainadvice();
			model.comd_date=comd_date;
			model.comd_u_id=comd_u_id;
			model.comd_staff_id=comd_staff_id;
			model.comd_content=comd_content;
			model.comd_valid=comd_valid;

			WalleProject.BLL.t_complainadvice bll=new WalleProject.BLL.t_complainadvice();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
