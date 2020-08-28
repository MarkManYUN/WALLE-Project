<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="PhotoView.aspx.cs" Inherits="WalleProject.Web.User.PhotoView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
