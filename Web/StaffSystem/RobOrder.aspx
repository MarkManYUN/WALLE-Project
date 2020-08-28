<%@ Page Title="" Language="C#" MasterPageFile="~/StaffSystem/StaffSystem.Master" AutoEventWireup="true" CodeBehind="RobOrder.aspx.cs" Inherits="WalleProject.Web.StaffSystem.RobOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="TitleHolder" runat="server">
    所有订单
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="navHolder" runat="server">
    我要抢单
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentHolder" runat="server">
    <asp:TextBox ID="userid" runat="server" Style="display: none;"></asp:TextBox>
    <div class="templatemo-content col-1 light-gray-bg" style="margin: 3%;">

        <div class="templatemo-content-container">
            <div class="templatemo-content-widget white-bg">


                <asp:ListView ID="ListView1" runat="server" ItemPlaceholderID="holder" DataSourceID="SqlDataSource1">
                    <LayoutTemplate>
                        <div runat="server" id="holder"></div>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <div class="row item  well well-lg" style="padding: 10px;">
                            <a href="WasteShow.aspx?wid=<%#Eval("sta_comwas_id") %>" class="">
                                <div class="col-md-2">
                                    <asp:Image ID="Image2" Height="80px" Width="100px" runat="server" CssClass="fl img-circle" ImageUrl='<%#Eval("pic_valid") %>' />
                                </div>
                                <div class="col-md-10">
                                    <div class="row">
                                        <p>订单编号：WL2018042800<%#Eval("tra_ID")  %></p>
                                        <h2><%#Eval("was_name")  %> <small><mark>[<%#Eval("wasc_name") %>]</mark><mark>[<%#Eval("wastecate_name") %>]</mark><p class="fr text-right "><%#Eval("tra_transactionDate","{0}") %></p>
                                        </small></h2>
                                    </div>
                                    <div class="row">
                                        <blockquote class="blockquote-reverse">

                                            <p class="text-left text-success">金额：<%#Eval("tra_transactionAmount") %></p>
                                            <p class="text-left text-success">状态：<%#Eval("tra_accomplish") %></p>
                                            <p class="text-left text-success">地址：<%#Eval("add_province") %><%#Eval("add_city") %><%#Eval("add_counties") %><%#Eval("add_address")  %></p>
                                            <p class="text-left text-success">
                                                联系方式：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                    <%#Eval("add_contactName") %>&nbsp;&nbsp;&nbsp;  <%#Eval("add_contactPhone") %>
                                            </p>
                                            <a href='RobOrder.aspx?rid= <%#Eval("tra_ID") %>' style="color: #ff0000">我要接单</a>


                                        </blockquote>

                                    </div>

                                </div>
                            </a>

                        </div>
                    </ItemTemplate>
                    <EmptyItemTemplate>
                        <h3>暂时没有订单<small><a href="WasteView.aspx?id=5"></a></small></h3>
                    </EmptyItemTemplate>
                    <EmptyDataTemplate>
                        <h3>暂时没有订单   </h3>

                    </EmptyDataTemplate>
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
                    SelectCommand="SELECT * FROM  t_tradingrecord  
inner JOIN t_waste on t_waste.was_ID=t_tradingrecord.sta_comwas_id
inner join t_picture on t_waste.was_pic_ID=t_picture.pic_ID
inner join t_address on t_address.add_ID=t_tradingrecord.tra_addressID
inner join t_user on t_user.u_ID =t_tradingrecord.tra_U_ID
left join t_staff on t_staff.sta_id=t_tradingrecord.tra_staff_id
inner join t_wastesmailcate on t_waste.was_cate_ID=t_wastesmailcate.wastecate_id
inner join t_wastecategory on t_waste.was_recoverable=t_wastecategory.wasc_ID
  WHERE tra_accomplish='发布'  and tra_type='废品'    ORDER BY  tra_transactionDate  DESC">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="userid" Name="tra_U_ID" PropertyName="Text" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>


            </div>

        </div>
    </div>

</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="NewHolder" runat="server">
    <asp:TextBox ID="userid2" runat="server" Style="display: none;"></asp:TextBox>

    <div class="content-wrap">
        <div class="row">
            <div class="col-lg-12">
                <div id="RealTimeClose" class="nest">
                    <div class="templatemo-content col-1 light-gray-bg" style="margin: 3%;">

                        <div class="templatemo-content-container">
                            <div class="templatemo-content-widget white-bg">
                                <asp:ListView ID="ListView2" runat="server"  ItemPlaceholderID="holder" DataSourceID="SqlDataSource2">
                                    <LayoutTemplate>
                                        <div runat="server" id="holder"></div>
                                    </LayoutTemplate>
                                    <ItemTemplate>
                                        <div class="row item  well well-lg" style="padding: 10px;">
                                            <a href="CommdityData.aspx?cid=<%#Eval("sta_comwas_id") %>" class="">
                                                <div class="col-md-2">
                                                    <asp:Image ID="Image2" Height="80px" Width="100px" runat="server" CssClass="fl img-circle" ImageUrl='<%#Eval("pic_valid") %>' />
                                                </div>
                                                <div class="col-md-10">
                                                    <div class="row">
                                                        <p>订单编号：WL2018042800<%#Eval("tra_ID")  %></p>
                                                        <h2><%#Eval("com_name")  %> <small><mark>[生产日期：<%#Eval("com_productDate") %>]</mark><mark>[货架号：<%#Eval("com_strageID") %>]</mark><p class="fr text-right "><%#Eval("tra_transactionDate","{0}") %></p>
                                                        </small></h2>
                                                        <h4>价格：<%#Eval("com_pri_ID")  %><small><mark>[元/<%#Eval("com_valid") %>] </mark><mark>[<%#Eval("com_strageID") %>]</mark><p class="fr text-right "><%#Eval("com_number") %></p>
                                                        </small></h4>
                                                    </div>
                                                    <div class="row">
                                                        <blockquote class="blockquote-reverse">

                                                            <p class="text-left text-success">金额：<%#Eval("tra_transactionAmount") %></p>
                                                            <p class="text-left text-success">状态：<%#Eval("tra_accomplish") %></p>
                                                            <p class="text-left text-success">地址：<%#Eval("add_province") %><%#Eval("add_city") %><%#Eval("add_counties") %><%#Eval("add_address")  %></p>
                                                            <p class="text-left text-success">
                                                                联系方式：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                    <%#Eval("add_contactName") %>&nbsp;&nbsp;&nbsp;  <%#Eval("add_contactPhone") %>
                                                            </p>
                                                            <a href='RobOrder.aspx?rid= <%#Eval("tra_ID") %>' style="color: #ff0000">我要接单</a>


                                                        </blockquote>

                                                    </div>

                                                </div>
                                            </a>

                                        </div>
                                    </ItemTemplate>
                                    <EmptyItemTemplate>
                                        <h3>暂时没有订单<small><a href="WasteView.aspx?id=5"></a></small></h3>
                                    </EmptyItemTemplate>
                                    <EmptyDataTemplate>
                                        <h3>暂时没有订单   </h3>

                                    </EmptyDataTemplate>
                                </asp:ListView>
                                <%--分页控件 --%>
                                <div class="divPager text-center">
                                    <asp:DataPager ID="DataPager2" runat="server" PagedControlID="ListView2" PageSize="5">
                                        <Fields>
                                            <asp:NextPreviousPagerField ShowFirstPageButton="true" ShowNextPageButton="false" />
                                            <asp:NumericPagerField />
                                            <asp:NextPreviousPagerField ShowLastPageButton="true" ShowPreviousPageButton="false" />
                                        </Fields>
                                    </asp:DataPager>
                                </div>
                                <asp:SqlDataSource ID="SqlDataSource2" runat="server"
                                    ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
                                    ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
                                    SelectCommand="SELECT * FROM  t_tradingrecord  
inner JOIN t_commodity on t_commodity.com_ID=t_tradingrecord.sta_comwas_id  
inner join t_picture on t_commodity.com_pic_ID=t_picture.pic_ID
inner join t_address on t_address.add_ID=t_tradingrecord.tra_addressID
inner join t_user on t_user.u_ID =t_tradingrecord.tra_U_ID
left join t_staff on t_staff.sta_id=t_tradingrecord.tra_staff_id
inner join t_commoditycategory on t_commoditycategory.comc_ID=t_commodity.com_comc_ID 
  WHERE tra_accomplish='发布'  and tra_type='商品'  ORDER BY  tra_transactionDate  DESC">
                                    <SelectParameters>
                                        <asp:ControlParameter ControlID="userid2" Name="tra_U_ID" PropertyName="Text" Type="Int32" />
                                    </SelectParameters>
                                </asp:SqlDataSource>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>


</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="JavaScriptHolder" runat="server">
</asp:Content>
