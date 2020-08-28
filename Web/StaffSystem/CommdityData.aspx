<%@ Page Title="" Language="C#" MasterPageFile="~/StaffSystem/StaffSystem.Master" AutoEventWireup="true" CodeBehind="CommdityData.aspx.cs" Inherits="WalleProject.Web.StaffSystem.CommdityData" %>

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
<asp:Content runat="server" ContentPlaceHolderID="navHolder">商品信息</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="TitleHolder" runat="server">
    商品信息

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentHolder" runat="server">

    <div class="row">
        <div class="col-lg-4">
            <img runat="server" src="#" id="lblcom_pic_ID" style="max-width: 80%;" />
        </div>
        <div class="col-lg-8">
            <table cellspacing="0" cellpadding="0" width="100%" border="0">

                <tr>
                    <td height="25" width="30%" align="right">商品名：</td>
                    <td height="25" width="*" align="left">
                        <h2 class="text-uppercase margin-bottom-10">
                            <asp:Label ID="lblcom_name" runat="server"></asp:Label>
                        </h2>
                    </td>
                </tr>
                <tr>
                    <td height="25" width="30%" align="right">商品编号：</td>
                    <td height="25" width="*" align="left">
                        <p class="margin-bottom-0">
                            WL2018042500<asp:Label ID="lblcom_id" runat="server"> </asp:Label>
                        </p>

                    </td>
                </tr>
                <tr>
                    <td height="25" width="30%" align="right">生产日期：</td>
                    <td height="25" width="*" align="left">
                        <asp:Label ID="lblcom_productDate" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td height="25" width="30%" align="right">商品库存：</td>
                    <td height="25" width="*" align="left">
                        <asp:Label CssClass="lblcom_number" ID="lblcom_number" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td height="25" width="30%" align="right">仓库ID：</td>
                    <td height="25" width="*" align="left">
                        <asp:Label ID="lblcom_strageID" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td height="25" width="30%" align="right">类别：</td>
                    <td height="25" width="*" align="left">
                        <asp:Label ID="lblcom_comc_ID" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td height="25" width="30%" align="right">上架时间：</td>
                    <td height="25" width="*" align="left">
                        <asp:Label ID="lblcom_date" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td height="25" width="30%" align="right">价格：</td>
                    <td height="25" width="*" align="left">
                        <h3 style="color: aquamarine;"><del>
                            <asp:Label ID="lblcom_pri_ID" runat="server"></asp:Label></del>
                            <small style="color: antiquewhite;">元/ 
                                                                <asp:Label ID="lblcom_valid" runat="server"></asp:Label></small></h3>
                    </td>
                </tr>
                <tr>
                    <td height="25" width="30%" align="right">所需W币：</td>
                    <td height="25" width="*" align="left">
                        <h1 style="color: #ff0000;">
                            <asp:Label ID="lblcom_conversionInt" runat="server"></asp:Label>
                            <small style="color: antiquewhite;">个/ 
                                                                <asp:Label ID="lblcom_valid2" runat="server"></asp:Label>
                            </small></h1>
                    </td>
                </tr>
            </table>

        </div>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="NewHolder" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="JavaScriptHolder" runat="server">
</asp:Content>
