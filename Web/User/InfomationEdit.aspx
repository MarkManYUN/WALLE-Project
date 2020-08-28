<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="InfomationEdit.aspx.cs" Inherits="WalleProject.Web.User.InfomationEdit" %>

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
                                    <td height="25" width="30%" align="right">地址：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:TextBox ID="txtu_address" runat="server" Width="400px"></asp:TextBox>
                                    </td>
                                </tr>
                             
                                <tr>
                                    <td height="25" width="30%" align="right">身份证后四位数字：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:TextBox ID="txtu_creaditsLogID" runat="server" Width="200px"></asp:TextBox>
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
                                        <asp:TextBox ID="txtu_nickName" runat="server" Width="200px"></asp:TextBox>
                                    </td>
                                </tr>
                                
                                <tr>
                                    <td height="25" width="30%" align="right">出生日期：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:TextBox ID="txtu_birthDate" Type="date" runat="server" Width="200px"></asp:TextBox>
                                    </td>
                                </tr>
                              
                           
                                <tr>
                                    <td height="25" width="30%" align="right">用户真实姓名：</td>
                                    <td height="25" width="*" align="left">
                                        <asp:TextBox ID="txtu_name" runat="server" Width="200px"></asp:TextBox>
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
