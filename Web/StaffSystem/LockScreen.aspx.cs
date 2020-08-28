using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.StaffSystem
{
    public partial class LockScreen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Model.t_staff staff = (Model.t_staff)Session["UserInfo"];
                HttpCookie staffc = new HttpCookie("staff");
                if (staff != null)
                {
                    Session["UserInfo"] = null;
                    staffc.Value = "用户信息";
                    // 设定cookie的生命周期，在这里定义为一个小时
                    DateTime dtNow = DateTime.Now;
                    TimeSpan tsMinute = new TimeSpan(0, 5, 3, 0);
                    staffc.Expires = dtNow + tsMinute;
                    staffc["staffImg"] = new BLL.t_picture().GetModel(Convert.ToInt32(staff.sta__pic_id)).pic_valid;
                    staffc["staffName"] = staff.sta_userName;
                    staffc["staffUserName"] = staff.sta_id.ToString();
                    staffc["staffpw"] = staff.sta_passWord;
                    staffc["staffID"] = staff.sta_id.ToString();
                    Response.Cookies.Add(staffc);
                    imgPhoto.Src = staffc.Values["staffImg"];
                    StaffName.Text = staffc.Values["staffName"];
                }
                else
                {
                    if (staffc.Values["staffName"] == "" || staffc == null)
                    {
                        Response.Redirect("../Admin/Login.aspx");
                    }
                    else
                    {
                        imgPhoto.Src = staffc.Values["staffImg"];
                        StaffName.Text = staffc.Values["staffName"];
                    }
                }

            }
        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            HttpCookie staffc = Request.Cookies["staff"];

            string userName = staffc.Values["staffID"];
            string Password = Maticsoft.Common.PageValidate.InputText(password.Value.Trim(), 30);

            bool isNumber = Maticsoft.Common.PageValidate.IsNumber(userName);
            //验证登录信息，如果验证通过则返回当前用户对象的安全上下文信息
            // AccountsPrincipal newUser = AccountsPrincipal.ValidateLogin(userName, Password);
            BLL.t_staff staff = new BLL.t_staff();
            if (isNumber)
            {
                if (staff.Exists(int.Parse(userName)))
                {
                    if (staff.IsLogin(int.Parse(userName), Password))
                    {
                        WalleProject.Model.t_staff _Staff = new WalleProject.Model.t_staff();
                        _Staff = staff.GetModel(int.Parse(userName));
                        Session["UserInfo"] = _Staff;
                        Response.Redirect("../StaffSystem/Default.aspx?menuid=1");
                    }
                    else
                    {
                        Response.Write("<script>alert('您输入的密码不正确!')</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('您输入的用户名不存在!')</script>");
                }
            }
        }
    }
}