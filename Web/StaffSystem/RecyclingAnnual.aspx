<%@ Page Title="" Language="C#" MasterPageFile="~/StaffSystem/StaffSystem.Master" AutoEventWireup="true" CodeBehind="RecyclingAnnual.aspx.cs" Inherits="WalleProject.Web.StaffSystem.RecyclingAnnual" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">系统效益分析
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="TitleHolder" runat="server">实时效益
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentHolder" runat="server">
     
 
            <canvas id="canvas4" class="myChart" height="416" width="900"></canvas>
     
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="NewHolder" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="JavaScriptHolder" runat="server">
    <!--  PLUGIN -->
    <script type="text/javascript" src="assets/js/chart/chart.js"></script>
    <script type="text/javascript" src="assets/js/chart/barChart.js"></script>
    <script type="text/javascript" src="assets/js/chart/radarChart.js"></script>
    <script type="text/javascript" src="assets/js/chart/polarChart.js"></script>
    <script type="text/javascript" src="assets/js/chart/lineChart.js"></script>


    <script type="text/javascript" src="assets/js/chart/jquery.flot2.js"></script>
    <script type="text/javascript" src="assets/js/chart/jquery.flot.resize.js"></script>


</asp:Content>
