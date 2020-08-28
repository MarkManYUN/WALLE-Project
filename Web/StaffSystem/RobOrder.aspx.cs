using Maticsoft.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.StaffSystem
{
    public partial class RobOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Model.t_staff t_staff = (Model.t_staff)Session["UserInfo"];

                if (t_staff == null)
                {
                    Response.Redirect("Default.aspx?id=1");
                }
                userid2.Text=  userid.Text = t_staff.sta_id.ToString();
                
                if (Request["rid"] != null)
                {
                    string id = Request["rid"];
                    Model.t_tradingrecord tradingrecord = new BLL.t_tradingrecord().GetModel(int.Parse(id));
                    tradingrecord.tra_staff_id = int.Parse(t_staff.sta_id.ToString());
                    if (tradingrecord.tra_accomplish == "发布")
                    {
                        tradingrecord.tra_accomplish = "已接单";
                        new BLL.t_tradingrecord().Update(tradingrecord);
                    }
                    else
                    {
                        MessageBox.Show(this, "不能接单了，对方可能已经取消了订单或者已经接单了");
                    }
                }

            }
        }
    }
}