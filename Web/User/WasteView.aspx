﻿<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="WasteView.aspx.cs" Inherits="WalleProject.Web.User.WasteView" %>

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
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">

        <ContentTemplate>


            <div class="templatemo-flex-row flex-content-row templatemo-overflow-hidden">
                <%--  --%>
                <!-- overflow hidden for iPad mini landscape view-->
                <div class="col-1 templatemo-overflow-hidden">
                    <div class="templatemo-content-widget white-bg templatemo-overflow-hidden">
                        <i class="fa fa-times"></i>
                        <div class="templatemo-flex-row flex-content-row" style="height: 100%;">
                            <div class="col-1 col-lg-6 col-md-12"  style="margin-left:10%;">
                                <table>
                                    <tbody>
                                        <asp:ListView ID="ListView1" runat="server" GroupItemCount="3" GroupPlaceholderID="Gholder" ItemPlaceholderID="itemholder" DataSourceID="SqlDataSource1">
                                            <EmptyDataTemplate>
                                                <p class="item">SORRY,无相关数据</p>
                                            </EmptyDataTemplate>

                                            <LayoutTemplate>
                                                <nav>
                                                    <ul>

                                                        <li style="max-width: 20%; float: left; margin: 1%;">
                                                            <i class="fa fa-angle-down"></i>
                                                            <asp:Button ID="Button1" runat="server" CssClass=" btn-primary" Text="按种类排序"
                                                                CommandName="sort"
                                                                CommandArgument="was_recoverable" /></li>

                                                        <li style="max-width: 20%; float: left; margin: 1%;"><i class="fa fa-angle-down"></i>
                                                            <asp:Button ID="Button2" runat="server" Text="按资源名排序" CssClass=" btn-primary"
                                                                CommandName="sort"
                                                                CommandArgument="was_name" /></li>

                                                    </ul>
                                                </nav>
                                                <br />
                                                <div style="float: left;">
                                                    <div id="Gholder" runat="server"></div>
                                                </div>

                                            </LayoutTemplate>
                                            <GroupTemplate>
                                                <div runat="server" id="itemholder"></div>

                                            </GroupTemplate>
                                            <GroupSeparatorTemplate>
                                                <hr style="clear: both;" />
                                            </GroupSeparatorTemplate>
                                            <EmptyItemTemplate>
                                                <div class="item">

                                                    
                                                    <img style="max-height:250px;min-height:200px;" src="../images/WasteAdd.jpg" />
                                                </div>
                                            </EmptyItemTemplate>

                                            <ItemTemplate>
                                                <div class="item">
                                                    <spen>
                                   
                                        <img src='<%#Eval("pic_valid")%>' class=" img" runat="server"
                                            data-src="holder.js/64x64"
                                            alt="64x64"
                                            style="max-width: 300px; max-height: 200px; padding: 10px;" title='点击查看商品详情' />
                                  
                                </spen>
                                                    <spen>
                                     <h3> <i  class="fa fa-credit-card" style="margin-right:5%; color:#13895F" aria-hidden="true"></i><%#Eval("was_name")%></h3>  
                                     <h5> <i class=""></i>回收价：<strong style="color:red; font-size:2em;"> <%#  1.2*double.Parse(Eval("was_price").ToString())%>元/<%#Eval("was_valid")%></strong> 
                                          </h5>
                             <h6>市场价：<small><del><strong> <%# Eval("was_price")%>元/<%#Eval("was_valid")%></strong></del></small></h6>
                                <a href='WasteShow.aspx?wid=<%#Eval("was_ID")%>' style="" class="btn btn-block  btn-primary" >
                                    <i class="fa fa-shopping-cart fa-6" style="margin-right:5%; color:#ffffff;" aria-hidden="true"></i> 下单 </a>
                                </spen>
                                                </div>
                                            </ItemTemplate>
                                        </asp:ListView>

                                    </tbody>
                                </table>

                                <asp:SqlDataSource ID="SqlDataSource1"
                                    runat="server" ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
                                    ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
                                    SelectCommand="SELECT * from t_waste inner join t_wastecategory on t_wastecategory.wasc_ID =t_waste.was_recoverable
inner join t_picture on t_waste.was_pic_ID=t_picture.pic_ID
inner join t_wastesmailcate on t_wastesmailcate.wastecate_id=t_waste.was_cate_ID
                    "></asp:SqlDataSource>



                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <%--分页控件 --%>

            <div class="templatemo-content col-1 light-gray-bg">

                <div class="templatemo-content-container">
                    <div class="templatemo-content-widget white-bg">
                        <div class="divPager">
                            <asp:DataPager ID="DataPager1" runat="server" PagedControlID="ListView1" PageSize="5">
                                <Fields>
                                    <asp:NextPreviousPagerField ShowFirstPageButton="true" ShowNextPageButton="false" />
                                    <asp:NumericPagerField />
                                    <asp:NextPreviousPagerField ShowLastPageButton="true" ShowPreviousPageButton="false" />
                                </Fields>
                            </asp:DataPager>

                        </div>
                    </div>
                </div>
            </div>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="DataPager1" />
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>
