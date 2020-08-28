using Maticsoft.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.StaffSystem
{
    public partial class EditPassWord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Model.t_staff staff = (Model.t_staff)Session["UserInfo"];
            if (staff == null) { Response.Redirect("../Admin/Login.aspx"); }

        }
        public void btnSave_Click(object sender, EventArgs e)
        {

            string strErr = "";
            if (this.txt_passWord1.Text.Trim().Length == 0)
            {
                strErr += "原密码不能为空！\\n";
            }
            if (this.txt_passWord3.Text.Trim().Length == 0)
            {
                strErr += "新密码不能为空！\\n";
            }
            if (this.txt_passWord2.Text.Trim().Length == 0)
            {
                strErr += "密码不能为空！\\n";
            }


            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            string passWord1 =MD5Enctypt.MD5.Md5Encrypt( this.txt_passWord1.Text.Trim());
            string passWord2 = MD5Enctypt.MD5.Md5Encrypt(this.txt_passWord2.Text.Trim());
            string passWord3 = MD5Enctypt.MD5.Md5Encrypt(this.txt_passWord3.Text.Trim()); 
            WalleProject.Model.t_staff model = (Model.t_staff)Session["UserInfo"]; 
            if (passWord1 == model.sta_passWord)
            { 
                if (passWord2 == passWord3)
                {
                    model.sta_passWord = passWord2;
                    WalleProject.BLL.t_staff bll = new WalleProject.BLL.t_staff();
                    bll.Update(model);
                    Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "Default.aspx");
                }
                else
                {
                    strErr += "新密码不匹配！\\n";
                    MessageBox.Show(this, strErr); return;
                }
            }
            else
            {
                strErr += "原密码不正确！\\n";
                MessageBox.Show(this, strErr); return;
            }

        }


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"..\StaffSystem\InformationView.aspx");
        }

    }
}