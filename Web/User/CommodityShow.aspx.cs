using Maticsoft.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.User
{
    public partial class CommodityShow : System.Web.UI.Page
    {
        public string strid = "";
        Model.t_user user;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                user = (Model.t_user)Session["UserInfo"];

                if (user == null)
                {
                    Response.Redirect("CommodityView.aspx?id=9");
                }
                userid.Text = user.u_ID.ToString();
                if (Request.Params["cid"] != null && Request.Params["cid"].Trim() != "")
                {
                    strid = Request.Params["cid"];
                    int com_ID = (Convert.ToInt32(strid));
                    ShowInfo(com_ID);

                }
                else
                {
                    Response.Redirect("CommodityView.aspx?id=9");
                }
            }
        }
        private void EditCommodityShow(string id)
        {

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
        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {


                string strErr = "";

                int number = int.Parse(txt_number.Value);
                int addressID;
                if (number <= 0 &&number>int.Parse( lblcom_number.Text))
                {
                    strErr = "回收的数量不符合要求";
                }
                if (strErr != "")
                {
                    MessageBox.Show(this, strErr);
                    return;
                }

                if (r6.Checked)
                {
                    addressID = int.Parse(lb_address.SelectedValue);
                }
                else
                {
                    Model.t_address address = new Model.t_address();
                    address.add_province = ddl_p.Items[ddl_p.SelectedIndex].Text;
                    address.add_city = ddl_c.Items[ddl_c.SelectedIndex].Text;
                    address.add_counties = ddl_d.Items[ddl_d.SelectedIndex].Text;
                    address.add_address = input_Address.Text;
                    address.add_date = DateTime.Now;
                    address.add_default = "0";
                    address.add_u_ID = int.Parse(userid.Text);
                    address.add_postcode = 000000;
                    address.add_contactName = input_userName.Text;
                    address.add_contactPhone = input_phone.Text;
                    address.add_ID = new BLL.t_address().GetMaxId();
                    bool istrue = new BLL.t_address().Add(address);
                    addressID = address.add_ID;
                }
                user = new BLL.t_user().GetModel(int.Parse(userid.Text));
                int tra_U_ID = int.Parse(userid.Text);
                decimal tra_transactionAmount = decimal.Parse(this.lblcom_conversionInt.Text);
                DateTime tra_transactionDate = DateTime.Now;
                string tra_accomplish = "发布";
                int tra_staff_id = 0;
                int sta_comwas_id = int.Parse(this.lblcom_id.Text);
                int tra_number = int.Parse(this.txt_number.Value);
                if (user.u_integral < tra_number * tra_transactionAmount)
                {
                    strErr += "你的积分不够哦！\\n";
                    MessageBox.Show(this, strErr);
                    return;
                }
                user.u_integral = Convert.ToInt32(user.u_integral - tra_number * tra_transactionAmount);
                bool isuser = new BLL.t_user().Update(user);
                // int tra_addressID = int.Parse(this.rad_address.SelectedValue);
                string tra_type = "商品";
                string tra_vaild = "是";
                int tra_sort = 1;

                WalleProject.Model.t_tradingrecord model = new WalleProject.Model.t_tradingrecord();
                model.tra_addressID = addressID;
                model.tra_U_ID = tra_U_ID;
                model.tra_transactionAmount = tra_transactionAmount;
                model.tra_transactionDate = tra_transactionDate;
                model.tra_accomplish = tra_accomplish;
                model.tra_staff_id = tra_staff_id;
                model.sta_comwas_id = sta_comwas_id;
                model.tra_number = tra_number;
                model.tra_type = tra_type;
                model.tra_vaild = tra_vaild;
                model.tra_sort = tra_sort;

                WalleProject.BLL.t_tradingrecord bll = new WalleProject.BLL.t_tradingrecord();
                bll.Add(model);
                Maticsoft.Common.MessageBox.ShowAndRedirect(this, "发布成功，等待回收员接单", "CommodityView.aspx?id=9");

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);

            }
        }
        //第二个DDL,数据绑定完成后,要求第三个DDL重新进行数据绑定
        protected void load_d(object sender, EventArgs e)
        {
            ddl_d.DataBind();
        }


        //最后一个DDL,如果内容为空,则不显示
        protected void checkitems(object s, EventArgs e)
        {
            if (ddl_d.Items.Count == 0) { ddl_d.Style["display"] = "none"; } else { ddl_d.Style.Remove("display"); }
        }

        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("CommodityView.aspx?id=9");
        }

    }
}