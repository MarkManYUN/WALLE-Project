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
namespace WalleProject.Web.t_message
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
					int mess_ID=(Convert.ToInt32(strid));
					ShowInfo(mess_ID);
				}
			}
		}
		
	private void ShowInfo(int mess_ID)
	{
		WalleProject.BLL.t_message bll=new WalleProject.BLL.t_message();
		WalleProject.Model.t_message model=bll.GetModel(mess_ID);
		this.lblmess_ID.Text=model.mess_ID.ToString();
		this.lblmess_content.Text=model.mess_content;
		this.lblmess_date.Text=model.mess_date.ToString();
		this.lblmess_inpotance.Text=model.mess_inpotance.ToString();
		this.lblmess_valid.Text=model.mess_valid;
		this.lblmess_type.Text=model.mess_type;

	}


    }
}
