﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="WalleProject.Web.t_staff.Modify" Title="修改页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		用户ID：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblsta_id" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		用户名：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEdit_sta_userName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		注册时间：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEdit_sta_entryDate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		用户密码：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEdit_sta_passWord" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		婚姻状况：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEdit_sta_maritalStatus" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		身份证号：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEdit_sta_IDNumber" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		家庭住址：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEdit_sta_homeAddress" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		电话号码：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEdit_sta_phone" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		真实姓名：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEdit_sta_name" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		头像ID：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEdit_sta__pic_id" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		类别ID：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEdit_sta_tra_id" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		最后一次登录：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtEdit_sta_lastLogindate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		当前工资：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEdit_sta_salary" runat="server" Width="200px"></asp:TextBox>
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
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

