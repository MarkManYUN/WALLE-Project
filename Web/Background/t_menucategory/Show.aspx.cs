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
namespace WalleProject.Web.t_menucategory
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
					int menuc_ID=(Convert.ToInt32(strid));
					ShowInfo(menuc_ID);
				}
			}
		}
		
	private void ShowInfo(int menuc_ID)
	{
		WalleProject.BLL.t_menucategory bll=new WalleProject.BLL.t_menucategory();
		WalleProject.Model.t_menucategory model=bll.GetModel(menuc_ID);
		this.lblmenuc_ID.Text=model.menuc_ID.ToString();
		this.lblmenuc_name.Text=model.menuc_name;

	}


    }
}
