<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="AddressModify.aspx.cs" Inherits="WalleProject.Web.User.AddressModify" %>

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
                                        <asp:TextBox ID="txtadd_u_ID" runat="server" Width="200px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="25" width="30%" align="right">联系人姓名：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:TextBox ID="txtadd_contactName" runat="server" Width="200px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="25" width="30%" align="right">联系电话：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:TextBox ID="txtadd_contactPhone" runat="server" Width="200px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="25" width="30%" align="right">添加时间：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:TextBox ID="txtadd_date" runat="server" Width="70px" onfocus="setday(this)"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="25" width="30%" align="right">邮编：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:TextBox ID="txtadd_postcode" runat="server" Width="200px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="25" width="30%" align="right">是否默认：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:TextBox ID="txtadd_default" runat="server" Width="200px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="25" width="30%" align="right">详细地址：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:TextBox ID="txtadd_address" runat="server" Width="200px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="25" width="30%" align="right">所在县区：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:TextBox ID="txtadd_counties" runat="server" Width="200px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="25" width="30%" align="right">所在城市：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:TextBox ID="txtadd_city" runat="server" Width="200px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="25" width="30%" align="right">所在省份：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:TextBox ID="txtadd_province" runat="server" Width="200px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="25" width="30%" align="right">地址编号：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:Label ID="lbladd_ID" runat="server"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                            <script src="/js/calendar1.js" type="text/javascript"></script>

                        </td>
                    </tr>
                    <tr>
                        <td class="tdbg" align="center" valign="bottom">
                            <asp:Button ID="btnSave" runat="server" Text="保存"
                                OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                                onmouseout="this.className='inputbutton'"></asp:Button>
                            <asp:Button ID="btnCancle" runat="server" Text="取消"
                                OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                                onmouseout="this.className='inputbutton'"></asp:Button>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footJS" runat="server">
</asp:Content>
