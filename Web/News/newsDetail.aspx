<%@ Page Title="" Language="C#" MasterPageFile="~/BeforeMater.Master" AutoEventWireup="true" CodeBehind="newsDetail.aspx.cs" Inherits="WalleProject.Web.News.newsDetail" %>

<%@ Register Src="~/MyControl/NewsReader.ascx" TagPrefix="uc1"  TagName="newsReader" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BeforeTopPlaceHolder" runat="server">
    <h1 style="color: aliceblue;">新闻阅读</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="BeforeContentPlaceHolder" runat="server">
    <!--================Our About Area =================-->
    <section class="">
        <div class="container">
            <div class="col-md-4" style="">
                <div class="submenuHolder fl" runat="server" id="div_submenuHolder">
                </div>
            </div>
            <div class="col-md-7">
                <div class="our_about_left_content">
                    <!--================Our About Area =================-->

                    <uc1:newsReader runat="server"  newsID="1" id="NewsReader" />



                    <!--================end About Area =================-->
                </div>
            </div>
        </div>
    </section>
</asp:Content>
