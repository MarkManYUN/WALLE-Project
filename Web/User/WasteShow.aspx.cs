using Maticsoft.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.User
{
    public partial class WasteShow : System.Web.UI.Page
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
                    Response.Redirect("WasteView.aspx?id=5");
                }
                userid.Text = user.u_ID.ToString();
                if (Request.Params["wid"] != null && Request.Params["wid"].Trim() != "")
                {
                    strid = Request.Params["wid"];
                    int com_ID = (Convert.ToInt32(strid));
                    ShowInfo(com_ID);

                }
                else
                {
                    Response.Redirect("WasteView.aspx?id=5");
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
        protected void btnSave_Click(object sender, EventArgs e)
        {
          
            string strErr = "";
            if (int.Parse(txt_number.Value) <= 0  )
            {
                strErr = "回收的数量不符合要求";
            }
            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }

            int number = int.Parse(txt_number.Value);
            int addressID;
            if (r6.Checked)
            {
                addressID = int.Parse(ListBox1.SelectedValue);
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

            int tra_U_ID = int.Parse(userid.Text);
            decimal tra_transactionAmount = decimal.Parse(this.lblwas_price2.Text);
            DateTime tra_transactionDate = DateTime.Now;
            string tra_accomplish = "发布";
            int tra_staff_id = 0;
            int sta_comwas_id = int.Parse(this.lblwas_ID.Text);
            int tra_number = int.Parse(txt_number.Value);
            // int tra_addressID = int.Parse(this.rad_address.SelectedValue);
            string tra_type = "废品";
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
            // model.tra_addressID = tra_addressID;
            model.tra_type = tra_type;
            model.tra_vaild = tra_vaild;
            model.tra_sort = tra_sort;

            WalleProject.BLL.t_tradingrecord bll = new WalleProject.BLL.t_tradingrecord();
            bll.Add(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "发布成功，等待回收员上门！", "WasteView.aspx?id=5");


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
            Response.Redirect("WasteView.aspx?id=5");
        }

    }
}