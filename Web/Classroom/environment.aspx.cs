using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WalleProject.Web.Code;

namespace WalleProject.Web.Classroom
{
    public partial class environment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            div_submenuHolder.Controls.Add(SubMenu.GetSubmenu(4));
        }
    }
}