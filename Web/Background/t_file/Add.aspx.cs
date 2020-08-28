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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
		 
			if(this.txtfile_title.Text.Trim().Length==0)
			{
				strErr+="文件标题不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtfile_catefory_ID.Text))
			{
				strErr+="文件类型格式错误！\\n";	
			}
			if(this.txtfile_Name.Text.Trim().Length==0)
			{
				strErr+="文件名不能为空！\\n";	
			} 

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			DateTime file_date=DateTime.Parse(this.txtfile_date.Text);
			string file_title=this.txtfile_title.Text;
			int file_catefory_ID=int.Parse(this.txtfile_catefory_ID.Text);
			string file_Name=this.txtfile_Name.Text;
			string file_valid=this.txtfile_valid.Text;

			WalleProject.Model.t_file model=new WalleProject.Model.t_file();
			model.file_date=file_date;
			model.file_title=file_title;
			model.file_catefory_ID=file_catefory_ID;
			model.file_Name=file_Name;
			model.file_valid=file_valid;

			WalleProject.BLL.t_file bll=new WalleProject.BLL.t_file();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
