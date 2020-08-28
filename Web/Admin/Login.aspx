<%@ Page Language="c#" CodeBehind="Login.aspx.cs" AutoEventWireup="True" Inherits="Maticsoft.Web.Admin.Login" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
<head>
    <title>WALL-E员工管理系统</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <meta name="description" content=""/>
    <meta name="author" content=""/>

    <!-- Le styles -->
    <script type="text/javascript" src="assets/js/jquery.min.js"></script>

    <!--  <link rel="stylesheet" href="assets/css/style.css"> -->
    <link rel="stylesheet" href="assets/css/loader-style.css"/>
    <link rel="stylesheet" href="assets/css/bootstrap.css"/>
    <link rel="stylesheet" href="assets/css/signin.css"/>

    <!-- HTML5 shim, for IE6-8 support of HTML5 elements -->
    <!--[if lt IE 9]>
        <script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
        <![endif]-->
    <!-- Fav and touch icons -->
    <link rel="shortcut icon" href="assets/ico/minus.png"/>
    <!--  <link href="images/login.css" type="text/css" rel="stylesheet">  -->


    <link href="images/login.css" type="text/css" rel="stylesheet"/>

    <script language="javascript" type="text/javascript">
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
            var username = $("#txtUsername");
            var password = $("#txtPass");
            var checkcode = $("#CheckCode");
            var s = username.val();
            if (username.val().length==0) {
                alert("请输入用户名！");
                username.focus();
                return false;
            }
            if (password.val().length==0) {
                alert("请输入密码！");
                password.focus();
                return false;
            }

            if (checkcode.val().length==0) {
                alert("请输入验证码！");
                checkcode.focus();
                return false;
            }
            return true;
        }



        function focusNext(nextName, evt, num, t, lastName) {
            evt = (evt) ? evt : event;
            var charCode = (evt.charCode) ? evt.charCode :
                ((evt.which) ? evt.which : evt.keyCode);
            if (charCode == 13 || charCode == 3) {
                var nextobj = document.getElementById(nextName);
                var lastobj = document.getElementById(lastName);

                if (num == 1 && isEmptyStr(t.value)) {
                    alert("请输入用户名！");
                    t.focus();
                    return false;
                }


                if (num == 2 && isEmptyStr(t.value)) {
                    alert("请输入密码！");
                    t.focus();
                    return false;
                }

                if (lastobj != null && isEmptyStr(lastobj.value)) {
                    alert("请输入用户名！");
                    lastobj.focus();
                    return false;
                }

                nextobj.focus();
                return false;
            }
            return true;
        }


    </script>
    <style type="text/css">
        .linka:hover {
            color: #d5d5d5;
        }
    </style>
</head>
<body leftmargin="0" topmargin="0" marginheight="0" marginwidth="0" 
    style="background-image: url('../img/bg.jpg'); background-repeat: no-repeat; background-size: cover;" />


    <div id="preloader">
        <div id="status">&nbsp;</div>
    </div>

<form id="Form1" method="post" runat="server">
    <br>
    <br>
    <br>
    <br>
    <br>
    <table width="620" border="0" align="center" cellpadding="0" cellspacing="0">
        <tbody>
            <tr>
                <td width="620">
                    <img height="11" src="#" width="650">
                </td>
            </tr>
            <tr>
                <td align="center" background="images/login_p_img03.gif" id="logo-login" class="container">
                    <br />
                    <table width="570" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td>
                                <table cellspacing="0" cellpadding="0" width="570" border="0">
                                    <tbody>
                                        <tr>

                                            <td align="right" valign="top">
                                                <h1 style="text-align: center; font-family:'STSong';">
                                                    <img src="../img/logo_4.png" /><br />
                                                    <b>
                                                       员工管理系统</b> <span>v1.0</span></h1>
                                                

                                                <a href="../Default.aspx" style="position: absolute; margin-left: 0px; margin-top: -110px;">
                                                    <img width="30px" height="30px" src="../img/exit.png" /></a></td>
                                        </tr>
                                    </tbody>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;<asp:label id="lblGUID" runat="server" style="display: none"></asp:label>
                            </td>
                        </tr>
                        <tr>
                            <td>

                                <img src="#" width="570" height="3"/>
                            </td>
                        </tr>
                        <tr>
                            <td align="center">
                                <table width="520" border="0" cellspacing="0" cellpadding="0">
                                    <tr>
                                        <td width="223" height="220">
                                            <img src="../img/login.png" style="height: 100%; width: 100%;padding-right:20%;" /></td>
                                        <td align="center">
                                            <table cellspacing="0" cellpadding="0" border="0">
                                                <tr class="form-group">
                                                    <td width="210" height="25" valign="top">
                                                        <label for="inputUsernameEmail" style="color: #d5d5d5;">用户名</label>
                                                        <input class="nemo01 form-control" tabindex="1" maxlength="22" size="22" name="user" id="txtUsername"
                                                            runat="server" onkeypress="return focusNext('txtPass', event,1,this,null)"/>
                                                    </td>

                                                </tr>
                                                <tr class="form-group">
                                                    <td valign="bottom" height="12">
                                                        <label for="inputPassword" style="color: #d5d5d5;">密码</label>
                                                        <input name="user" type="password" class="nemo01 form-control" tabindex="1" size="22" maxlength="22"
                                                            id="txtPass" runat="server" onkeypress="return focusNext('CheckCode', event,2,this,'txtUsername')"/>
                                                    </td>
                                                </tr>
                                                <tr class="form-group">
                                                    <td valign="bottom" height="13">
                                                        <table width="100%" height="25" border="0" cellpadding="0" cellspacing="0">
                                                            <tr>
                                                                <td width="70%" align="left">
                                                                    <label for="inputPassword" style="color: #d5d5d5;">验证码：</label>
                                                                    <input class="nemo01 form-control" id="CheckCode" tabindex="3" maxlength="22" size="11" name="user"
                                                                        runat="server"/>
                                                                </td>
                                                                <td width="30%" align="left">
                                                                    <a id="A2" href="#" onclick="ChangeCode();return false;">
                                                                        <asp:image id="ImageCheck" style="margin-top: 20px; width:80px;"
                                                                            class="nemo01 form-control" runat="server" imageurl="../ValidateCode.aspx?GUID=GUID"
                                                                            imagealign="AbsMiddle" tooltip="看不清，换一个">
                                                                            </asp:image>
                                                                    </a>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                    <td width="80" rowspan="3" align="right" valign="middle">
                                                        <asp:imagebutton class="btn-xs" id="btnLogin" style="margin-top: 20px;" OnClientClick="return   validate()"
                                                            width="80" height="34" runat="server" imageurl="../img/Loginto.png"></asp:imagebutton>

                                                    </td>

                                                </tr>
                                            </table>
                                            <br>

                                            <asp:label id="lblMsg" runat="server" backcolor="Transparent" forecolor="Red"></asp:label>
                                     
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td bgcolor="#d5d5d5" style="background: #d5d5d5;"></td>
                        </tr>
                        <tr>
                            <td>
                                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                    <tr>
                                        <td height="70" align="center" style="color: #fff;">Copyright(C)2018 markmanyun.com All Rights Reserved.
                <br />
                                            基于互联网+的WALL-E再生资源回收系统 版权所有
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <img height="11" src="#" width="650">
                </td>
            </tr>
        </tbody>
    </table>
    <br>
</form>










</body>
</html>
