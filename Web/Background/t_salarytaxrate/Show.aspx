<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WalleProject.Web.t_salarytaxrate.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		Sta_threshold
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSta_threshold" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Str_date
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStr_date" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Str_aged
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStr_aged" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		auto_increment
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStr_ID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Str_medical
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStr_medical" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Str_unemployment
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStr_unemployment" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Str_housing
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStr_housing" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Sta_supplement
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSta_supplement" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Sta_individualTax
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSta_individualTax" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




