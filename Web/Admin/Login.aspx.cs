using System;
using LTP.Accounts.Bus;
using System.Web.Security;
using WalleProject.BLL;
using WalleProject.Model;

using MD5Enctypt;

namespace Maticsoft.Web.Admin
{
    /// <summary>
    /// Login 的摘要说明。
    /// </summary>
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {
            if (Request["com"] != null)
            {
                Session["UserInfo"] = null;
            }
            if (Session["UserInfo"] != null && Session["UserInfo"] is WalleProject.Model.t_staff)
            {
                Response.Redirect("../StaffSystem/Default.aspx?menuid=1");
            }
            if (!this.IsPostBack)
            {
                this.ViewState["GUID"] = System.Guid.NewGuid().ToString();
                this.lblGUID.Text = this.ViewState["GUID"].ToString();
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
            this.btnLogin.Click += new System.Web.UI.ImageClickEventHandler(this.btnLogin_Click);

        }
        #endregion

        private void btnLogin_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {

            if ((Session["PassErrorCountAdmin"] != null) && (Session["PassErrorCountAdmin"].ToString() != ""))
            {
                int PassErroeCount = Convert.ToInt32(Session["PassErrorCountAdmin"]);
                if (PassErroeCount > 3)
                {
                    txtUsername.Disabled = true;
                    txtPass.Disabled = true;
                    btnLogin.Enabled = false;
                    this.lblMsg.Text = "对不起，你错误登录了三次，系统登录锁定！";
                    return;
                }
            }
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
                    string userName = Maticsoft.Common.PageValidate.InputText(txtUsername.Value.Trim(), 30);
                    string Password = MD5.Md5Encrypt(Maticsoft.Common.PageValidate.InputText(txtPass.Value.Trim(), 30));

                    bool isNumber = Maticsoft.Common.PageValidate.IsNumber(userName);
                    WalleProject.BLL.t_staff staff = new WalleProject.BLL.t_staff();
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
            else
            {
                Response.Redirect("../Admin/Login.aspx");
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
