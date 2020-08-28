using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.User
{
    public partial class UserLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["com"] != null)
            {
                Session["UserInfo"] = null;
            }
            if (Session["UserInfo"] != null && Session["UserInfo"] is Model.t_user)
            {
                Response.Redirect("../User/Default.aspx?id=1");
            }
            else
            {


                if (Request.Cookies["USER_NAME"] != null)
                {
                    input_userName.Text = Request.Cookies["USER_NAME"].Value;
                }
                if (!this.IsPostBack)
                {
                    this.ViewState["GUID"] = System.Guid.NewGuid().ToString();
                    this.lblGUID.Text = this.ViewState["GUID"].ToString();
                }
            }
        }

        #region Web 窗体设计器生成的代码
        override protected void OnInit(EventArgs e)
        {
            //
            // CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
            //
            InitializeComponent();
            base.OnInit(e);
        }

        /// <summary>
        /// 设计器支持所需的方法 - 不要使用代码编辑器修改
        /// 此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Login.Click += new EventHandler(this.btn_Login_Click1);

        }
        #endregion
        protected void btn_Login_Click1(object sender, EventArgs e)
        {
            if ((Session["PassErrorCountAdmin"] != null) && (Session["PassErrorCountAdmin"].ToString() != ""))
            {
                int PassErroeCount = Convert.ToInt32(Session["PassErrorCountAdmin"]);
                if (PassErroeCount > 3)
                {
                    input_userName.Enabled = true;
                    input_passWord.Enabled = true;
                    btn_Login.Enabled = false;
                    this.lblMsg.Text = "对不起，你错误登录了三次，系统登录锁定！";
                    return;
                }

            }
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
                    string userName = Maticsoft.Common.PageValidate.InputText(input_userName.Text.Trim(), 30);
                    string Password = MD5Enctypt.MD5.Md5Encrypt(Maticsoft.Common.PageValidate.InputText(input_passWord.Text.Trim(), 30));

                    bool isNumber = Maticsoft.Common.PageValidate.IsNumber(userName);
                    //验证登录信息，如果验证通过则返回当前用户对象的安全上下文信息
                    // AccountsPrincipal newUser = AccountsPrincipal.ValidateLogin(userName, Password);
                    BLL.t_user user = new BLL.t_user();
                    if (isNumber)
                    {
                        if (user.Exists(int.Parse(userName)))
                        {
                            if (user.IsLogin(int.Parse(userName), Password))
                            {
                                WalleProject.Model.t_user _user = new WalleProject.Model.t_user();
                                _user = user.GetModel(int.Parse(userName));
                                _user.u_lastLoginDate = DateTime.Now;
                                if (new BLL.t_user().Update(_user))
                                {
                                    Session["UserInfo"] = _user;
                                    if (this.chk_remenberMe.Checked)
                                    {
                                        HttpCookie cookie = new HttpCookie("USER_NAME");
                                        cookie.Value = input_userName.Text;
                                        Response.Cookies.Add(cookie);
                                    }


                                    Response.Redirect("../User/Default.aspx?id=1");
                                }
                            }
                            else
                            {
                                this.lblMsg.Text = "您输入的密码不正确！";
                                Response.Write("<script>alert('您输入的密码不正确!')</script>");
                            }
                        }
                        else
                        {
                            this.lblMsg.Text = "您输入的用户名不存在！";
                            Response.Write("<script> alert('您输入的用户名不存在!')</script>");
                        }
                    }

                }
            }
            else
            {
                Response.Redirect("../User/UserLogin.aspx");
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
    }
}