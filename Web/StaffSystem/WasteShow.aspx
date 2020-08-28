<%@ Page Title="" Language="C#" MasterPageFile="~/StaffSystem/StaffSystem.Master" AutoEventWireup="true" CodeBehind="WasteShow.aspx.cs" Inherits="WalleProject.Web.StaffSystem.WasteShow" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .item {
            padding: 9px;
            border: 1px solid silver;
            margin: 5px;
            float: left;
        }

            .item img {
                width: 160px;
                height: 120px;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="TitleHolder" runat="server">
    信息栏
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="navHolder" runat="server">详情
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentHolder" runat="server">
     <section class="">
        <div class="container">
            <div class="row">
                <div class="col-md-10">
    <asp:ScriptManagerProxy runat="server"></asp:ScriptManagerProxy>
    <asp:TextBox ID="userid" runat="server" Style="display: none;"></asp:TextBox>
 
     
        <img runat="server" src="#" id="lblwas_pic_ID" class="img-rounded" style="max-width: 80%;float:left;" />
        <div class="templatemo-content-widget blue-bg" style="float:left; "  >
            <table cellspacing="0" cellpadding="0" width="100%" border="0">

                <tr>
                    <td height="25" width="50%" align="right">资源编号：</td>
                    <td height="25" width="*" align="left">WL2018042500
                                            <asp:Label ID="lblwas_ID" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td height="25" width="50%" align="right">资源名：</td>
                    <td height="25" width="*" align="left">
                        <asp:Label ID="lblwas_name" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>

                    <td height="25" width="50%" align="right">市场回收价格：</td>
                    <td height="25" width="*" align="left">
                        <h1 style="color: #ff0000;">
                            <asp:Label ID="lblwas_price" runat="server"></asp:Label>
                            <small style="color: #808080;">元/ 
                                  <asp:Label ID="lblwas_valid" runat="server"></asp:Label>
                            </small></h1>
                    </td>
                </tr>
                <tr>

                    <td height="25" width="50%" align="right">系统回收价格：</td>
                    <td height="25" width="*" align="left">
                        <h3 style="color: aquamarine;"><del>
                            <asp:Label ID="lblwas_price2" runat="server"></asp:Label></del>
                            <small style="color: #808080;">元/ 
                                                                <asp:Label ID="lblwas_valid2" runat="server"></asp:Label></small></h3>
                    </td>
                </tr>
                <tr>
                    <td height="25" width="50%" align="right">二级分类：</td>
                    <td height="25" width="*" align="left">
                        <asp:Label ID="lblwas_recoverable" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td height="25" width="50%" align="right">已收数量：</td>
                    <td height="25" width="*" align="left">
                        <asp:Label ID="lblwas_number" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td height="25" width="50%" align="right">类型ID：</td>
                    <td height="25" width="*" align="left">
                        <asp:Label ID="lblwas_cate_ID" runat="server"></asp:Label>
                    </td>
                </tr>

            </table>
        </div>
    </div></div></div></section>

</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="NewHolder" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="JavaScriptHolder" runat="server">
</asp:Content>
