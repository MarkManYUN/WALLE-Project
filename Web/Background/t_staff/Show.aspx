<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WalleProject.Web.t_staff.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		auto_increment
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsta_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sta_userName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsta_userName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sta_entryDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsta_entryDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sta_passWord
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsta_passWord" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sta_maritalStatus
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsta_maritalStatus" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sta_IDNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsta_IDNumber" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sta_homeAddress
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsta_homeAddress" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sta_phone
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsta_phone" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sta_name
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsta_name" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sta__pic_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsta__pic_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sta_tra_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsta_tra_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sta_lastLogindate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsta_lastLogindate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sta_salary
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsta_salary" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




