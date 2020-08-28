<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="OrderHistory.aspx.cs" Inherits="WalleProject.Web.User.OrderHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- 历史记录 -->
    <asp:TextBox ID="userid" runat="server" Style="display: none;"></asp:TextBox>
    <div class="templatemo-content col-1 light-gray-bg">

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
                                        <h2><%#Eval("com_name")  %> <small><mark>[<%#Eval("comc_name") %>]</mark>  </small></h2>
                                    </div>
                                    <div class="row">
                                        <blockquote class="blockquote-reverse">
                                            <span class="fr text-right "><%#Eval("tra_transactionDate","{0}") %></span>
                                            <p class="text-left text-success">W币：<%#Eval("tra_transactionAmount") %></p>
                                            <p class="text-left text-success">状态： <mark><%#Eval("tra_accomplish") %></mark> </p>
                                            <p class="text-left text-success">
                                                地址：<%#Eval("add_province") %> <%#Eval("add_city") %>
                                                <%#Eval("add_counties") %> <%#Eval("add_address")  %>
                                            </p>
                                            <p class="text-left text-success">
                                                联系方式：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                   <%#Eval("add_contactName") %>&nbsp;&nbsp;&nbsp;  <%#Eval("add_contactPhone") %>
                                            </p>
                                            <a href='OrderHistory.aspx?oid=<%#Eval("tra_ID") %>' style="color: #ff0000">取消订单</a>
                                            <a href='Command.aspx?cid=<%#Eval("tra_ID") %>' style="color: #ff0000">评论订单</a>
                                        </blockquote>

                                    </div>

                                </div>
                            </a>

                        </div>
                    </ItemTemplate>
                    <EmptyItemTemplate>
                        <h3>你还没有下单，试试下单吧<small><a href="WasteView.aspx?id=5"></a></small></h3>
                    </EmptyItemTemplate>
                    <EmptyDataTemplate>
                        <h3>你还没有下单，试试下单吧! <a style="color: #0094ff;" href="WasteView.aspx?id=5">开始下单</a> </h3>

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
inner JOIN t_commodity on t_commodity.com_ID=t_tradingrecord.sta_comwas_id
inner join t_picture on t_commodity.com_pic_ID=t_picture.pic_ID
inner join t_address on t_address.add_ID=t_tradingrecord.tra_addressID
inner join t_user on t_user.u_ID =t_tradingrecord.tra_U_ID
left join t_staff on t_staff.sta_id=t_tradingrecord.tra_staff_id 
inner join t_commoditycategory on t_commoditycategory.comc_ID=t_commodity.com_comc_ID
  WHERE   tra_U_ID  = ?   and  tra_type='商品' ORDER BY  tra_transactionDate  DESC">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="userid" Name="tra_U_ID" PropertyName="Text" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>


            </div>

        </div>
    </div>
</asp:Content>
