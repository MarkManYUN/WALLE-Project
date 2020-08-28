<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="WalleProject.Web.User.UserLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    
	    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>WALL-E用户登录</title>
    <meta name="description" content="" />
    <meta name="author" content="templatemo" />
 
        <script type="text/javascript" src="../Admin/assets/js/jquery.min.js"></script>
    <link href="../Admin/assets/css/bootstrap.css" rel="stylesheet" />
 
    <link href="css/font-awesome.min.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/templatemo-style.css" rel="stylesheet" />
   <link rel="stylesheet" href="../Admin/assets/css/loader-style.css"/>

 
 <link rel="shortcut icon" href="../Admin/assets/ico/minus.png" />
    <script  language="javascript" type="text/javascript" >
        function ChangeCode() {

            var date = new Date();
            var myImg = document.getElementById("ImageCheck");
            var GUID = document.getElementById("lblGUID");

            if (GUID != null) {
                if (GUID.innerHTML != "" && GUID.innerHTML != null) {
                    myImg.src = "../ValidateCode.aspx?GUID=" + GUID.innerHTML + "&flag=" + date.getMilliseconds()

                }
            }
            return false;
        }

        function validate() {
            var username = $("#input_userName");
            var password = $("#input_passWord");
            var checkcode = $("#CheckCode");
            var s = username.val();
            if (username.val().length == 0) {
                alert("请输入用户名！");
                username.focus();
                return false;
            }
            if (password.val().length == 0) {
                alert("请输入密码！");
                password.focus();
                return false;
            }

            if (checkcode.val().length == 0) {
                alert("请输入验证码！");
                checkcode.focus();
                return false;
            }
            return true;
        }

    
    </script>
</head>
<body class="light-gray-bg" style="background-image: url('../img/bg5.jpg');">
    <div class="templatemo-content-widget templatemo-login-widget white-bg" style="background-color:aliceblue;">
        <header class="text-center">
            <div class="">
                <img src="../img/logo_3.png" />
            </div>
            <h1>欢迎登录用户系统</h1>
        </header>
        <!--../Default.aspx-->
        <form action="#" runat="server" class="templatemo-login-form">
            <asp:Label ID="lblGUID" runat="server" Style="display: none"></asp:Label>
            <div class="form-group">
                <div class="input-group">
                    <div class="input-group-addon"><i class="fa fa-user fa-fw"></i></div>
                    <asp:TextBox type="text" class="form-control" ID="input_userName" runat="server"
                        placeholder="用户名/电话号码" />
                </div>
            </div>
            <div class="form-group">
                <div class="input-group">
                    <div class="input-group-addon"><i class="fa fa-key fa-fw"></i></div>
                    <asp:TextBox type="password" CssClass="form-control" runat="server"
                        ID="input_passWord" placeholder="******" />
                </div>
            </div>
            <div class="form-group">
                <div class="input-group">
                     <div class="input-group-addon">
                        <i class="glyphicon glyphicon-qrcode"></i>&nbsp;
                   
                        <input class=" width-90" id="CheckCode"
                            tabindex="3" maxlength="22" size="11" name="user" placeholder="输入验证码..."
                            runat="server" />
                        <a id="A2" href="#" onclick="ChangeCode();return false;">
                            <asp:Image ID="ImageCheck" 
                                class=" width-30" runat="server" ImageUrl="../ValidateCode.aspx?GUID=GUID"
                                ImageAlign="AbsMiddle" ToolTip="看不清，换一个"></asp:Image>
                        </a>
                    </div>
                </div>
            </div>
            <div class="form-group">
                <div class="checkbox squaredTwo">
                    <input type="checkbox" runat="server" id="chk_remenberMe" name="cc" />
                    <label for="chk_remenberMe" ><span></span>记住账户</label>
                    <strong  style="float:right;" ><a href="ForgetPassWord.aspx" class="blue-text">忘记密码？</a></strong>
                    
                </div>
            </div>

            <div class="form-group">
                <asp:Button type="button" runat="server" Text="登录" ID="btn_Login"
                    OnClientClick="return validate()" 
                    class="templatemo-blue-button width-100" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblMsg" runat="server" BackColor="Transparent" ForeColor="Red"></asp:Label>
            </div>
        </form>
    </div>
    <div class="templatemo-content-widget templatemo-login-widget templatemo-register-widget white-bg"  style="background-color:aliceblue;">
        <p>没有账号，怎么办? <strong><a href="UserRigister.aspx" class="blue-text">现在注册!</a></strong></p>
        <p>我是游客，怎么办? <strong><a href="../Default.aspx" class="blue-text">回到系统主页!</a></strong></p>

    </div>
    <header class="text-center">
        <p>
            Copyright(C)2018 markmanyun.com All Rights Reserved.
                <br />
            基于互联网+的WALL-E再生资源回收系统 版权所有
        </p>
    </header>
</body>
</html>
