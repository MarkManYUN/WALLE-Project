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
namespace WalleProject.Web.t_integratingrecord
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDateTime(txtint_date.Text))
			{
				strErr+="日期格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtint_integral.Text))
			{
				strErr+="积分格式错误！\\n";	
			}
			if(this.txtint_way.Text.Trim().Length==0)
			{
				strErr+="Way不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtint_u_ID.Text))
			{
				strErr+="用户编号格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			DateTime int_date=DateTime.Parse(this.txtint_date.Text);
			int int_integral=int.Parse(this.txtint_integral.Text);
			string int_way=this.txtint_way.Text;
			int int_u_ID=int.Parse(this.txtint_u_ID.Text);

			WalleProject.Model.t_integratingrecord model=new WalleProject.Model.t_integratingrecord();
			model.int_date=int_date;
			model.int_integral=int_integral;
			model.int_way=int_way;
			model.int_u_ID=int_u_ID;

			WalleProject.BLL.t_integratingrecord bll=new WalleProject.BLL.t_integratingrecord();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
