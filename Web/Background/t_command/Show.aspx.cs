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
namespace WalleProject.Web.t_command
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
					int command_ID=(Convert.ToInt32(strid));
					ShowInfo(command_ID);
				}
			}
		}
		
	private void ShowInfo(int command_ID)
	{
		WalleProject.BLL.t_command bll=new WalleProject.BLL.t_command();
		WalleProject.Model.t_command model=bll.GetModel(command_ID);
		this.lblcommand_user_ID.Text=model.command_user_ID.ToString();
		this.lblcommand_staff_ID.Text=model.command_staff_ID.ToString();
		this.lblcommand_content.Text=model.command_content;
		this.lblcommand_ID.Text=model.command_ID.ToString();
		this.lblcommand_Delete.Text=model.command_Delete.ToString();
		this.lblcommand_Valid.Text=model.command_Valid.ToString();
		this.lblcommand_Date.Text=model.command_Date.ToString();

	}


    }
}
