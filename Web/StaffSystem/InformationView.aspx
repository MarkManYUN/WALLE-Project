<%@ Page Title="" Language="C#" MasterPageFile="~/StaffSystem/StaffSystem.Master" AutoEventWireup="true" CodeBehind="InformationView.aspx.cs" Inherits="WalleProject.Web.StaffSystem.InformationView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="TitleHolder" runat="server">
    查看个人信息
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="navHolder">个人信息页</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentHolder" runat="server">





    <div class="col-sm-12">
        <div class="col-xs-12 col-sm-4 text-center">

            <ul class="list-group">
                <li class="list-group-item text-left">
                    <span class="entypo-user"></span>&nbsp;&nbsp;我的资料</li>
                <li class="list-group-item text-center">
                    <img src="#" runat="server" alt="" id="imgPhoto" class="img-circle img-responsive img-profile" />
                </li>
                <li class="list-group-item text-center">
                    <span class="pull-left">
                        <strong>服务等级</strong>
                    </span>


                    <div class="ratings">

                        <a href="#">
                            <span class="fa fa-star"></span>
                        </a>
                        <a href="#">
                            <span class="fa fa-star"></span>
                        </a>
                        <a href="#">
                            <span class="fa fa-star"></span>
                        </a>
                        <a href="#">
                            <span class="fa fa-star"></span>
                        </a>
                        <a href="#">
                            <span class="fa fa-star-o"></span>
                        </a>

                    </div>


                </li>

                <li class="list-group-item text-right">
                    <span class="pull-left">
                        <strong>员工ID：</strong>
                    </span>WL2018042800<asp:Label ID="lblsta_id" runat="server"></asp:Label></li>
                <li class="list-group-item text-right">
                    <span class="pull-left">
                        <strong>用户名：</strong>
                    </span>
                    <asp:Label ID="lblsta_userName" runat="server"></asp:Label>
                </li>
                <li class="list-group-item text-right">
                    <span class="pull-left">
                        <strong>注册时间：</strong>
                    </span>
                    <asp:Label ID="lblsta_entryDate" runat="server"></asp:Label></li>
            </ul>

        </div>
        <div class="col-xs-12 col-sm-8 profile-name">
            <h2>
                <asp:Label ID="lblsta_name" runat="server"></asp:Label>
                <span class="pull-right social-profile">
                    <i class="entypo-facebook-circled"></i><i class="entypo-twitter-circled"></i><i class="entypo-linkedin-circled"></i><i class="entypo-github-circled"></i><i class="entypo-gplus-circled"></i>
                </span>
            </h2>
            <hr />

            <dl class="dl-horizontal-profile">
                <dt>婚姻状况：<asp:Label ID="lblsta_maritalStatus" runat="server"></asp:Label></dt>
                 
                <dt>身份证号：  <asp:Label ID="lblsta_IDNumber" runat="server"></asp:Label></dt>
                
                <dt>家庭住址： <asp:Label ID="lblsta_homeAddress" runat="server"></asp:Label></dt>
               

                <dt>电话号码：  <asp:Label ID="lblsta_phone" runat="server"></asp:Label></dt>
               

                <dt>最后一次登陆时间：  <asp:Label ID="lblsta_lastLogindate" runat="server"></asp:Label></dt>
                
            
                <dt>当前工资：  <asp:Label ID="lblsta_salary" runat="server"></asp:Label></dt>
               

            </dl>


            <hr />

        </div>

    </div>
    <div class="content-wrap">
        <div class="row">
            <div class="col-sm-12">
                <div class="well profile">
                     <a href="InformationEdit.aspx?id=5" class=" btn btn-info">修改我的信息</a>
    <a href="InformationPhoto.aspx?id=5" class=" btn btn-info">修改头像</a>
    <a href="EditPassWord.aspx?id=5" class="btn btn-info">修改密码</a>
                </div>
            </div>
            <!-- PROFILE -->

        </div>
    </div>



</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="NewHolder" runat="server">
   
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="JavaScriptHolder" runat="server">
</asp:Content>
