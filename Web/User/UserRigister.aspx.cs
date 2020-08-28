using Maticsoft.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.User
{
    public partial class UserRigister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.ViewState["GUID"] = System.Guid.NewGuid().ToString();
                this.lblGUID.Text = this.ViewState["GUID"].ToString();
            }
        }
        #region Web 窗体设计器生成的代码
        override protected void OnInit(EventArgs e)
        {
            InitializeComponent();
            base.OnInit(e);
        }

        /// <summary>
        /// 设计器支持所需的方法 
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Login.Click += new EventHandler(this.btn_Login_Click1);

        }
        #endregion
        protected void btn_Login_Click1(object sender, EventArgs e)
        {

            Console.WriteLine(Session["CheckCode"]);
            #region 检查验证码
            if ((Session["CheckCode"] != null) && (Session["CheckCode"].ToString() != ""))
            {
                if (Session["CheckCode"].ToString().ToLower() != this.CheckCode.Value.ToLower())
                {
                    this.lblMsg.Text = "输入的验证码有误！";
                    Session["CheckCode"] = null;
                    return;
                }
                else
                {

                    this.lblMsg.Text = "";
                    Session["CheckCode"] = null;
                    string userName = PageValidate.InputText(input_userName.Text.Trim(), 30);
                    string Password =MD5Enctypt.MD5.Md5Encrypt( PageValidate.InputText(input_passWord.Text.Trim(), 30));
                    string Password2 = MD5Enctypt.MD5.Md5Encrypt(PageValidate.InputText(input_passWord2.Text.Trim(), 30));
                    string address = PageValidate.InputText(input_Address.Text.Trim(), 100);
                    string phone = PageValidate.InputText(input_phone.Text.Trim(), 15);
                    string name = PageValidate.InputText(input_Name.Text.Trim(), 30);
                    string idnumber = PageValidate.InputText(input_IDnumber.Text.Trim(), 4);

                    BLL.t_user t_User = new BLL.t_user();
                    bool isPhoneExists = t_User.Exists(phone);
                    if (isPhoneExists)
                    {
                        this.lblMsg.Text = "您输入的电话号码已经注册！";
                        Response.Write("<script> alert('您输入电话号码已经注册!')</script>");
                    }
                    if (Password != Password2)
                    {
                        this.lblMsg.Text = "两次密码不匹配！";
                        Response.Write("<script> alert('两次密码不匹配!')</script>");

                    }
                    if (!PageValidate.IsNumber(idnumber))
                    {
                        this.lblMsg.Text = "您输入的身份证号码不是数字！";
                        Response.Write("<script> alert('您输入的身份证号码不是数字!')</script>");
                    }
                    else
                    {
                        Model.t_user user = new Model.t_user();
                        user.u_address = ddl_p.Items[ddl_p.SelectedIndex].Text 
                            + ddl_c.Items[ddl_c.SelectedIndex].Text 
                            + ddl_d.Items[ddl_d.SelectedIndex].Text + input_Address.Text;
                        user.u_birthDate = DateTime.Parse(this.input_birthdate.Text);
                        user.u_creaditsLogID = int.Parse(this.input_IDnumber.Text);
                        user.u_name = input_Name.Text;
                        user.u_phone = input_phone.Text;
                        user.u_registrationDate = DateTime.Now;
                        user.u_nickName = input_userName.Text;
                        user.u_passWord = Password;
                        t_User.Add(user);

                        Model.t_address addressF = new Model.t_address();
                        addressF.add_contactName = user.u_name;
                        addressF.add_u_ID = new BLL.t_user().GetModel(user.u_phone).u_ID;
                        addressF.add_contactPhone = user.u_phone;
                        addressF.add_address = input_Address.Text;
                        addressF.add_province = ddl_p.Items[ddl_p.SelectedIndex].Text;
                        addressF.add_counties = ddl_d.Items[ddl_d.SelectedIndex].Text;
                        addressF.add_city = ddl_c.Items[ddl_c.SelectedIndex].Text;
                        addressF.add_date = DateTime.Now;
                        addressF.add_default = "1";

                        new BLL.t_address().Add(addressF);
                        Response.Write("<script> alert('成功注册，回到登录页面!')</script>");
                        Response.Redirect("../User/UserLogin.aspx");
                    }

                    #region
                    ////验证登录信息，如果验证通过则返回当前用户对象的安全上下文信息
                    //// AccountsPrincipal newUser = AccountsPrincipal.ValidateLogin(userName, Password);
                    //BLL.t_user user = new BLL.t_user();
                    //if (isNumber)
                    //{
                    //    if (user.Exists(int.Parse(userName)))
                    //    {
                    //        if (user.IsLogin(int.Parse(userName), Password))
                    //        {
                    //            WalleProject.Model.t_user _user = new WalleProject.Model.t_user();
                    //            _user = user.GetModel(int.Parse(userName));
                    //            Session["UserInfo"] = _user;

                    //            HttpCookie cookie = new HttpCookie("USER_NAME");
                    //            cookie.Value = input_userName.Text;
                    //            Response.Cookies.Add(cookie);

                    //            Response.Redirect("../User/Default.aspx");
                    //        }
                    //        else
                    //        {
                    //            this.lblMsg.Text = "您输入的密码不正确！";
                    //            Response.Write("<script>alert('您输入的密码不正确!')</script>");
                    //        }
                    //    }
                    //    else
                    //    {
                    //        this.lblMsg.Text = "您输入的用户名不存在！";
                    //        Response.Write("<script> alert('您输入的用户名不存在!')</script>");
                    //    }
                    //}
                    #endregion

                }
            }
            else
            {
                Response.Redirect("../User/UserRigister.aspx");
            }
            #endregion


            #region
            /*
            if (newUser == null)//登录信息不对
            {
                this.lblMsg.Text = "登陆失败： " + userName;
                if ((Session["PassErrorCountAdmin"] != null) && (Session["PassErrorCountAdmin"].ToString() != ""))
                {
                    int PassErroeCount = Convert.ToInt32(Session["PassErrorCountAdmin"]);
                    Session["PassErrorCountAdmin"] = PassErroeCount + 1;
                }
                else
                {
                    Session["PassErrorCountAdmin"] = 1;
                }
            }
            else
            {

                //根据用户对象的上下文得到用户对象信息，用于得到其他信息
                User currentUser = new LTP.Accounts.Bus.User(newUser);
                //if (currentUser.UserType != "AA")
                //{
                //    this.lblMsg.Text = "你非管理员用户，你没有权限登录后台系统！";
                //    return;
                //}

                //把当前用户对象实例赋给Context.User，这样做将会把完整的用户信息加载到ASP.NET提供的验证体系中
                Context.User = newUser;
                //验证当前用户密码
                if (((SiteIdentity)User.Identity).TestPassword(Password) == 0)
                {
                    this.lblMsg.Text = "你的密码无效！";
                    if ((Session["PassErrorCountAdmin"] != null) && (Session["PassErrorCountAdmin"].ToString() != ""))
                    {
                        int PassErroeCount = Convert.ToInt32(Session["PassErrorCountAdmin"]);
                        Session["PassErrorCountAdmin"] = PassErroeCount + 1;
                    }
                    else
                    {
                        Session["PassErrorCountAdmin"] = 1;
                    }
                }
                else
                {
                    //保存当前用户对象信息
                    FormsAuthentication.SetAuthCookie(userName, false);                    
                    Session["UserInfo"] = currentUser;
                    Session["Style"] = currentUser.Style;
                    if (Session["returnPage"] != null)
                    {
                        string returnpage = Session["returnPage"].ToString();
                        Session["returnPage"] = null;
                        Response.Redirect(returnpage);
                    }
                    else
                    {
                        Response.Redirect("main.htm");
                    }
                }

        }*/
            #endregion

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

    }
}