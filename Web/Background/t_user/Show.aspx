<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WalleProject.Web.t_user.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		u_address
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblu_address" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		u_lastLoginDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblu_lastLoginDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		u_creaditsLogID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblu_creaditsLogID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		u_registrationDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblu_registrationDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		auto_increment
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblu_ID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		u_nickName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblu_nickName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		u_category
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblu_category" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		u_birthDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblu_birthDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		u_state
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblu_state" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		u_passWord
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblu_passWord" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		u_integral
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblu_integral" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		u_creditGrade
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblu_creditGrade" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		u_name
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblu_name" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		u_pic_ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblu_pic_ID" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




