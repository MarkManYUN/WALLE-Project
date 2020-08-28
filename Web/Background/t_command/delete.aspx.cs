using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.t_command
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				WalleProject.BLL.t_command bll=new WalleProject.BLL.t_command();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int command_ID=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(command_ID);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}