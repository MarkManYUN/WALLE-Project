<%@ Page Title="" Language="C#" MasterPageFile="~/StaffSystem/StaffSystem.Master"  AutoEventWireup="true" CodeBehind="CommodityPhotoAdd.aspx.cs" Inherits="WalleProject.Web.StaffSystem.CommodityPhotoAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="TitleHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="navHolder" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentHolder" runat="server">
    <div class="row">
        <div class=" col-lg-6">
            <p>
                商品名：
        <asp:TextBox ID="was_name" CssClass="form-control" runat="server"></asp:TextBox>
            </p>

            <p>商品价格：<asp:TextBox ID="was_price" CssClass="form-control" runat="server"></asp:TextBox></p>

            <p>商品数量：<asp:TextBox ID="was_number" CssClass="form-control" runat="server"></asp:TextBox></p>
            <p>
                生产日期： 
        <asp:Calendar ID="Calendar1" CssClass=" " runat="server"></asp:Calendar>
            </p>
            <asp:DropDownList ID="ddl_super" CssClass="form-control" runat="server" AutoPostBack="True" DataSourceID="class1" DataTextField="comc_name" DataValueField="comc_ID"></asp:DropDownList>

            <asp:SqlDataSource ID="class1" runat="server" ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
                ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>" SelectCommand="SELECT * FROM  t_commoditycategory "></asp:SqlDataSource>


            <p>单位：<asp:TextBox ID="was_valid" CssClass="form-control" runat="server" /></p>
            <p>货架号：<asp:TextBox ID="com_strageID" CssClass="form-control" runat="server" /></p>
            <p>报警值：<asp:TextBox ID="com_alertNumber" CssClass="form-control" runat="server" /></p>

            <asp:Button ID="btn_Save" runat="server" CssClass="btn btn-info form-control" Text="保存" OnClick="btn_Save_Click" />
            <asp:Button ID="btn_Cancel" runat="server" CssClass="btn btn-default form-control" Text="取消" OnClick="btn_Cancel_Click" />
        </div>
        <div class=" col-lg-6">
            <asp:Image ID="Image1" runat="server" CssClass=" img-rounded" Width="400px" />
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="NewHolder" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="JavaScriptHolder" runat="server">
</asp:Content>
