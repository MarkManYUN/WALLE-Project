using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.StaffSystem
{
    public partial class KindEditor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
  content.InnerHtml = new BLL.t_news().GetModel(3).new_content;
        }
        protected void btnTerst_Click(object sender, EventArgs e)
        {

          

            string contentFORM = Server.HtmlDecode(content.InnerHtml);
            Label1.Text = contentFORM;



        }
    }
}