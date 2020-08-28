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
namespace WalleProject.Web.t_menu
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int menu_ID=(Convert.ToInt32(strid));
					ShowInfo(menu_ID);
				}
			}
		}
		
	private void ShowInfo(int menu_ID)
	{
		WalleProject.BLL.t_menu bll=new WalleProject.BLL.t_menu();
		WalleProject.Model.t_menu model=bll.GetModel(menu_ID);
		this.lblmenu_ID.Text=model.menu_ID.ToString();
		this.lblmenu_Cate_ID.Text=model.menu_Cate_ID.ToString();
		this.lblmenu_name.Text=model.menu_name;
		this.lblmenu_sort.Text=model.menu_sort.ToString();
		this.lblmenu_path.Text=model.menu_path;
		this.lblmenu_valid.Text=model.menu_valid;

	}


    }
}
