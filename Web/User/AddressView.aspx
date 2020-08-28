<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="AddressView.aspx.cs" Inherits="WalleProject.Web.User.AddressView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
    <script type="text/javascript">
        function resize_iframe() { //定义一个函数,用于重设父页的iframe高度
            var _iframe = parent.document.getElementById("iframe_Test");
            var _h = document.body.offsetHeight; // 获取本页面高度;

            $(_iframe).attr("height", _h);

        }


        $(document).ready(function () {
            resize_iframe(); //页面载入时,执行一次
        });

        function Button2_onclick() {
            div_resizable.style.height = "100px";
            resize_iframe();  // javascript中,可随时调用函数来重新设定iframe大小

        }

    </script>


    <style type="text/css">
        body {
            margin: 0px;
        }
        /*清除默认body外边距很重要*/
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Main content -->
    <div class="templatemo-content col-1 light-gray-bg">

        <div class="templatemo-content-container">
            <div class="templatemo-content-widget white-bg ">




                <!--Title -->

                <!--Title end -->

                <!--Add  -->

                <!--Add end -->

                <!--Search -->

                <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border ">
                    <tr>

                        <td class="tdbg">
                            
                            <asp:TextBox CssClass="form-control " placeholder="查找联系人" Style="width: 80%;" ID="txtKeyword" runat="server"></asp:TextBox>
                                  
                        </td>

                        <td class="tdbg"> <asp:Button ID="btnSearch" runat="server" CssClass="templatemo-blue-button" Style="" Text="查询" OnClick="btnSearch_Click"></asp:Button>
                                 </td>
                    </tr>
                </table>

                <!--Search end-->
                <br />
                <asp:GridView ID="gridView" CssClass="table table-condensed table-hover" runat="server" AllowPaging="True" Width="100%" CellPadding="3" OnPageIndexChanging="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="add_ID" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10" RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">

                    <Columns>

                        <asp:BoundField DataField="add_contactName" HeaderText="姓名" SortExpression="add_contactName" ItemStyle-HorizontalAlign="Center" />
                        <asp:BoundField DataField="add_contactPhone" HeaderText="电话" SortExpression="add_contactPhone" ItemStyle-HorizontalAlign="Center" />
                        <asp:BoundField DataField="add_postcode" HeaderText="邮编" SortExpression="add_postcode" ItemStyle-HorizontalAlign="Center" />
                        <asp:BoundField DataField="add_address" HeaderText="地址" SortExpression="add_address" ItemStyle-HorizontalAlign="Center" />
                        <asp:BoundField DataField="add_counties" HeaderText="城区" SortExpression="add_counties" ItemStyle-HorizontalAlign="Center" />
                        <asp:BoundField DataField="add_city" HeaderText="城市" SortExpression="add_city" ItemStyle-HorizontalAlign="Center" />
                        <asp:BoundField DataField="add_province" HeaderText="省份" SortExpression="add_province" ItemStyle-HorizontalAlign="Center" />

                        <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="20" DataNavigateUrlFields="add_ID" DataNavigateUrlFormatString="AddressShow.aspx?aid={0}"
                            Text="详细" />
                        <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="20" DataNavigateUrlFields="add_ID" DataNavigateUrlFormatString="AddressModify.aspx?aid={0}"
                            Text="编辑" />

                        <asp:TemplateField ControlStyle-Width="50" HeaderText="删除" Visible="false">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                    Text="删除"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>

            </div>
        </div>
    </div>
</asp:Content>
