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
namespace WalleProject.Web.t_pricerecord
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
					int pri_ID=(Convert.ToInt32(strid));
					ShowInfo(pri_ID);
				}
			}
		}
		
	private void ShowInfo(int pri_ID)
	{
		WalleProject.BLL.t_pricerecord bll=new WalleProject.BLL.t_pricerecord();
		WalleProject.Model.t_pricerecord model=bll.GetModel(pri_ID);
		this.lblpri_date.Text=model.pri_date.ToString();
		this.lblpri_price.Text=model.pri_price.ToString();
		this.lblpri_com_ID.Text=model.pri_com_ID.ToString();
		this.lblpri_ID.Text=model.pri_ID.ToString();

	}


    }
}
