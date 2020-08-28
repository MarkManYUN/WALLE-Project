<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WalleProject.Web.t_tradingrecord.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		tra_U_ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltra_U_ID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tra_transactionAmount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltra_transactionAmount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tra_transactionDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltra_transactionDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tra_accomplish
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltra_accomplish" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tra_staff_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltra_staff_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sta_comwas_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsta_comwas_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tra_number
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltra_number" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		auto_increment
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltra_ID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tra_addressID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltra_addressID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tra_type
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltra_type" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tra_vaild
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltra_vaild" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tra_sort
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltra_sort" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




