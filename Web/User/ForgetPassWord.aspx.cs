using Maticsoft.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.User
{
    public partial class ForgetPassWord : System.Web.UI.Page
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
                    string Password = MD5Enctypt.MD5.Md5Encrypt( PageValidate.InputText(input_passWord.Text.Trim(), 30));
                    string Password2 = MD5Enctypt.MD5.Md5Encrypt( PageValidate.InputText(input_passWord2.Text.Trim(), 30));
                    string phone = PageValidate.InputText(input_phone.Text.Trim(), 15);
                    string name = PageValidate.InputText(input_Name.Text.Trim(), 30);
                    string idnumber = PageValidate.InputText(input_IDnumber.Text.Trim(), 4);

                    BLL.t_user t_User = new BLL.t_user();
                    bool isPhoneExists = t_User.Exists(phone);
                    if (isPhoneExists)
                    {
                        Model.t_user userF = new BLL.t_user().GetModel(phone);

                        if (!PageValidate.IsNumber(idnumber))
                        {
                            this.lblMsg.Text = "您输入的身份证号码不是数字！";
                            Response.Write("<script> alert('您输入的身份证号码不是数字!')</script>");
                        }
                        else

                        {
                            Model.t_user user = new Model.t_user();
                            user.u_birthDate = DateTime.Parse(this.input_birthdate.Text);
                            user.u_creaditsLogID = int.Parse(this.input_IDnumber.Text);
                            user.u_name = input_Name.Text;
                            user.u_phone = input_phone.Text;
                            user.u_passWord = input_passWord.Text;

                            if (user.u_birthDate != userF.u_birthDate)
                            {
                                this.lblMsg.Text = "您输入的生日与注册时输入的不匹配！";
                                Response.Write("<script> alert('您输入的生日与注册时输入的不匹配!')</script>");

                            }
                            else
                            if (user.u_creaditsLogID != userF.u_creaditsLogID)
                            {
                                this.lblMsg.Text = "您输入的身份证后四位数字与注册时输入的不匹配！";
                                Response.Write("<script> alert('您输入的身份证后四位数字与注册时输入的不匹配!')</script>");

                            }
                            else
                            if (user.u_name != userF.u_name)
                            {
                                this.lblMsg.Text = "您输入的姓名与注册时输入的不匹配！";
                                Response.Write("<script> alert('您输入的姓名与注册时输入的不匹配!')</script>");

                            }
                            if (user.u_phone != userF.u_phone)
                            {
                                this.lblMsg.Text = "您输入的电话号码与注册时输入的不匹配！";
                                Response.Write("<script> alert('您输入的电话号码与注册时输入的不匹配!')</script>");

                            }
                            else
                            {
                                userF.u_birthDate = user.u_birthDate;
                                userF.u_creaditsLogID = user.u_creaditsLogID;
                                userF.u_name = user.u_name;
                                userF.u_phone = user.u_phone;
                                userF.u_passWord = user.u_passWord;

                                t_User.Update(userF);

                                Response.Write("<script> alert('成功重置，回到登录页面!')</script>");
                                Response.Redirect("../User/UserLogin.aspx");
                            }

                        }
                    }
                    else
                    {
                        Response.Write("<script> alert('该用户没有注册，回到注册页面!')</script>");
                        Response.Redirect("../User/UserRigister.aspx");
                    }
                    
                }
            }
            else
            {
                Response.Redirect("../User/ForgetPassWord.aspx");
            }
            #endregion


        }
    }
}