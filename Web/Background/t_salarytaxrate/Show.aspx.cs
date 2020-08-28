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
namespace WalleProject.Web.t_salarytaxrate
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
					int Str_ID=(Convert.ToInt32(strid));
					ShowInfo(Str_ID);
				}
			}
		}
		
	private void ShowInfo(int Str_ID)
	{
		WalleProject.BLL.t_salarytaxrate bll=new WalleProject.BLL.t_salarytaxrate();
		WalleProject.Model.t_salarytaxrate model=bll.GetModel(Str_ID);
		this.lblSta_threshold.Text=model.Sta_threshold.ToString();
		this.lblStr_date.Text=model.Str_date.ToString();
		this.lblStr_aged.Text=model.Str_aged.ToString();
		this.lblStr_ID.Text=model.Str_ID.ToString();
		this.lblStr_medical.Text=model.Str_medical.ToString();
		this.lblStr_unemployment.Text=model.Str_unemployment.ToString();
		this.lblStr_housing.Text=model.Str_housing.ToString();
		this.lblSta_supplement.Text=model.Sta_supplement.ToString();
		this.lblSta_individualTax.Text=model.Sta_individualTax.ToString();

	}


    }
}
