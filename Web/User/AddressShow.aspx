<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="AddressShow.aspx.cs" Inherits="WalleProject.Web.User.AddressShow" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Main content -->
    <div class="templatemo-content col-1 light-gray-bg">

        <div class="templatemo-content-container">
            <div class="templatemo-content-widget white-bg">
                <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                    <tr>
                        <td class="tdbg">

                            <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                <tr>
                                    <td height="25" width="30%" align="right">用户ID：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:Label ID="lbladd_u_ID" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="25" width="30%" align="right">联系人姓名：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:Label ID="lbladd_contactName" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="25" width="30%" align="right">联系电话：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:Label ID="lbladd_contactPhone" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="25" width="30%" align="right">添加时间：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:Label ID="lbladd_date" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="25" width="30%" align="right">邮编：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:Label ID="lbladd_postcode" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="25" width="30%" align="right">默认：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:Label ID="lbladd_default" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="25" width="30%" align="right">详细地址：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:Label ID="lbladd_address" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="25" width="30%" align="right">所在区县：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:Label ID="lbladd_counties" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="25" width="30%" align="right">所在城市：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:Label ID="lbladd_city" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="25" width="30%" align="right">所在省份：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:Label ID="lbladd_province" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="25" width="30%" align="right">地址编号：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:Label ID="lbladd_ID" runat="server"></asp:Label>
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
<asp:Content ID="Content3" ContentPlaceHolderID="footJS" runat="server">
</asp:Content>
