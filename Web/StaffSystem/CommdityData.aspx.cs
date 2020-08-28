using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.StaffSystem
{
    public partial class CommdityData : System.Web.UI.Page
    {
        public string strid = "";
        Model.t_staff user;
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!Page.IsPostBack)
            {
                user = (Model.t_staff)Session["UserInfo"];

                if (user == null)
                {
                    Response.Redirect("CommodityView.aspx?menuid=9");
                }
                if (Request.Params["cid"] != null && Request.Params["cid"].Trim() != "")
                {
                    strid = Request.Params["cid"];
                    int com_ID = (Convert.ToInt32(strid));
                    ShowInfo(com_ID);

                }
                else
                {
                    Response.Redirect("CommodityView.aspx?menuid=9");
                }
            }

        }
        private void ShowInfo(int com_ID)
        {
            WalleProject.BLL.t_commodity bll = new WalleProject.BLL.t_commodity();
            WalleProject.Model.t_commodity model = bll.GetModel(com_ID);
            this.lblcom_id.Text = model.com_ID.ToString();
            this.lblcom_name.Text = model.com_name;
            this.lblcom_productDate.Text = model.com_productDate.ToString();
            this.lblcom_number.Text = model.com_number.ToString();
            this.lblcom_strageID.Text = model.com_strageID;
            this.lblcom_pic_ID.Src = new BLL.t_picture().GetModel(int.Parse(model.com_pic_ID.ToString())).pic_valid;
            this.lblcom_date.Text = model.com_date.ToString();
            this.lblcom_pri_ID.Text = model.com_pri_ID.ToString();
            this.lblcom_conversionInt.Text = Convert.ToString(double.Parse(model.com_pri_ID.ToString()) * 0.8);
            this.lblcom_comc_ID.Text = new BLL.t_commoditycategory().GetModel(int.Parse(model.com_comc_ID.ToString())).comc_name;
            this.lblcom_valid.Text = model.com_valid;
            this.lblcom_valid2.Text = model.com_valid;

        }
    }
}