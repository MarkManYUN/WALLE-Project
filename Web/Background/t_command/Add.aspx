﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="WalleProject.Web.t_command.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		command_user_ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommand_user_ID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		command_staff_ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommand_staff_ID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		command_content
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommand_content" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		command_Delete
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommand_Delete" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		command_Valid
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommand_Valid" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		command_Date
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtcommand_Date" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
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
