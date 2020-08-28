<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WalleProject.Web.t_address.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		add_u_ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbladd_u_ID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		add_contactName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbladd_contactName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		add_contactPhone
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbladd_contactPhone" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		add_date
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbladd_date" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		add_postcode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbladd_postcode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		add_default
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbladd_default" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		add_address
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbladd_address" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		add_counties
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbladd_counties" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		add_city
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbladd_city" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		add_province
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbladd_province" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		auto_increment
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbladd_ID" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




