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
namespace WalleProject.Web.t_staff
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
					long sta_id=(Convert.ToInt64(strid));
					ShowInfo(sta_id);
				}
			}
		}
		
	private void ShowInfo(long sta_id)
	{
		WalleProject.BLL.t_staff bll=new WalleProject.BLL.t_staff();
		WalleProject.Model.t_staff model=bll.GetModel(sta_id);
		this.lblsta_id.Text=model.sta_id.ToString();
		this.lblsta_userName.Text=model.sta_userName;
		this.lblsta_entryDate.Text=model.sta_entryDate.ToString();
		this.lblsta_passWord.Text=model.sta_passWord;
		this.lblsta_maritalStatus.Text=model.sta_maritalStatus;
		this.lblsta_IDNumber.Text=model.sta_IDNumber;
		this.lblsta_homeAddress.Text=model.sta_homeAddress;
		this.lblsta_phone.Text=model.sta_phone;
		this.lblsta_name.Text=model.sta_name;
		this.lblsta__pic_id.Text=model.sta__pic_id.ToString();
		this.lblsta_tra_id.Text=model.sta_tra_id.ToString();
		this.lblsta_lastLogindate.Text=model.sta_lastLogindate.ToString();
		this.lblsta_salary.Text=model.sta_salary.ToString();

	}


    }
}
