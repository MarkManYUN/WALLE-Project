<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WalleProject.Web.t_staffmenu.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		StaM_User
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStaM_User" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StaM_Boss
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStaM_Boss" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StaM_Admin
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStaM_Admin" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StaM_Staff
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStaM_Staff" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StaM_Url
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStaM_Url" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StaM_Name
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStaM_Name" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		auto_increment
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStaM_ID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StaM_Delete
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStaM_Delete" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StaM_MenuClass
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStaM_MenuClass" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StaM_Valid
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStaM_Valid" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




