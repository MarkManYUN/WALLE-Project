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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtfilec_name.Text.Trim().Length==0)
			{
				strErr+="filec_name不能为空！\\n";	
			}
			if(this.txtfilec_path.Text.Trim().Length==0)
			{
				strErr+="filec_path不能为空！\\n";	
			}
			if(this.txtfile_ext.Text.Trim().Length==0)
			{
				strErr+="file_ext不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string filec_name=this.txtfilec_name.Text;
			string filec_path=this.txtfilec_path.Text;
			string file_ext=this.txtfile_ext.Text;

			WalleProject.Model.t_filecategory model=new WalleProject.Model.t_filecategory();
			model.filec_name=filec_name;
			model.filec_path=filec_path;
			model.file_ext=file_ext;

			WalleProject.BLL.t_filecategory bll=new WalleProject.BLL.t_filecategory();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
