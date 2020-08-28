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
namespace WalleProject.Web.t_waste
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
					int was_ID=(Convert.ToInt32(strid));
					ShowInfo(was_ID);
				}
			}
		}
		
	private void ShowInfo(int was_ID)
	{
		WalleProject.BLL.t_waste bll=new WalleProject.BLL.t_waste();
		WalleProject.Model.t_waste model=bll.GetModel(was_ID);
		this.lblwas_pic_ID.Text=model.was_pic_ID.ToString();
		this.lblwas_ID.Text=model.was_ID.ToString();
		this.lblwas_name.Text=model.was_name;
		this.lblwas_price.Text=model.was_price.ToString();
		this.lblwas_recoverable.Text=model.was_recoverable.ToString();
		this.lblwas_number.Text=model.was_number.ToString();
		this.lblwas_cate_ID.Text=model.was_cate_ID.ToString();
		this.lblwas_valid.Text=model.was_valid;

	}


    }
}
