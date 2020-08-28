<%@ Page Title="" Language="C#" MasterPageFile="~/StaffSystem/StaffSystem.Master" AutoEventWireup="true" CodeBehind="StaffData.aspx.cs" Inherits="WalleProject.Web.StaffSystem.StaffData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="TitleHolder" runat="server"> 数据分析
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="navHolder">员工数据分析</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentHolder" runat="server">
        

            <div id="placeholder2" style="width: 100%; height: 300px;"></div>
         
     
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="NewHolder" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="JavaScriptHolder" runat="server"> 
          <!--  PLUGIN -->
    <script type="text/javascript" src="assets/js/chart/chart.js"></script><!---->
    <script type="text/javascript" src="assets/js/chart/barChart.js"></script><!--柱形图表-->
    <script type="text/javascript" src="assets/js/chart/radarChart.js"></script><!--雷达海图-->
    <script type="text/javascript" src="assets/js/chart/polarChart.js"></script><!--极区海图-->
    <script type="text/javascript" src="assets/js/chart/lineChart.js"></script>

    
    <script type="text/javascript" src="assets/js/chart/jquery.flot2.js"></script>
    <script type="text/javascript" src="assets/js/chart/jquery.flot.resize.js"></script>
    <script type="text/javascript" src="assets/js/chart/chart-float-stacking.js"></script>


</asp:Content>
