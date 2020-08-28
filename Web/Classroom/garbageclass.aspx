<%@ Page Title="" Language="C#" MasterPageFile="~/BeforeMater.Master" AutoEventWireup="true" CodeBehind="garbageclass.aspx.cs" Inherits="WalleProject.Web.Classroom.garbageclass" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BeforeTopPlaceHolder" runat="server">
    <h1 style="color: aliceblue;">垃圾分类</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="BeforeContentPlaceHolder" runat="server">
    <!--================Our About Area =================-->
    <section class="">
        <div class="container">
            <div class="col-md-3" style="">
                <div class="submenuHolder fl" runat="server" id="div_submenuHolder">
                </div>
            </div>
            <div class="col-md-7">
                <div class="our_about_left_content">
                    <!--================Our About Area =================-->
                    <img src="../img/class1.png" />
                    <img src="../img/class8.png" />
                    <img src="../img/class9.png" />
                    <img src="../img/class10.png" />
                    <img src="../img/class11.png" />
                    <img src="../img/class12.png" />
                    <!--================end About Area =================-->
                </div>
            </div>
        </div>
    </section>
</asp:Content>
