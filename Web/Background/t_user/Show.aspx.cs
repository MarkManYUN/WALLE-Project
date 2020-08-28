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
namespace WalleProject.Web.t_user
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
					int u_ID=(Convert.ToInt32(strid));
					ShowInfo(u_ID);
				}
			}
		}
		
	private void ShowInfo(int u_ID)
	{
		WalleProject.BLL.t_user bll=new WalleProject.BLL.t_user();
		WalleProject.Model.t_user model=bll.GetModel(u_ID);
		this.lblu_address.Text=model.u_address;
		this.lblu_lastLoginDate.Text=model.u_lastLoginDate.ToString();
		this.lblu_creaditsLogID.Text=model.u_creaditsLogID.ToString();
		this.lblu_registrationDate.Text=model.u_registrationDate.ToString();
		this.lblu_ID.Text=model.u_ID.ToString();
		this.lblu_nickName.Text=model.u_nickName;
		this.lblu_category.Text=model.u_category;
		this.lblu_birthDate.Text=model.u_birthDate.ToString();
		this.lblu_state.Text=model.u_state;
		this.lblu_passWord.Text=model.u_passWord;
		this.lblu_integral.Text=model.u_integral.ToString();
		this.lblu_creditGrade.Text=model.u_creditGrade;
		this.lblu_name.Text=model.u_name;
		this.lblu_pic_ID.Text=model.u_pic_ID.ToString();

	}


    }
}
