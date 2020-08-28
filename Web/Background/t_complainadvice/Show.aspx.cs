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
namespace WalleProject.Web.t_complainadvice
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
					int comd_ID=(Convert.ToInt32(strid));
					ShowInfo(comd_ID);
				}
			}
		}
		
	private void ShowInfo(int comd_ID)
	{
		WalleProject.BLL.t_complainadvice bll=new WalleProject.BLL.t_complainadvice();
		WalleProject.Model.t_complainadvice model=bll.GetModel(comd_ID);
		this.lblcomd_date.Text=model.comd_date.ToString();
		this.lblcomd_ID.Text=model.comd_ID.ToString();
		this.lblcomd_u_id.Text=model.comd_u_id.ToString();
		this.lblcomd_staff_id.Text=model.comd_staff_id.ToString();
		this.lblcomd_content.Text=model.comd_content;
		this.lblcomd_valid.Text=model.comd_valid;

	}


    }
}
