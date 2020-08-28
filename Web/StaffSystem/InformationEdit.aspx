<%@ Page Title="" Language="C#" MasterPageFile="~/StaffSystem/StaffSystem.Master" AutoEventWireup="true" CodeBehind="InformationEdit.aspx.cs" Inherits="WalleProject.Web.StaffSystem.InformationEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="TitleHolder" runat="server">
    个人信息修改
</asp:Content>

<asp:Content ID="Content6" ContentPlaceHolderID="navHolder" runat="server">
    信息修改
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentHolder" runat="server">

    <label runat="server" id="staffid" style="display :none"></label>
    <div class="alert alert-info alert-dismissable">
        <a class="panel-close close" data-dismiss="alert">×</a>
        <i class="fa fa-coffee"></i>
        请谨慎修改你的
              <strong>信息</strong>修改成功后请记住他，便于以后重置密码验证。
    </div>
    <h3>我的个人信息</h3>

    <div class="form-horizontal" role="form">
        <div class="form-group">
            <label class="col-lg-3 control-label">用户名：</label>
            <div class="col-lg-8">
                <asp:TextBox class="form-control" type="text" ID="txtsta_userName" runat="server" Width="200px"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <label class="col-lg-3 control-label">婚姻状况：</label>
            <div class="col-lg-8">
                <asp:TextBox ID="txtsta_maritalStatus" class="form-control" type="text" runat="server" Width="200px"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <label class="col-lg-3 control-label">身份证号：</label>
            <div class="col-lg-8">
                <asp:TextBox ID="txtsta_IDNumber" class="form-control" runat="server" Width="200px" type="text"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <label class="col-lg-3 control-label">家庭住址：</label>
            <div class="col-lg-8">
                <asp:TextBox ID="txtsta_homeAddress" class="form-control" runat="server" Width="200px" type="text"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <label class="col-lg-3 control-label">手机号码：</label>
            <div class="col-lg-8">
                <asp:TextBox ID="txtsta_phone" class="form-control" runat="server" Width="200px" type="text"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <label class="col-lg-3 control-label">用户姓名：</label>
            <div class="col-lg-8">
                <asp:TextBox ID="txtsta_name" class="form-control" type="text" runat="server" Width="200px"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <label class="col-md-3 control-label"></label>
            <div class="col-md-8">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton btn btn-primary"></asp:Button>
                <span></span>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton btn btn-default"></asp:Button>
            </div>
        </div>
    </div>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="NewHolder" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="JavaScriptHolder" runat="server">
</asp:Content>
