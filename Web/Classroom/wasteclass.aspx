<%@ Page Title="" Language="C#" MasterPageFile="~/BeforeMater.Master" AutoEventWireup="true" CodeBehind="wasteclass.aspx.cs" Inherits="WalleProject.Web.Classroom.wasteclass" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .map-cat p {
            border-bottom: 1px solid #e5e5e5;
            line-height: 28px;
            margin-bottom: 15px;
        }

        .map-cat {
            color: #fff;
        }

        p {
            display: block;
            -webkit-margin-before: 1em;
            -webkit-margin-after: 1em;
            -webkit-margin-start: 0px;
            -webkit-margin-end: 0px;
        }

        body, button, input, select, textarea {
            color: rgb(102, 102, 102);
            font: 12px/250% 微软雅黑;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BeforeTopPlaceHolder" runat="server">
    <h1 style="color: aliceblue;">废品分类库</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="BeforeContentPlaceHolder" runat="server">
    <!--================Our About Area =================-->
    <section class="">
        <div class="container">
            <div class="col-md-2" style="">
                <div class="submenuHolder fl" runat="server" id="div_submenuHolder">
                </div>
            </div>
            <div class="col-md-10">
                <div class="our_about_left_content">
                    <!--================Our About Area =================-->

                    <!--内容区 start-->

                    <asp:ListView ID="ListView1" runat="server" ItemPlaceholderID="ParentMunu" DataSourceID="SqlDataSource1">
                        <LayoutTemplate>
                            <div runat="server" id="ParentMunu"></div>
                        </LayoutTemplate>
                        <ItemSeparatorTemplate>
                            <hr />
                        </ItemSeparatorTemplate>
                        <ItemTemplate>

                            <h2>
                                <a href='https://baike.baidu.com/item/<%#Eval("wastecc_name")%>'
                                    style="border-left: 0px solid!important;" class="title-menu-left">
                                    <%#Eval("wastecc_name") %>
                                    <i data-toggle="tooltip" class="glyphicon glyphicon-tree-deciduous"></i>
                                </a>
                            </h2>
                            <div style="">
                                <asp:ListView ID="ListView2" DataSourceID="childDataSource" runat="server" ItemPlaceholderID="ChildMenu">
                                    <LayoutTemplate>
                                        <span runat="server" id="ChildMenu"></span>
                                    </LayoutTemplate>
                                    <ItemTemplate>
                                        <h3 style="margin-left: 5%;">
                                            <a class="glyphicon glyphicon-tree-conifer" href='https://baike.baidu.com/item/<%#Eval("wasc_name")%>' title='<%#Eval("wasc_name") %>'><%#Eval("wasc_name") %></a>
                                        </h3>
                                        <div style="margin-left: 10%;" class="glyphicon glyphicon-send">
                                            <asp:ListView ID="ListView2" DataSourceID="childDataSource" runat="server" ItemPlaceholderID="ChildMenu">
                                                <LayoutTemplate>
                                                    <span runat="server" id="ChildMenu"></span>
                                                </LayoutTemplate>
                                                <ItemTemplate>
                                                    <small style="font-size: 1.5em;">
                                                        <a class=' ' style="color: #052C7D;" href='https://baike.baidu.com/item/<%#Eval("wastecate_name")%>' title='<%#Eval("wastecate_name") %>'>
                                                            <small><%#Eval("wastecate_name") %></small>
                                                        </a>
                                                    </small>
                                                </ItemTemplate>
                                            </asp:ListView>

                                            <asp:SqlDataSource runat="server" ID="childDataSource"
                                                ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
                                                ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
                                                SelectCommand='<%#Eval("wasc_ID", "select wastecate_name,wastecate_id,wastecate_cid from t_wastesmailcate where  wastecate_cid={0}") %>'></asp:SqlDataSource>
                                        </div>
                                    </ItemTemplate>
                                </asp:ListView>
                                <asp:SqlDataSource runat="server" ID="childDataSource"
                                    ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
                                    ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
                                    SelectCommand='<%#Eval("wastecc_ID", "select wasc_name,wasc_ID,wasc_c_id from t_wastecategory where wasc_c_id={0}")%>'></asp:SqlDataSource>
                            </div>

                        </ItemTemplate>
                    </asp:ListView>

                    <asp:SqlDataSource ID="SqlDataSource1" runat="server"
                        ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
                        ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
                        SelectCommand="select wastecc_name,wastecc_ID from t_wastesupercate "></asp:SqlDataSource>

                    <!--内容区 end-->
                    <!-------footer-------->



                    <!--================end About Area =================-->
                </div>
            </div>
        </div>
    </section>
</asp:Content>
