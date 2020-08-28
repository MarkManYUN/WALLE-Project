using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.User
{
    public partial class AddressShow : System.Web.UI.Page
    {
        public string strid = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.Params["aid"] != null && Request.Params["aid"].Trim() != "")
                {
                    strid = Request.Params["aid"];
                    int add_ID = (Convert.ToInt32(strid));
                    ShowInfo(add_ID);
                }
            }
        }

        private void ShowInfo(int add_ID)
        {
            WalleProject.BLL.t_address bll = new WalleProject.BLL.t_address();
            WalleProject.Model.t_address model = bll.GetModel(add_ID);
            this.lbladd_u_ID.Text = model.add_u_ID.ToString();
            this.lbladd_contactName.Text = model.add_contactName;
            this.lbladd_contactPhone.Text = model.add_contactPhone;
            this.lbladd_date.Text = model.add_date.ToString();
            this.lbladd_postcode.Text = model.add_postcode.ToString();
            this.lbladd_default.Text = model.add_default;
            this.lbladd_address.Text = model.add_address;
            this.lbladd_counties.Text = model.add_counties;
            this.lbladd_city.Text = model.add_city;
            this.lbladd_province.Text = model.add_province;
            this.lbladd_ID.Text = model.add_ID.ToString();

        }

    }
}