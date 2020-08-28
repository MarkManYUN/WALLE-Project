<%@ Page Title="" Language="C#" MasterPageFile="~/StaffSystem/StaffSystem.Master" AutoEventWireup="true" CodeBehind="SalaryView.aspx.cs" Inherits="WalleProject.Web.StaffSystem.SalaryView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="TitleHolder" runat="server">
    工资查询
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="navHolder">查看我的工资</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentHolder" runat="server">
    <h3>你好，<label runat="server" id="staffName"></label><small>员工编号[<asp:Label CssClass="text-info" runat="server" ID="staffID"></asp:Label>]</small>
    </h3><hr />
    <h2>你当前工资：<label style="color:brown;" id="salary" runat="server"></label><small>RMB</small></h2>
    <hr />
    <h4>工资表</h4>
    <asp:GridView ID="GridView1" class="table table-bordered table-striped cf" runat="server" AllowPaging="True" DataSourceID="SqlDataSource1"></asp:GridView>
    
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"
        ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
        ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
        SelectCommand="SELECT  Sal_absenteeismDay as 旷工天数 ,  sal_bonusM as 奖金 ,  sal_describe as 描述,  sal_deductM as 扣除,
        sal_totalM as 总计,  sal_incrementM as 工资基本增长 ,  sal_month 月份,  sal_date 时间,  sal_year 年份,  Sal_leaveDay as 请假天数  FROM  t_staffsalary  WHERE ( sal_sta_id  = ?) ORDER BY  sal_year  DESC,  sal_month  DESC,  sal_date  DESC">
        <SelectParameters>
            <asp:ControlParameter ControlID="staffID" Name="sal_sta_id" PropertyName="Text" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="NewHolder" runat="server">
       <div class="content-wrap">
        <div class="row">
            <div class="col-lg-6">
                <div id="RealTimeClose" class="nest">
                    <div class="title-alt">
                        <h6>
                            <span class="fontawesome-resize-horizontal"></span>&nbsp;税率</h6>
                        <div class="titleClose">
                            <a class="gone" href="#RealTimeClose">
                                <span class="entypo-cancel"></span>
                            </a>
                        </div>
                        <div class="titleToggle">
                            <a class="nav-toggle-alt" href="#RealTime">
                                <span class="entypo-up-open"></span>
                            </a>
                        </div>
                    </div>
                    <div id="RealTime" style="min-height: 296px; padding-top: 20px;" class="body-nest">




                        <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                            <tr>
                                <td class="tdbg">

                                    <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                        <tr>
                                            <td height="25" width="30%" align="right">修改时间：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:Label ID="lblStr_date" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">养老保险：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:Label ID="lblStr_aged" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">编号：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:Label ID="lblStr_ID" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">医疗保险：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:Label ID="lblStr_medical" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">失业保险：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:Label ID="lblStr_unemployment" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">住房公积金：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:Label ID="lblStr_housing" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">补充住房公积金：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:Label ID="lblSta_supplement" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">个人所得税：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:Label ID="lblSta_individualTax" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                    </table> 
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
            </div>

        </div>
    </div>

</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="JavaScriptHolder" runat="server">
</asp:Content>
