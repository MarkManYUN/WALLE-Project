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
namespace WalleProject.Web.t_commoditycategory
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
					int comc_ID=(Convert.ToInt32(strid));
					ShowInfo(comc_ID);
				}
			}
		}
		
	private void ShowInfo(int comc_ID)
	{
		WalleProject.BLL.t_commoditycategory bll=new WalleProject.BLL.t_commoditycategory();
		WalleProject.Model.t_commoditycategory model=bll.GetModel(comc_ID);
		this.lblcomc_name.Text=model.comc_name;
		this.lblcomc_ID.Text=model.comc_ID.ToString();

	}


    }
}
