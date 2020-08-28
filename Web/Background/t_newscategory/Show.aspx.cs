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
namespace WalleProject.Web.t_newscategory
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
					int newc_ID=(Convert.ToInt32(strid));
					ShowInfo(newc_ID);
				}
			}
		}
		
	private void ShowInfo(int newc_ID)
	{
		WalleProject.BLL.t_newscategory bll=new WalleProject.BLL.t_newscategory();
		WalleProject.Model.t_newscategory model=bll.GetModel(newc_ID);
		this.lblnewc_name.Text=model.newc_name;
		this.lblnewc_ID.Text=model.newc_ID.ToString();

	}


    }
}
