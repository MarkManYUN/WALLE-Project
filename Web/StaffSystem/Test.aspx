<%@ Page Title="" Language="C#" MasterPageFile="~/StaffSystem/StaffSystem.Master" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="WalleProject.Web.StaffSystem.Test" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
       
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="TitleHolder" runat="server">
    测试页

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="server">
      <iframe id="iframe_Test" src="../Background/t_address/List.aspx" style="width:100%;height:100%;"></iframe>
</asp:Content>

