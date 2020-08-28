using Maticsoft.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.User
{
    public partial class InfomationEdit : System.Web.UI.Page
    {
        public string strid = "";
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!Page.IsPostBack)
            {
                Model.t_user user = (Model.t_user)Session["UserInfo"];
                if (user != null)
                {
                    strid = user.u_ID.ToString();
                    int u_ID = (Convert.ToInt32(strid));
                    ShowInfo(u_ID);
                }
            }
        }

        private void ShowInfo(int u_ID)
        {
            WalleProject.BLL.t_user bll = new WalleProject.BLL.t_user();
            WalleProject.Model.t_user model = bll.GetModel(u_ID);
            this.txtu_address.Text = model.u_address;
            this.txtu_creaditsLogID.Text = model.u_creaditsLogID.ToString();
            this.lblu_ID.Text = model.u_ID.ToString();
            this.txtu_nickName.Text = model.u_nickName;
            this.txtu_birthDate.Text = model.u_birthDate.ToString();
            this.txtu_name.Text = model.u_name;

        }

        public void btnSave_Click(object sender, EventArgs e)
        {

            string strErr = "";
            if (this.txtu_address.Text.Trim().Length == 0)
            {
                strErr += "u_address不能为空！\\n";
            }

            if (!PageValidate.IsNumber(txtu_creaditsLogID.Text))
            {
                strErr += "u_creaditsLogID格式错误！\\n";
            }

            if (this.txtu_nickName.Text.Trim().Length == 0)
            {
                strErr += "u_nickName不能为空！\\n";
            }

            if (!PageValidate.IsDateTime(txtu_birthDate.Text))
            {
                strErr += "u_birthDate格式错误！\\n";
            }



            if (this.txtu_name.Text.Trim().Length == 0)
            {
                strErr += "u_name不能为空！\\n";
            }


            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            string u_address = this.txtu_address.Text;
            int u_creaditsLogID = int.Parse(this.txtu_creaditsLogID.Text);
            int u_ID = int.Parse(this.lblu_ID.Text);
            string u_nickName = this.txtu_nickName.Text;
            DateTime u_birthDate = DateTime.Parse(this.txtu_birthDate.Text);
            string u_name = this.txtu_name.Text;


            WalleProject.Model.t_user model =new BLL.t_user().GetModel(u_ID);
            model.u_address = u_address;
            model.u_creaditsLogID = u_creaditsLogID;
            model.u_ID = u_ID;
            model.u_nickName = u_nickName;
            model.u_birthDate = u_birthDate;
            model.u_name = u_name;

            WalleProject.BLL.t_user bll = new WalleProject.BLL.t_user();
            bll.Update(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "Default.aspx?id=1");

        }


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx?id=1");
        }
    }
}