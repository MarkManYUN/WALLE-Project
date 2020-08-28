<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="InfomationView.aspx.cs" Inherits="WalleProject.Web.User.InfomationView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Main content -->
    <div class="templatemo-content col-1 light-gray-bg">

        <div class="templatemo-content-container">
            <div class="templatemo-content-widget white-bg">
                <div class="form-group">
                    <nav>
                        <ul>
                            <li class="btn btn-default"><a href="PhotoView.aspx?id=3">修改头像</a></li>
                            <li class="btn btn-default"><a href="InfomationEdit.aspx?id=3">编辑个人信息</a></li>
                            <li class="btn btn-default"><a href="ForgetPassWord.aspx">重置密码</a></li>
                        </ul>
                    </nav>
                </div>


                <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                    <tr>
                        <td class="tdbg">

                            <table cellspacing="0" cellpadding="0" width="100%" border="0" class="lead">
                                <tr>
                                    <td height="25" width="30%" align="right">我的编号：</td>
                                    <td height="25" width="*" align="left">WL20180426U00<asp:Label  runat="server" ID="lbl_userid"></asp:Label> </td>
                                </tr><tr>
                                    <td height="25" width="30%" align="right">我的地址：</td>
                                    <td height="25" width="*" align="left"><asp:Label ID="lblu_address" runat="server"></asp:Label>
                                   </td>
                                </tr>
                                <tr>
                                    <td height="25" width="30%" align="right">最后一次登录：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:Label ID="lblu_lastLoginDate" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="25" width="30%" align="right">身份证后四位数字：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:Label ID="lblu_creaditsLogID" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="25" width="30%" align="right">注册时间：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:Label ID="lblu_registrationDate" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="25" width="30%" align="right">用户编号：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:Label ID="lblu_ID" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="25" width="30%" align="right">昵称：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:Label ID="lblu_nickName" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="25" width="30%" align="right">用户类型：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:Label ID="lblu_category" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="25" width="30%" align="right">生日：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:Label ID="lblu_birthDate" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="25" width="30%" align="right">状态：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:Label ID="lblu_state" runat="server"></asp:Label>
                                    </td>
                                </tr>

                                <tr>
                                    <td height="25" width="30%" align="right">我的积分：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:Label ID="lblu_integral" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="25" width="30%" align="right">我的信誉：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:Label ID="lblu_creditGrade" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="25" width="30%" align="right">我的姓名：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:Label ID="lblu_name" runat="server"></asp:Label>
                                    </td>
                                </tr>

                            </table>

                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
