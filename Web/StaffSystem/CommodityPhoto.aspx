<%@ Page Title="" Language="C#" MasterPageFile="~/StaffSystem/StaffSystem.Master" AutoEventWireup="true" CodeBehind="CommodityPhoto.aspx.cs" Inherits="WalleProject.Web.StaffSystem.CommodityPhoto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../StaffSystem/assets/css/loader-style.css" rel="stylesheet" />
    <link href="../StaffSystem/assets/js/upload/demos/css/uploader.css" rel="stylesheet" />
    <link href="../StaffSystem/assets/js/upload/demos/css/demo.css" rel="stylesheet" />
    <script src="../StaffSystem/assets/js/upload/demos/js/demo.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="TitleHolder" runat="server">
    商品图片库
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="navHolder" runat="server">
    商品图片列表
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentHolder" runat="server">
    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:ListView ID="ListView1" ItemPlaceholderID="holder" runat="server" DataSourceID="SqlDataSource1">
                <LayoutTemplate>
                    <div id="holder" runat="server"></div>
                </LayoutTemplate>
                <ItemTemplate>
                    <a href='CommodityPhotoAdd.aspx?cid=<%#Eval("pic_ID")%>' style="">
                        <img src='<%#Eval("pic_valid")%>' class=" img" runat="server"
                            data-src="holder.js/64x64"
                            alt="64x64"
                            style="max-width: 200px; max-height: 200px; padding: 10px;" title='点击添加' />
                    </a>
                </ItemTemplate>
            </asp:ListView>
            <%--分页控件 --%>
            <div class="divPager">
                <asp:DataPager ID="DataPager1" runat="server" PagedControlID="ListView1" PageSize="30">
                    <Fields>
                        <asp:NextPreviousPagerField ShowFirstPageButton="true" ShowNextPageButton="false" />
                        <asp:NumericPagerField />
                        <asp:NextPreviousPagerField ShowLastPageButton="true" ShowPreviousPageButton="false" />
                    </Fields>
                </asp:DataPager>
            </div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
                ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
                SelectCommand="select pic_cate_ID,pic_ID,pic_date,pic_name,pic_valid from t_picture where pic_cate_ID=3"></asp:SqlDataSource>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="DataPager1" />
        </Triggers>
    </asp:UpdatePanel>

</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="NewHolder" runat="server">
   
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="JavaScriptHolder" runat="server">
</asp:Content>
