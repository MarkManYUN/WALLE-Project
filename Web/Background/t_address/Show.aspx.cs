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
namespace WalleProject.Web.t_address
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
					int add_ID=(Convert.ToInt32(strid));
					ShowInfo(add_ID);
				}
			}
		}
		
	private void ShowInfo(int add_ID)
	{
		WalleProject.BLL.t_address bll=new WalleProject.BLL.t_address();
		WalleProject.Model.t_address model=bll.GetModel(add_ID);
		this.lbladd_u_ID.Text=model.add_u_ID.ToString();
		this.lbladd_contactName.Text=model.add_contactName;
		this.lbladd_contactPhone.Text=model.add_contactPhone;
		this.lbladd_date.Text=model.add_date.ToString();
		this.lbladd_postcode.Text=model.add_postcode.ToString();
		this.lbladd_default.Text=model.add_default;
		this.lbladd_address.Text=model.add_address;
		this.lbladd_counties.Text=model.add_counties;
		this.lbladd_city.Text=model.add_city;
		this.lbladd_province.Text=model.add_province;
		this.lbladd_ID.Text=model.add_ID.ToString();

	}


    }
}
