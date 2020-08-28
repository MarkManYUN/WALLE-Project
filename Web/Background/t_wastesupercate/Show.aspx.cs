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
namespace WalleProject.Web.t_wastesupercate
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
					int wastecc_ID=(Convert.ToInt32(strid));
					ShowInfo(wastecc_ID);
				}
			}
		}
		
	private void ShowInfo(int wastecc_ID)
	{
		WalleProject.BLL.t_wastesupercate bll=new WalleProject.BLL.t_wastesupercate();
		WalleProject.Model.t_wastesupercate model=bll.GetModel(wastecc_ID);
		this.lblwastecc_name.Text=model.wastecc_name;
		this.lblwastecc_ID.Text=model.wastecc_ID.ToString();

	}


    }
}
