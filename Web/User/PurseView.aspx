<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="PurseView.aspx.cs" Inherits="WalleProject.Web.User.PurseView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- 我的钱袋 -->
    <div class="templatemo-content col-1 light-gray-bg">

        <div class="templatemo-content-container">
            <div class="templatemo-content-widget white-bg">

                <div class="panel panel-success">
                    <h2>我的剩余积分：<strong style="color:#13895F;"><label runat="server" id="integral"></label></strong></h2>

                    <asp:GridView ID="GridView1" CssClass="table  table-striped table-hover
                        " runat="server" DataSourceID="SqlDataSource1"></asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>" 
                        ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>" 
                        SelectCommand="SELECT   int_ID as  编号,int_date as 活动日期,   int_integral as  活动积分 ,
                         int_way as 操作,  int_u_ID as 用户编号 FROM  t_integratingrecord "></asp:SqlDataSource>
                </div>


            </div>
        </div>
    </div>
</asp:Content>
