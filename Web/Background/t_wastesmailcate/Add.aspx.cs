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
namespace WalleProject.Web.t_wastesmailcate
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtwastecate_name.Text.Trim().Length==0)
			{
				strErr+="wastecate_name不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtwastecate_cid.Text))
			{
				strErr+="wastecate_cid格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string wastecate_name=this.txtwastecate_name.Text;
			int wastecate_cid=int.Parse(this.txtwastecate_cid.Text);

			WalleProject.Model.t_wastesmailcate model=new WalleProject.Model.t_wastesmailcate();
			model.wastecate_name=wastecate_name;
			model.wastecate_cid=wastecate_cid;

			WalleProject.BLL.t_wastesmailcate bll=new WalleProject.BLL.t_wastesmailcate();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
