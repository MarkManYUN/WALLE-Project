<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="WalleProject.Web.t_staff.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		sta_userName
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsta_userName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sta_entryDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsta_entryDate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sta_passWord
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsta_passWord" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sta_maritalStatus
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsta_maritalStatus" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sta_IDNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsta_IDNumber" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sta_homeAddress
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsta_homeAddress" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sta_phone
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsta_phone" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sta_name
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsta_name" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sta__pic_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsta__pic_id" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sta_tra_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsta_tra_id" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sta_lastLogindate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtsta_lastLogindate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sta_salary
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsta_salary" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
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
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
