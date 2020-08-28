<%@ Page Title="" Language="C#" MasterPageFile="~/BeforeMater.Master" AutoEventWireup="true" CodeBehind="contactAbout.aspx.cs" Inherits="WalleProject.Web.Contact.contactAbout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BeforeTopPlaceHolder" runat="server">
    <h1 style="color: aliceblue;">网站简介</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="BeforeContentPlaceHolder" runat="server">

    <!--================Our About Area =================-->
    <section class="">
        <div class="container">
            <div class="col-md-4" style="">
                <div class="submenuHolder fl" runat="server" id="div_AboutsubmenuHolder">
                </div>
            </div>
            <div class="col-md-7">
                <div class="our_about_left_content">
                   
                    <h3 class="single_title">基于互联网+的 WALL-E可再生资源回收系统</h3>
                    <p class="lead">
                        在现今背景下，可再生资源的宣传和回收也只是一种形式，多地区分类回收形同虚设。
                        就算市民们分类，到头来也会成为一堆垃圾，通过处理厂的统一分拣回收的效率太低。
                      
                    </p>
                    <p class="lead">
                        在废品回收方面人们生活中的垃圾都是一点一点的不断产生，
                        而可再生资源的分拣堆放需要一定的空间，同时在与回收员取得联系也实属不易。
                    </p>
                    <p class="lead">
                        而通过本回收系统可以通过线上预约、下单、宣传、信息提供、交易并存，
                        线下回收、分拣、物流并存，通过这个平台将人们的生活代入多快好省的步伐中。
                    </p>
                    <img style="width: 95%;" src="../images/201511011616560640.jpg" />
                </div>
            </div>
        </div>
    </section>
</asp:Content>
