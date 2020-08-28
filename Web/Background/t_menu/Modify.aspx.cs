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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int menu_ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(menu_ID);
				}
			}
		}
			
	private void ShowInfo(int menu_ID)
	{
		WalleProject.BLL.t_menu bll=new WalleProject.BLL.t_menu();
		WalleProject.Model.t_menu model=bll.GetModel(menu_ID);
		this.lblmenu_ID.Text=model.menu_ID.ToString();
		this.txtmenu_Cate_ID.Text=model.menu_Cate_ID.ToString();
		this.txtmenu_name.Text=model.menu_name;
		this.txtmenu_sort.Text=model.menu_sort.ToString();
		this.txtmenu_path.Text=model.menu_path;
		this.txtmenu_valid.Text=model.menu_valid;

	}

		public void btnSave_Click(object sender, EventArgs e)
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
				strErr+="菜单不能为空！\\n";	
			}
			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int menu_ID=int.Parse(this.lblmenu_ID.Text);
			int menu_Cate_ID=int.Parse(this.txtmenu_Cate_ID.Text);
			string menu_name=this.txtmenu_name.Text;
			int menu_sort=int.Parse(this.txtmenu_sort.Text);
			string menu_path=this.txtmenu_path.Text;
			string menu_valid=this.txtmenu_valid.Text;


			WalleProject.Model.t_menu model=new WalleProject.Model.t_menu();
			model.menu_ID=menu_ID;
			model.menu_Cate_ID=menu_Cate_ID;
			model.menu_name=menu_name;
			model.menu_sort=menu_sort;
			model.menu_path=menu_path;
			model.menu_valid=menu_valid;

			WalleProject.BLL.t_menu bll=new WalleProject.BLL.t_menu();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
