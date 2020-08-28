<%@ Page Title="" Language="C#" MasterPageFile="~/StaffSystem/StaffSystem.Master" AutoEventWireup="true" CodeBehind="CommdityDataAnalyze.aspx.cs" Inherits="WalleProject.Web.StaffSystem.CommdityDataAnalyze" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="TitleHolder" runat="server">
    商品兑换数据分析
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="navHolder" runat="server">
    商品数据分析
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentHolder" runat="server">
  
<canvas id="canvas1" class="myChart" height="416" width="900"></canvas>
     
 <span style="height:40px;width:40px;background-color:#88E1E9;color:#fff;">回收额</span>
 <span style="height:40px;width:40px;background-color:#5CACE1;color:#fff;">兑换额</span>

</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="NewHolder" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="JavaScriptHolder" runat="server">
    <!--  PLUGIN -->
    <script type="text/javascript" src="assets/js/chart/chart.js"></script>
    <script type="text/javascript" src="assets/js/chart/barChart.js"></script>
    <script type="text/javascript" src="assets/js/chart/radarChart.js"></script>
    <script type="text/javascript" src="assets/js/chart/polarChart.js"></script>
    <script type="text/javascript" src="assets/js/chart/lineChart.js"></script>


    <script type="text/javascript" src="assets/js/chart/jquery.flot2.js"></script>
    <script type="text/javascript" src="assets/js/chart/jquery.flot.resize.js"></script>

</asp:Content>
