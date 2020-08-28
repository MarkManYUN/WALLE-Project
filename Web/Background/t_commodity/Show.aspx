<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WalleProject.Web.t_commodity.Show" Title="显示页" %>
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
		<asp:Label id="lblcom_ID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		com_name
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcom_name" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		com_productDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcom_productDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		com_number
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcom_number" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		com_strageID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcom_strageID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		com_alertNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcom_alertNumber" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		com_pic_ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcom_pic_ID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		com_date
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcom_date" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		com_pri_ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcom_pri_ID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		com_conversionInt
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcom_conversionInt" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		com_comc_ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcom_comc_ID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		com_valid
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcom_valid" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




