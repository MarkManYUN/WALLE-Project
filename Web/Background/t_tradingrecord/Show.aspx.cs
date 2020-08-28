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
namespace WalleProject.Web.t_tradingrecord
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
					int tra_ID=(Convert.ToInt32(strid));
					ShowInfo(tra_ID);
				}
			}
		}
		
	private void ShowInfo(int tra_ID)
	{
		WalleProject.BLL.t_tradingrecord bll=new WalleProject.BLL.t_tradingrecord();
		WalleProject.Model.t_tradingrecord model=bll.GetModel(tra_ID);
		this.lbltra_U_ID.Text=model.tra_U_ID.ToString();
		this.lbltra_transactionAmount.Text=model.tra_transactionAmount.ToString();
		this.lbltra_transactionDate.Text=model.tra_transactionDate.ToString();
		this.lbltra_accomplish.Text=model.tra_accomplish;
		this.lbltra_staff_id.Text=model.tra_staff_id.ToString();
		this.lblsta_comwas_id.Text=model.sta_comwas_id.ToString();
		this.lbltra_number.Text=model.tra_number.ToString();
		this.lbltra_ID.Text=model.tra_ID.ToString();
		this.lbltra_addressID.Text=model.tra_addressID.ToString();
		this.lbltra_type.Text=model.tra_type;
		this.lbltra_vaild.Text=model.tra_vaild;
		this.lbltra_sort.Text=model.tra_sort.ToString();

	}


    }
}
