<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewsReader.ascx.cs" Inherits="WalleProject.Web.MyControl.NewsReader" %>
<div class="newsDetail ">
    <h2 class="newsTitle" runat="server" id="newsTitle" />
    <p class="newsDateTime" runat="server" id="newsDateTime"/>
    <asp:Image ID="newsImgs" Width="500px" Heigh="400px" CssClass="newsReaderimg" runat="server"  />
    <div class="newsContent cke_show_borders" runat="server" id="newsContent"/>
</div>