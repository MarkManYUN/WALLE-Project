﻿<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="WALLEcommunity.aspx.cs" Inherits="WalleProject.Web.User.WALLEcommunity" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <link href="../StaffSystem/assets/css/loader-style.css" rel="stylesheet" />
    <link href="../StaffSystem/assets/js/upload/demos/css/uploader.css" rel="stylesheet" />
    <link href="../StaffSystem/assets/js/upload/demos/css/demo.css" rel="stylesheet" />
    <script src="../StaffSystem/assets/js/upload/demos/js/demo.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:TextBox ID="userid" runat="server" Style="display: none;"></asp:TextBox>


    <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" ItemPlaceholderID="holder">
        <LayoutTemplate>
            <div runat="server" id="holder"></div>
        </LayoutTemplate>
        <ItemTemplate>
            <div class="templatemo-content-widget white-bg">
                <i class="fa fa-times"></i>
                <div class="media">
                    <div class="media-left">
                        <a href="#">
                            <img class="media-object  img-rounded" style="max-height: 48px;" src='<%#Eval("pic_valid") %>' alt="Sunset">
                        </a>

                    </div>
                    <div class="media-body">
                        <h2 class="media-heading text-uppercase">用户<%#Eval("sl_per_id") %> <small class="navbar-right" style="margin-right: 20%;"><%#Eval("sl_date") %></small></h2>
                        <p class="text-info"><%#Eval("sl_content") %></p>
                        <a class="navbar-right" style="margin-right: 20%;" href='CommunityShow.aspx?cid=<%#Eval("sl_id") %>'>查看详情</a>
                    </div>
                </div>
            </div>

        </ItemTemplate>
    </asp:ListView>
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

    <asp:SqlDataSource ID="SqlDataSource1" runat="server"
        ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
        ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
        SelectCommand="SELECT * FROM  t_systemleave 
                INNER JOIN t_picture on t_picture.pic_ID=t_systemleave.sl_pic_id"></asp:SqlDataSource>

    <div class="content-wrap">

        <div class="templatemo-flex-row flex-content-row templatemo-overflow-hidden">

            <!-- overflow hidden for iPad mini landscape view-->
            <div class="col-1 templatemo-overflow-hidden">
                <div class="templatemo-content-widget white-bg templatemo-overflow-hidden">
                    <i class="fa fa-times"></i>
                    <div class="templatemo-flex-row flex-content-row" style="height: 100%;">
                        <div class="col-1 col-lg-6 col-md-12">
                            <div class="panel-heading border-radius-10">
                                <h2>我要发言</h2>
                            </div>
                            <!-- 留言 -->
                            <div class="row form-group" runat="server">
                                <div class="col-lg-12 form-group">
                                    <label class="control-label" for="inputNote">输入话题</label>
                                    <textarea runat="server" class="form-control" id="inputNote" rows="3"></textarea>
                                </div>
                            </div>
                            <div class="row form-group" runat="server">
                                <label class="control-label" for="inputNote">选择图片</label>
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
                            </div>
                            <!-- 提交  -->
                            <button class="btn btn-default btn-primary" runat="server" id="btn_submit" onserverclick="btn_submit_ServerClick" type="submit">发布</button>
                            <button class="btn btn-default" type="submit" id="btn_canel" runat="server" onserverclick="btn_canel_ServerClick">取消</button>


                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footJS" runat="server">
</asp:Content>
