<%@ Page Title="" Language="C#" MasterPageFile="~/StaffSystem/StaffSystem.Master" AutoEventWireup="true" ClientIDMode="Static" CodeBehind="SalaryManage.aspx.cs" Inherits="WalleProject.Web.StaffSystem.SalaryManage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            $("#SalaryManage_StaffPosition").change(function () {
                $("#SalaryManage_ifm_1").attr("src", "SalaryAdd.aspx?id=" + $(this).find("option:selected").text());
            });
            $("#btn_find").click(function () {
                var id = $("#txt_id").val();
                $("#SalaryManage_ifm_1").attr("src", "SalaryAdd.aspx?id=" + id);
            });
            $("#btn_phone").click(function () {
                var phone = $("#txt_phone").val();
                $("#SalaryManage_ifm_1").attr("src", "SalaryAdd.aspx?phone=" + phone);
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="TitleHolder" runat="server">
    工资管理
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="navHolder" runat="server">
    工资计算
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentHolder" runat="server">
    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>


    <div class="body-nest" id="inline">

        <div class="form_center row">

            <div class="col-lg-6">
                <!-- left join t_staffsalary on t_staff.sta_id=t_staffsalary.sal_sta_id  -->
                <iframe id="SalaryManage_ifm_1" src="SalaryAdd.aspx" style="width: 80%; height: 700px; border: none; margin: 0; padding: 0;"></iframe>
            </div>
            <div class="col-lg-6">
                <div class="form-group">
                    <div class="input-group input-widget">
                        <input style="border-radius: 15px" type="text" placeholder="员工编号查找..." id="txt_id" />
                        <input style="border-radius: 15px" type="button" value="查找" runat="server" class="inputbutton btn btn-primary" id="btn_find" />
                    </div>
                </div>
                <div class="form-group">
                    <div class="input-group input-widget">
                        <input style="border-radius: 15px" type="text" placeholder="员工电话号码查找..." id="txt_phone" />
                        <input type="button" style="border-radius: 15px" value="查找" class="inputbutton btn btn-primary" id="btn_phone" />
                    </div>
                </div>
                <div class="form-group">

                    <asp:ListBox ID="SalaryManage_StaffPosition" CssClass=" list-group" Width="100px" Rows="5" runat="server"
                        DataTextField="sta_id" DataValueField="sta_id" SelectionMode="Single"
                        DataSourceID="SqlDataSource2" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>

                </div>

                <asp:SqlDataSource ID="SqlDataSource2" runat="server"
                    ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
                    ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
                    SelectCommand="SELECT *  FROM t_staff "></asp:SqlDataSource>
            </div>
        </div>

    </div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="NewHolder" runat="server">
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
                                    <a href="TaxEdit.aspx">点击修改税率</a>
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
            </div>

        </div>
    </div>

</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="JavaScriptHolder" runat="server">
</asp:Content>
