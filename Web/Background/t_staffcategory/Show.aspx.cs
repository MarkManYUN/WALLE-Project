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
namespace WalleProject.Web.t_staffcategory
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
					int stac_ID=(Convert.ToInt32(strid));
					ShowInfo(stac_ID);
				}
			}
		}
		
	private void ShowInfo(int stac_ID)
	{
		WalleProject.BLL.t_staffcategory bll=new WalleProject.BLL.t_staffcategory();
		WalleProject.Model.t_staffcategory model=bll.GetModel(stac_ID);
		this.lblstac_name.Text=model.stac_name;
		this.lblstac_ID.Text=model.stac_ID.ToString();

	}


    }
}
