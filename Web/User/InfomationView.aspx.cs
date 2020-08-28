using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.User
{
    public partial class InfomationView : System.Web.UI.Page
    {
        public string strid = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Model.t_user user = (Model.t_user)Session["UserInfo"];
                if (user != null )
                {
                    strid = user.u_ID.ToString();
                    int u_ID = (Convert.ToInt32(strid));
                    lbl_userid.Text = u_ID.ToString();
                    ShowInfo(u_ID);
                }
            }
        }

        private void ShowInfo(int u_ID)
        {
            WalleProject.BLL.t_user bll = new WalleProject.BLL.t_user();
            WalleProject.Model.t_user model = bll.GetModel(u_ID);
            this.lblu_address.Text = model.u_address;
            this.lblu_lastLoginDate.Text = string.Format("{0:yyyy-MM-dd}", model.u_lastLoginDate);
            this.lblu_creaditsLogID.Text = model.u_creaditsLogID.ToString();
            this.lblu_registrationDate.Text = model.u_registrationDate.ToString();
            this.lblu_ID.Text = model.u_ID.ToString();
            this.lblu_nickName.Text = model.u_nickName;
            this.lblu_category.Text = model.u_category;
            this.lblu_birthDate.Text =string.Format("{0:yyyy-MM-dd}", model.u_birthDate);
            this.lblu_state.Text = model.u_state;
            this.lblu_integral.Text = model.u_integral.ToString();
            this.lblu_creditGrade.Text = model.u_creditGrade;
            this.lblu_name.Text = model.u_name;

        }


    }
}