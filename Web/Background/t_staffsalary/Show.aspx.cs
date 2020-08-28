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
namespace WalleProject.Web.t_staffsalary
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
					int sal_ID=(Convert.ToInt32(strid));
					ShowInfo(sal_ID);
				}
			}
		}
		
	private void ShowInfo(int sal_ID)
	{
		WalleProject.BLL.t_staffsalary bll=new WalleProject.BLL.t_staffsalary();
		WalleProject.Model.t_staffsalary model=bll.GetModel(sal_ID);
		this.lblSal_absenteeismDay.Text=model.Sal_absenteeismDay.ToString();
		this.lblsal_ID.Text=model.sal_ID.ToString();
		this.lblsal_bonusM.Text=model.sal_bonusM.ToString();
		this.lblsal_describe.Text=model.sal_describe;
		this.lblsal_deductM.Text=model.sal_deductM.ToString();
		this.lblsal_totalM.Text=model.sal_totalM.ToString();
		this.lblsal_incrementM.Text=model.sal_incrementM.ToString();
		this.lblsal_month.Text=model.sal_month.ToString();
		this.lblsal_year.Text=model.sal_year.ToString();
		this.lblsal_date.Text=model.sal_date.ToString();
		this.lblsal_sta_id.Text=model.sal_sta_id.ToString();
		this.lblSal_leaveDay.Text=model.Sal_leaveDay.ToString();

	}


    }
}
