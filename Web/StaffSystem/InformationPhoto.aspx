<%@ Page Title="" Language="C#" MasterPageFile="~/StaffSystem/StaffSystem.Master" AutoEventWireup="true" CodeBehind="InformationPhoto.aspx.cs" Inherits="WalleProject.Web.StaffSystem.InformationPhoto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <link href="../StaffSystem/assets/css/loader-style.css" rel="stylesheet" />
    <link href="../StaffSystem/assets/js/upload/demos/css/uploader.css" rel="stylesheet" />
    <link href="../StaffSystem/assets/js/upload/demos/css/demo.css" rel="stylesheet" />
    <script src="../StaffSystem/assets/js/upload/demos/js/demo.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="TitleHolder" runat="server">
    修改头像
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="navHolder">头像列表</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentHolder" runat="server">

    <asp:ScriptManagerProxy runat="server"></asp:ScriptManagerProxy>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>


            <asp:ListView ID="ListView1" ItemPlaceholderID="holder" runat="server" DataSourceID="SqlDataSource1">
                <LayoutTemplate>
                    <div id="holder" runat="server"></div>
                </LayoutTemplate>
                <ItemTemplate>
                        <a href='EditPhoto.aspx?pid=<%#Eval("pic_ID")%>' style="">
                            <img src='<%#Eval("pic_valid")%>' class=" img-circle" runat="server"
                                data-src="holder.js/64x64"
                                alt="64x64"
                                style="max-width: 100px; max-height: 100px; padding: 10px;" title='点击修改' />
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
                SelectCommand="select pic_cate_ID,pic_ID,pic_date,pic_name,pic_valid from t_picture where pic_cate_ID=2"></asp:SqlDataSource>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="DataPager1" />
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="NewHolder" runat="server">
     <label runat="server" id="staffid" style="display:none;"></label>
    <!-- D&D Zone-->
    <div id="drag-and-drop-zone" class="uploader">
        <div>拖动 &amp;  图片到此处</div>
        <div class="or">-or-</div>
        <div class="browser">
            <label>
                <span>文件中选择</span>
                <asp:FileUpload ID="fup_com_img" type="file" runat="server" title='点击添加图片' />
            </label>
        </div>
    </div>
    <!-- 提交  -->
    <button class="btn btn-default btn-primary" runat="server" id="btn_submit" onserverclick="btn_submit_ServerClick" type="submit">发布</button>

</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="JavaScriptHolder" runat="server">
</asp:Content>
