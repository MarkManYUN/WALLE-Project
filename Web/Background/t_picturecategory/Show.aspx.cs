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
namespace WalleProject.Web.t_picturecategory
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
					int picca_ID=(Convert.ToInt32(strid));
					ShowInfo(picca_ID);
				}
			}
		}
		
	private void ShowInfo(int picca_ID)
	{
		WalleProject.BLL.t_picturecategory bll=new WalleProject.BLL.t_picturecategory();
		WalleProject.Model.t_picturecategory model=bll.GetModel(picca_ID);
		this.lblpicca_ID.Text=model.picca_ID.ToString();
		this.lblpicca_name.Text=model.picca_name;

	}


    }
}
