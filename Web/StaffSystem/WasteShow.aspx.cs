using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.StaffSystem
{
    public partial class WasteShow : System.Web.UI.Page
    {
        public string strid = "";
        Model.t_staff t_staff;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                t_staff = (Model.t_staff)Session["UserInfo"];

                if (t_staff == null)
                {
                    Response.Redirect("WasteView.aspx?id=5");
                }
                userid.Text = t_staff.sta_id.ToString();
                if (Request.Params["wid"] != null && Request.Params["wid"].Trim() != "")
                {
                    strid = Request.Params["wid"];
                    int com_ID = (Convert.ToInt32(strid));
                    ShowInfo(com_ID);

                }
                else
                {
                    Response.Redirect("Default.aspx?id=1");
                }
            }
        }
        WalleProject.BLL.t_tradingrecord bll = new WalleProject.BLL.t_tradingrecord();

        private void EditCommodityShow(string id)
        {

        }

        private void ShowInfo(int was_ID)
        {
            WalleProject.BLL.t_waste bll = new WalleProject.BLL.t_waste();
            WalleProject.Model.t_waste model = bll.GetModel(was_ID);
            this.lblwas_pic_ID.Src = new BLL.t_picture().GetModel(int.Parse(model.was_pic_ID.ToString())).pic_valid; ;
            this.lblwas_ID.Text = model.was_ID.ToString();
            this.lblwas_name.Text = model.was_name;
            this.lblwas_price.Text = model.was_price.ToString();
            this.lblwas_price2.Text = Convert.ToString(double.Parse(model.was_price.ToString()) * 1.2);
            this.lblwas_recoverable.Text = model.was_recoverable.ToString();
            this.lblwas_number.Text = model.was_number.ToString();
            this.lblwas_cate_ID.Text = model.was_cate_ID.ToString();
            this.lblwas_valid.Text = model.was_valid;
            this.lblwas_valid2.Text = model.was_valid;

        }
    }
}