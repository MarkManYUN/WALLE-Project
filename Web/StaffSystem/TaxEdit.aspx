<%@ Page Title="" Language="C#" MasterPageFile="~/StaffSystem/StaffSystem.Master" AutoEventWireup="true" CodeBehind="TaxEdit.aspx.cs" Inherits="WalleProject.Web.StaffSystem.TaxEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="TitleHolder" runat="server">工资管理
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="navHolder" runat="server">修改税率
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentHolder" runat="server">
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">

                <table cellspacing="0" cellpadding="0" width="100%" border="0">
                   
                    <tr>
                        <td height="25" width="30%" align="right">养老保险：</td>
                        <td height="25" width="*" align="left">
                            <asp:TextBox ID="txtStr_aged" runat="server" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    
                    <tr>
                        <td height="25" width="30%" align="right">医疗保险：</td>
                        <td height="25" width="*" align="left">
                            <asp:TextBox ID="txtStr_medical" runat="server" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td height="25" width="30%" align="right">失业保险：</td>
                        <td height="25" width="*" align="left">
                            <asp:TextBox ID="txtStr_unemployment" runat="server" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td height="25" width="30%" align="right">住房公积金：</td>
                        <td height="25" width="*" align="left">
                            <asp:TextBox ID="txtStr_housing" runat="server" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td height="25" width="30%" align="right">补充住房公积金：</td>
                        <td height="25" width="*" align="left">
                            <asp:TextBox ID="txtSta_supplement" runat="server" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td height="25" width="30%" align="right">个人所得税：</td>
                        <td height="25" width="*" align="left">
                            <asp:TextBox ID="txtSta_individualTax" runat="server" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td height="25" width="30%" align="right">个人所得税起征点：</td>
                        <td height="25" width="*" align="left">
                            <asp:TextBox ID="txtSta_threshold" runat="server" Width="200px"></asp:TextBox>
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
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="NewHolder" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="JavaScriptHolder" runat="server">
</asp:Content>
