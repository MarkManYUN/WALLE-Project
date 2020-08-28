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
namespace WalleProject.Web.t_staffmenu
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
					int StaM_ID=(Convert.ToInt32(strid));
					ShowInfo(StaM_ID);
				}
			}
		}
		
	private void ShowInfo(int StaM_ID)
	{
		WalleProject.BLL.t_staffmenu bll=new WalleProject.BLL.t_staffmenu();
		WalleProject.Model.t_staffmenu model=bll.GetModel(StaM_ID);
		this.lblStaM_User.Text=model.StaM_User.ToString();
		this.lblStaM_Boss.Text=model.StaM_Boss.ToString();
		this.lblStaM_Admin.Text=model.StaM_Admin.ToString();
		this.lblStaM_Staff.Text=model.StaM_Staff.ToString();
		this.lblStaM_Url.Text=model.StaM_Url;
		this.lblStaM_Name.Text=model.StaM_Name;
		this.lblStaM_ID.Text=model.StaM_ID.ToString();
		this.lblStaM_Delete.Text=model.StaM_Delete.ToString();
		this.lblStaM_MenuClass.Text=model.StaM_MenuClass.ToString();
		this.lblStaM_Valid.Text=model.StaM_Valid.ToString();

	}


    }
}
