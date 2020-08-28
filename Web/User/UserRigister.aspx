<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserRigister.aspx.cs" Inherits="WalleProject.Web.User.UserRigister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />

    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>WALL-E用户注册</title>
    <meta name="description" content="" />
    <meta name="author" content="templatemo" />
 
    <script type="text/javascript" src="../Admin/assets/js/jquery.min.js"></script>
    <link href="../Admin/assets/css/bootstrap.css" rel="stylesheet" />
  
    <link href="css/font-awesome.min.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/templatemo-style.css" rel="stylesheet" />
    <link rel="stylesheet" href="../Admin/assets/css/loader-style.css" />

 
    <link rel="shortcut icon" href="../Admin/assets/ico/minus.png" />
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
            var username = $("#input_userName");
            var password = $("#input_passWord");
            var password2 = $("#input_passWord2");

            var phone = $("#input_phone");
            var name = $("#input_Name");
            var address = $("#input_Address");

            var checkcode = $("#CheckCode");
            var idnumber = $("#input_IDnumber");
            if (idnumber.val().length == 0) {
                alert("请输入身份证后四位数字！");
                idnumber.focus();
                return false;
            }


            if (phone.val().length == 0) {
                alert("请输入联系电话！");
                username.focus();
                return false;
            }
            if (name.val().length == 0) {
                alert("请输入真实姓名！");
                username.focus();
                return false;
            }
            if (address.val().length == 0) {
                alert("请输入地址！");
                username.focus();
                return false;
            }
            if (username.val().length == 0) {
                alert("请输入用户名！");
                username.focus();
                return false;
            }
            if (password2.val().length == 0) {
                alert("请输入密码2！");
                password.focus();
                return false;
            }
            if (password.val().length == 0) {
                alert("请输入密码1！");
                password.focus();
                return false;
            }
            if (password.val() != password2.val()) {
                alert("输入两次密码不匹配！");
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
    <div class="templatemo-content-widget templatemo-login-widget white-bg" style="background-color: aliceblue;">
        <header class="text-center">
            <div class="">
                <img src="../img/logo_3.png" />
            </div>
            <h1>欢迎注册用户系统</h1>
        </header>
        <!--../Default.aspx-->
        <form action="#" runat="server" class="templatemo-login-form">
            <asp:Label ID="lblGUID" runat="server" Style="display: none"></asp:Label>
            <div class="form-group">
                <div class="form-group">
                    <asp:Label ID="lblMsg" runat="server" BackColor="Transparent" ForeColor="Red"></asp:Label>
                </div>
                <div class="input-group">
                    <div class="input-group-addon"><i class="fa fa-user fa-fw"></i></div>
                    <asp:TextBox type="text" class="form-control" ID="input_userName" runat="server"
                        placeholder="用户名" />
                </div>
            </div>
            <div class="form-group">
                <div class="input-group">
                    <div class="input-group-addon"><i class="fa fa-user fa-fw"></i></div>
                    <asp:TextBox type="text" class="form-control" ID="input_phone" runat="server"
                        placeholder="电话号码" />

                </div>
            </div>
            <div class="form-group">
                <div class="input-group">
                    <div class="input-group-addon"><i class="fa fa-user fa-fw"></i></div>
                    <asp:TextBox type="text" class="form-control" ID="input_IDnumber" runat="server"
                        placeholder="身份证号码后四位数字" />

                </div>
            </div>
            <div class="form-group">
                <div class="input-group">
                    <div class="input-group-addon"><i class="fa fa-user fa-fw"></i></div>

                    <asp:DropDownList ID="ddl_p" class="form-control" Width="33.3%" runat="server" DataSourceID="ads_p"
                        DataTextField="p_name" DataValueField="p_id" AutoPostBack="True">
                    </asp:DropDownList>
                    <asp:AccessDataSource ID="ads_p" runat="server" DataFile="~/DATA/China.mdb"
                        SelectCommand="SELECT * FROM [T_Province]" />

                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>

                    <asp:UpdatePanel ID="Upnl_ddls" runat="server" RenderMode="Inline"
                        UpdateMode="Conditional">
                        <ContentTemplate>

                            <asp:DropDownList ID="ddl_c" class="form-control" Width="33.3%" runat="server" DataSourceID="ads_c"
                                DataTextField="c_name" DataValueField="c_id" AutoPostBack="True" OnDataBound="load_d">
                            </asp:DropDownList>
                            <asp:AccessDataSource ID="ads_c" runat="server" DataFile="../Data/China.mdb"
                                SelectCommand="SELECT [c_name], [c_id] FROM [T_City] WHERE ([c_pid] = ?)">
                                <SelectParameters>
                                    <asp:ControlParameter ControlID="ddl_p" Name="c_pid"
                                        PropertyName="SelectedValue" Type="Int32" />
                                </SelectParameters>
                            </asp:AccessDataSource>



                            <asp:DropDownList ID="ddl_d" class="form-control" Width="33.3%" runat="server" DataSourceID="ads_d" OnDataBound="checkitems"
                                DataTextField="d_name" DataValueField="d_id">
                            </asp:DropDownList>
                            <asp:AccessDataSource ID="ads_d" runat="server" DataFile="../Data/China.mdb"
                                SelectCommand="SELECT [d_id], [d_name] FROM [T_District] WHERE ([d_cid] = ?)">
                                <SelectParameters>
                                    <asp:ControlParameter ControlID="ddl_c" Name="d_cid"
                                        PropertyName="SelectedValue" Type="Int32" />
                                </SelectParameters>
                            </asp:AccessDataSource>


                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="ddl_p" />
                        </Triggers>
                    </asp:UpdatePanel>

                    <asp:TextBox type="text" class="form-control" ID="input_Address" runat="server"
                        placeholder="详细地址" />
                </div>
            </div>





            <div class="form-group">
                <div class="input-group">
                    <div class="input-group-addon"><i class="fa fa-user fa-fw"></i></div>
                    <asp:TextBox type="text" class="form-control" ID="input_Name" runat="server"
                        placeholder="真实姓名" />
                </div>
            </div>
            <div class="form-group">
                <div class="input-group">
                    <div class="input-group-addon"><i class="fa fa-user fa-fw"></i></div>
                    <asp:TextBox type="date" class="form-control" ID="input_birthdate" runat="server"
                        placeholder="出生日期" />

                </div>
            </div>

            <div class="form-group">
                <div class="input-group">
                    <div class="input-group-addon"><i class="fa fa-key fa-fw"></i></div>
                    <asp:TextBox type="password" CssClass="form-control" runat="server"
                        ID="input_passWord" placeholder="输入登录密码" />
                    <asp:TextBox type="password" CssClass="form-control" runat="server"
                        ID="input_passWord2" placeholder="再次输入密码" />
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
                <asp:Button type="button" runat="server" Text="注册" ID="btn_Login"
                    OnClientClick="return validate()"
                    class="templatemo-blue-button width-100" />
            </div>

        </form>
    </div>
    <div class="templatemo-content-widget templatemo-login-widget templatemo-register-widget white-bg" style="background-color: aliceblue;">
        <p>已有账号，点击返回到登录页面<strong><a href="UserLogin.aspx" class="blue-text">回到登录>></a></strong></p>
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
