using Maticsoft.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.StaffSystem
{
    public partial class InformationEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Model.t_staff staff = (Model.t_staff)Session["UserInfo"];
                if (staff == null) { Response.Redirect("../Admin/Login.aspx"); }
                ShowInfo(staff.sta_id);
            }
        }
        private void ShowInfo(long sta_id)
        {
            WalleProject.BLL.t_staff bll = new WalleProject.BLL.t_staff();
            WalleProject.Model.t_staff model = bll.GetModel(sta_id);
            this.txtsta_userName.Text = model.sta_userName;
            this.txtsta_maritalStatus.Text = model.sta_maritalStatus;
            this.txtsta_IDNumber.Text = model.sta_IDNumber;
            this.txtsta_homeAddress.Text = model.sta_homeAddress;
            this.txtsta_phone.Text = model.sta_phone;
            this.txtsta_name.Text = model.sta_name;
            this.staffid.InnerText = model.sta_id.ToString();

        }

        public void btnSave_Click(object sender, EventArgs e)
        {

            string strErr = "";
            if (this.txtsta_userName.Text.Trim().Length == 0)
            {
                strErr += "用户名不能为空！\\n";
            } 
            if (this.txtsta_IDNumber.Text.Trim().Length == 0)
            {
                strErr += "身份证号码不能为空！\\n";
            } 
            if (this.txtsta_phone.Text.Trim().Length == 0)
            {
                strErr += "电话号码不能为空！\\n";
            }
            if (this.txtsta_name.Text.Trim().Length == 0)
            {
                strErr += "姓名不能为空！\\n";
            }

            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            string sta_userName = this.txtsta_userName.Text;
            string sta_maritalStatus = this.txtsta_maritalStatus.Text;
            string sta_IDNumber = this.txtsta_IDNumber.Text;
            string sta_homeAddress = this.txtsta_homeAddress.Text;
            string sta_phone = this.txtsta_phone.Text;
            string sta_name = this.txtsta_name.Text;


            WalleProject.Model.t_staff model = new BLL.t_staff().GetModel(Convert.ToInt32( staffid.InnerText));
            model.sta_userName = sta_userName;
            model.sta_maritalStatus = sta_maritalStatus;
            model.sta_IDNumber = sta_IDNumber;
            model.sta_homeAddress = sta_homeAddress;
            model.sta_phone = sta_phone;
            model.sta_name = sta_name;

            WalleProject.BLL.t_staff bll = new WalleProject.BLL.t_staff();
            bll.Update(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "Default.aspx");

        }


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"..\StaffSystem\InformationView.aspx");
        }

    }
}