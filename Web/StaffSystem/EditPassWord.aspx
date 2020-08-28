<%@ Page Title="" Language="C#" MasterPageFile="~/StaffSystem/StaffSystem.Master" AutoEventWireup="true" CodeBehind="EditPassWord.aspx.cs" Inherits="WalleProject.Web.StaffSystem.EditPassWord" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="TitleHolder" runat="server">
    修改我的密码
</asp:Content>
<asp:Content ContentPlaceHolderID="navHolder" runat="server">修改密码</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentHolder" runat="server">

    <div class="form-horizontal" role="form">
        <div class="form-group">
            <label class="col-lg-3 control-label">输入原密码：</label>
              <div class="col-lg-8">
                <asp:TextBox class="form-control" type="text"  ID="txt_passWord1" runat="server" Width="200px"></asp:TextBox>
            </div> 
        </div> <div class="form-group">
            <label class="col-lg-3 control-label">输入新密码：</label>
              <div class="col-lg-8">
                <asp:TextBox class="form-control" type="text"  ID="txt_passWord2" runat="server" Width="200px"></asp:TextBox>
            </div> 
        </div> <div class="form-group">
            <label class="col-lg-3 control-label">重新输入新密码：</label>
              <div class="col-lg-8">
                <asp:TextBox class="form-control" type="text"  ID="txt_passWord3" runat="server" Width="200px"></asp:TextBox>
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
