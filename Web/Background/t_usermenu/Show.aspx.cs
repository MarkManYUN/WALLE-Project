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
namespace WalleProject.Web.t_usermenu
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
					int UserM_ID=(Convert.ToInt32(strid));
					ShowInfo(UserM_ID);
				}
			}
		}
		
	private void ShowInfo(int UserM_ID)
	{
		WalleProject.BLL.t_usermenu bll=new WalleProject.BLL.t_usermenu();
		WalleProject.Model.t_usermenu model=bll.GetModel(UserM_ID);
		this.lblUserM_Icon.Text=model.UserM_Icon;
		this.lblUserM_User.Text=model.UserM_User.ToString();
		this.lblUserM_Url.Text=model.UserM_Url;
		this.lblUserM_Name.Text=model.UserM_Name;
		this.lblUserM_ID.Text=model.UserM_ID.ToString();
		this.lblUserM_Delete.Text=model.UserM_Delete.ToString();
		this.lblUserM_Valid.Text=model.UserM_Valid.ToString();

	}


    }
}
