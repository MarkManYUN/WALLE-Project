<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WalleProject.Web.t_systeminterchange.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		si_sort
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsi_sort" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		si_vaild
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsi_vaild" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		si_date
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsi_date" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		si_content
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsi_content" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		si_per_type
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsi_per_type" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		si_pic_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsi_pic_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		si_per_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsi_per_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		si_sl_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsi_sl_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		auto_increment
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsi_id" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




