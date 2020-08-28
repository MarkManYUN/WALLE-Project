<%@ Page Title="" Language="C#" MasterPageFile="~/BeforeMater.Master" AutoEventWireup="true" CodeBehind="newsList.aspx.cs" Inherits="WalleProject.Web.News.newsList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .item:hover {
            background-color:aliceblue;
        }
        /*分页控件*/
        /*注意定义步骤*/
        /*1. 定义外框*/
        div.divPager {
            text-align: center;
            padding: 20px;
            font-size: 12px;
        }

        /*2. 定义不活动按钮: .aspNetDisabled为系统分配的类名*/
        .divPager .aspNetDisabled {
            color: Silver;
            background-color: White;
        }

        /*3. 定义页码项通用格式 包括活动链接,非活动链接 当前页*/
        .divPager a, .divPager span span {
            padding: 3px 10px;
            border: 1px solid #dadada;
            border-radius: 4px;
            color: #666;
            background: #f3f3f3;
        }

            /*4. 活动超链接hover伪类 [非活动超链接没有href属性 (系统设定) ]*/
            /*5. 覆盖当前页样式*/
            .divPager a[href]:hover, .divPager span span {
                background-color: #0094ff;
                color: Black;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BeforeTopPlaceHolder" runat="server">
    <h1 style="color: aliceblue;">新闻中心</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="BeforeContentPlaceHolder" runat="server">
    <!--================Our About Area =================-->
    <section class="">
        <div class="container">
            <div class="col-md-3" style="">
                <div class="submenuHolder fl" runat="server" id="div_submenuHolder">
                </div>
            </div>
            <div class="col-md-9">
                <div class="our_about_left_content">
                    <!--================Our About Area =================-->

                    <asp:ListView ID="ListView1" runat="server" DataSourceID="NEWSlist" ItemPlaceholderID="itemHolder">
                        <LayoutTemplate>
                            <asp:PlaceHolder ID="itemHolder" runat="server"></asp:PlaceHolder>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <div class="row item" style="padding: 10px;">
                                <a href="NewsDetail.aspx?nid=<%#Eval("new_ID") %>" class="">
                                    <div class="col-md-2">
                                        <asp:Image ID="Image2" Height="80px" Width="100px" runat="server" CssClass="fl img-circle" ImageUrl='<%#Eval("pic_valid") %>' />
                                    </div>
                                    <div class="col-md-10">
                                        <div class="row">
                                            <h3><%#Eval("new_title")  %> <small><mark>[<%#Eval("newc_name") %>]</mark></small></h3>
                                        </div>
                                        <div class="row">
                                            <blockquote class="blockquote-reverse">
                                                <span class="fr text-right "><%#Eval("new_creatDate","{0:D}") %></span>
                                                <p class="text-left text-success"><%#Eval("new_valid") %></p>
                                            </blockquote>

                                        </div>

                                    </div>
                                </a>

                            </div>
                            <!--
                            <a href="NewsDetail.aspx?nid=<%#Eval("new_ID") %>" class="newsItem">
                                <div class="">
                                    <asp:Image ID="Image1" Height="80px" Width="100px" runat="server" CssClass="fl img-circle" ImageUrl='<%#Eval("pic_valid") %>' />
                                    <div class="" style="padding-left: 150px; height: auto;">
                                        <h3><%#Eval("new_title")  %> <small><mark>[<%#Eval("newc_name") %>]</mark></small></h3>

                                        <blockquote class="blockquote-reverse">
                                            <span class="fr text-right bg-info"><%#Eval("new_creatDate","{0:D}") %></span>
                                            <p class="text-left text-success"><ins><%#Eval("new_valid") %></ins></p>
                                        </blockquote>
                                
                                    </div>

                                    <div class="clr"></div>
                                </div>
                            </a>
                                -->

                        </ItemTemplate>
                    </asp:ListView>

                    <asp:SqlDataSource ID="NEWSlist" runat="server" ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
                        ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
                        SelectCommand="SELECT t_news.new_creatDate, t_news.new_cate_id, t_news.new_pic_id, t_news.new_content, t_news.new_valid,
                    t_news.new_ID, t_newscategory.newc_name, t_newscategory.newc_ID, t_picture.pic_cate_ID, t_picture.pic_ID,
                    t_picture.pic_date, t_picture.pic_name, t_picture.pic_valid, t_news.new_title 
                    FROM t_news INNER JOIN
                    t_newscategory ON t_news.new_cate_id = t_newscategory.newc_ID INNER JOIN
                    t_picture ON t_picture.pic_ID = t_news.new_pic_id WHERE new_cate_id = ?">
                        <SelectParameters>
                            <asp:QueryStringParameter DefaultValue="2" Name="new_cate_id" QueryStringField="ncid" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <%--分页控件 --%>
                    <div class="divPager text-center">
                        <asp:DataPager ID="DataPager1" runat="server" PagedControlID="ListView1" PageSize="5">
                            <Fields>
                                <asp:NextPreviousPagerField ShowFirstPageButton="true" ShowNextPageButton="false" />
                                <asp:NumericPagerField />
                                <asp:NextPreviousPagerField ShowLastPageButton="true" ShowPreviousPageButton="false" />
                            </Fields>
                        </asp:DataPager>
                    </div>


                    <!--================end About Area =================-->
                </div>
            </div>
        </div>
    </section>
</asp:Content>
