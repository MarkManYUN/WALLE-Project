using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.StaffSystem
{
    public partial class CommodityView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void delmark(object s, CommandEventArgs e)
        {

            new BLL.t_commodity().Delete(Convert.ToInt32(e.CommandArgument.ToString()));
            ListView1.DataBind();
        }

        protected void btn_delmark_Click(object sender, EventArgs e)
        {
           
        }
    }
}