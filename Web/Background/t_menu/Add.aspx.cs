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
namespace WalleProject.Web.t_menu
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtmenu_Cate_ID.Text))
			{
				strErr+="menu_Cate_ID格式错误！\\n";	
			}
			if(this.txtmenu_name.Text.Trim().Length==0)
			{
				strErr+="menu_name不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtmenu_sort.Text))
			{
				strErr+="menu_sort格式错误！\\n";	
			}
			if(this.txtmenu_path.Text.Trim().Length==0)
			{
				strErr+="menu_path不能为空！\\n";	
			}
			if(this.txtmenu_valid.Text.Trim().Length==0)
			{
				strErr+="menu_valid不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int menu_Cate_ID=int.Parse(this.txtmenu_Cate_ID.Text);
			string menu_name=this.txtmenu_name.Text;
			int menu_sort=int.Parse(this.txtmenu_sort.Text);
			string menu_path=this.txtmenu_path.Text;
			string menu_valid=this.txtmenu_valid.Text;

			WalleProject.Model.t_menu model=new WalleProject.Model.t_menu();
			model.menu_Cate_ID=menu_Cate_ID;
			model.menu_name=menu_name;
			model.menu_sort=menu_sort;
			model.menu_path=menu_path;
			model.menu_valid=menu_valid;

			WalleProject.BLL.t_menu bll=new WalleProject.BLL.t_menu();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
