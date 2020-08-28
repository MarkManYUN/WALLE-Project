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
namespace WalleProject.Web.t_commodity
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
					int com_ID=(Convert.ToInt32(strid));
					ShowInfo(com_ID);
				}
			}
		}
		
	private void ShowInfo(int com_ID)
	{
		WalleProject.BLL.t_commodity bll=new WalleProject.BLL.t_commodity();
		WalleProject.Model.t_commodity model=bll.GetModel(com_ID);
		this.lblcom_ID.Text=model.com_ID.ToString();
		this.lblcom_name.Text=model.com_name;
		this.lblcom_productDate.Text=model.com_productDate.ToString();
		this.lblcom_number.Text=model.com_number.ToString();
		this.lblcom_strageID.Text=model.com_strageID;
		this.lblcom_alertNumber.Text=model.com_alertNumber.ToString();
		this.lblcom_pic_ID.Text=model.com_pic_ID.ToString();
		this.lblcom_date.Text=model.com_date.ToString();
		this.lblcom_pri_ID.Text=model.com_pri_ID.ToString();
		this.lblcom_conversionInt.Text=model.com_conversionInt.ToString();
		this.lblcom_comc_ID.Text=model.com_comc_ID.ToString();
		this.lblcom_valid.Text=model.com_valid;

	}


    }
}
