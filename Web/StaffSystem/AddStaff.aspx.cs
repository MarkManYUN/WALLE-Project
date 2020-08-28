using Maticsoft.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.StaffSystem
{
    public partial class AddStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSave_Click(object sender, EventArgs e)
        {

            string strErr = "";
            if (this.txtsta_userName.Text.Trim().Length == 0)
            {
                strErr += "用户名不能为空！\\n";
            } 
            if (this.txtsta_passWord.Text.Trim().Length == 0)
            {
                strErr += "密码不能为空！\\n";
            }
            if (this.txtsta_maritalStatus.Text.Trim().Length == 0)
            {
                strErr += "婚姻状况不能为空！\\n";
            }
            if (this.txtsta_IDNumber.Text.Trim().Length == 0)
            {
                strErr += "身份证号码不能为空！\\n";
            }
            if (this.txtsta_homeAddress.Text.Trim().Length == 0)
            {
                strErr += "家庭住址不能为空！\\n";
            }
            if (this.txtsta_phone.Text.Trim().Length == 0)
            {
                strErr += "电话号码不能为空！\\n";
            }
            if (this.txtsta_name.Text.Trim().Length == 0)
            {
                strErr += "真实姓名不能为空！\\n";
            }
            if (!PageValidate.IsNumber(txtsta__pic_id.Text))
            {
                strErr += "头像ID格式错误！\\n";
            }
            if (!PageValidate.IsNumber(txtsta_tra_id.Text))
            {
                strErr += "用户类型格式错误！\\n";
            } 
            if (!PageValidate.IsDecimal(txtsta_salary.Text))
            {
                strErr += "工资格式错误！\\n";
            }

            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            string sta_userName = this.txtsta_userName.Text;
            DateTime sta_entryDate = DateTime.Now;
            string sta_passWord =MD5Enctypt.MD5.Md5Encrypt( this.txtsta_passWord.Text.Trim());
            string sta_maritalStatus = this.txtsta_maritalStatus.Text;
            string sta_IDNumber = this.txtsta_IDNumber.Text;
            string sta_homeAddress = this.txtsta_homeAddress.Text;
            string sta_phone = this.txtsta_phone.Text;
            string sta_name = this.txtsta_name.Text;
            int sta__pic_id = int.Parse(this.txtsta__pic_id.Text);
            int sta_tra_id = int.Parse(this.txtsta_tra_id.Text); 
            decimal sta_salary = decimal.Parse(this.txtsta_salary.Text);

            WalleProject.Model.t_staff model = new WalleProject.Model.t_staff();
            model.sta_userName = sta_userName;
            model.sta_entryDate = sta_entryDate;
            model.sta_passWord = sta_passWord;
            model.sta_maritalStatus = sta_maritalStatus;
            model.sta_IDNumber = sta_IDNumber;
            model.sta_homeAddress = sta_homeAddress;
            model.sta_phone = sta_phone;
            model.sta_name = sta_name;
            model.sta__pic_id = sta__pic_id;
            model.sta_tra_id = sta_tra_id; 
            model.sta_salary = sta_salary;

            WalleProject.BLL.t_staff bll = new WalleProject.BLL.t_staff();
            bll.Add(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "StaffManage.aspx?menuid=4");

        }


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffManage.aspx?menuid=4");
        }
    }



}