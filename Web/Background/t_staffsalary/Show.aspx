<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WalleProject.Web.t_staffsalary.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		Sal_absenteeismDay
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSal_absenteeismDay" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		auto_increment
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsal_ID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sal_bonusM
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsal_bonusM" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sal_describe
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsal_describe" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sal_deductM
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsal_deductM" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sal_totalM
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsal_totalM" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sal_incrementM
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsal_incrementM" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sal_month
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsal_month" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sal_year
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsal_year" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sal_date
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsal_date" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sal_sta_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsal_sta_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Sal_leaveDay
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSal_leaveDay" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




