using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.t_staffmenu
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				WalleProject.BLL.t_staffmenu bll=new WalleProject.BLL.t_staffmenu();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int StaM_ID=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(StaM_ID);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}