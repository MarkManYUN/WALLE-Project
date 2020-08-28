using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.User
{
    public partial class RecyclingCar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Model.t_user user = (Model.t_user)Session["UserInfo"];

                if (user == null)
                {
                    Response.Redirect("UserLogin.aspx");
                }
                userid.Text = user.u_ID.ToString();
                if (Request["rid"] != null)
                {
                  string id=  Request["rid"];
                    Model.t_tradingrecord tradingrecord = new BLL.t_tradingrecord().GetModel(int.Parse(id));
                    tradingrecord.tra_accomplish = "已取消";
                    new BLL.t_tradingrecord().Update(tradingrecord);

                }

            }
        }
    }
}