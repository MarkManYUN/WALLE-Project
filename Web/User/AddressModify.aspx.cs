using Maticsoft.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.User
{
    public partial class AddressModify : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.Params["aid"] != null && Request.Params["aid"].Trim() != "")
                {
                    int add_ID = (Convert.ToInt32(Request.Params["aid"]));
                    ShowInfo(add_ID);
                }
            }
        }

        private void ShowInfo(int add_ID)
        {
            WalleProject.BLL.t_address bll = new WalleProject.BLL.t_address();
            WalleProject.Model.t_address model = bll.GetModel(add_ID);
            this.txtadd_u_ID.Text = model.add_u_ID.ToString();
            this.txtadd_contactName.Text = model.add_contactName;
            this.txtadd_contactPhone.Text = model.add_contactPhone;
            this.txtadd_date.Text = model.add_date.ToString();
            this.txtadd_postcode.Text = model.add_postcode.ToString();
            this.txtadd_default.Text = model.add_default;
            this.txtadd_address.Text = model.add_address;
            this.txtadd_counties.Text = model.add_counties;
            this.txtadd_city.Text = model.add_city;
            this.txtadd_province.Text = model.add_province;
            this.lbladd_ID.Text = model.add_ID.ToString();

        }

        public void btnSave_Click(object sender, EventArgs e)
        {

            string strErr = "";
            if (!PageValidate.IsNumber(txtadd_u_ID.Text))
            {
                strErr += "add_u_ID格式错误！\\n";
            }
            if (this.txtadd_contactName.Text.Trim().Length == 0)
            {
                strErr += "add_contactName不能为空！\\n";
            }
            if (this.txtadd_contactPhone.Text.Trim().Length == 0)
            {
                strErr += "add_contactPhone不能为空！\\n";
            }
            if (!PageValidate.IsDateTime(txtadd_date.Text))
            {
                strErr += "add_date格式错误！\\n";
            }
            if (!PageValidate.IsNumber(txtadd_postcode.Text))
            {
                strErr += "add_postcode格式错误！\\n";
            }
            if (this.txtadd_default.Text.Trim().Length == 0)
            {
                strErr += "add_default不能为空！\\n";
            }
            if (this.txtadd_address.Text.Trim().Length == 0)
            {
                strErr += "add_address不能为空！\\n";
            }
            if (this.txtadd_counties.Text.Trim().Length == 0)
            {
                strErr += "add_counties不能为空！\\n";
            }
            if (this.txtadd_city.Text.Trim().Length == 0)
            {
                strErr += "add_city不能为空！\\n";
            }
            if (this.txtadd_province.Text.Trim().Length == 0)
            {
                strErr += "add_province不能为空！\\n";
            }

            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            int add_u_ID = int.Parse(this.txtadd_u_ID.Text);
            string add_contactName = this.txtadd_contactName.Text;
            string add_contactPhone = this.txtadd_contactPhone.Text;
            DateTime add_date = DateTime.Parse(this.txtadd_date.Text);
            int add_postcode = int.Parse(this.txtadd_postcode.Text);
            string add_default = this.txtadd_default.Text;
            string add_address = this.txtadd_address.Text;
            string add_counties = this.txtadd_counties.Text;
            string add_city = this.txtadd_city.Text;
            string add_province = this.txtadd_province.Text;
            int add_ID = int.Parse(this.lbladd_ID.Text);


            WalleProject.Model.t_address model = new WalleProject.Model.t_address();
            model.add_u_ID = add_u_ID;
            model.add_contactName = add_contactName;
            model.add_contactPhone = add_contactPhone;
            model.add_date = add_date;
            model.add_postcode = add_postcode;
            model.add_default = add_default;
            model.add_address = add_address;
            model.add_counties = add_counties;
            model.add_city = add_city;
            model.add_province = add_province;
            model.add_ID = add_ID;

            WalleProject.BLL.t_address bll = new WalleProject.BLL.t_address();
            bll.Update(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "AddressView.aspx?id=7");

        }


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddressView.aspx?id=7");
        }
    }
}