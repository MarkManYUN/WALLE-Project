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
namespace WalleProject.Web.t_wastecategory
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
					int wasc_ID=(Convert.ToInt32(strid));
					ShowInfo(wasc_ID);
				}
			}
		}
		
	private void ShowInfo(int wasc_ID)
	{
		WalleProject.BLL.t_wastecategory bll=new WalleProject.BLL.t_wastecategory();
		WalleProject.Model.t_wastecategory model=bll.GetModel(wasc_ID);
		this.lblwasc_name.Text=model.wasc_name;
		this.lblwasc_ID.Text=model.wasc_ID.ToString();

	}


    }
}
