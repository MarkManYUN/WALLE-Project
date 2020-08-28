<%@ Page Title="t_staffsalary" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="WalleProject.Web.t_staffsalary.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!--Title -->

            <!--Title end -->

            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>关键字：</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="查询"  OnClick="btnSearch_Click" >
                    </asp:Button>                    
                        
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="sal_ID" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="Sal_absenteeismDay" HeaderText="Sal_absenteeismDay" SortExpression="Sal_absenteeismDay" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sal_bonusM" HeaderText="sal_bonusM" SortExpression="sal_bonusM" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sal_describe" HeaderText="sal_describe" SortExpression="sal_describe" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sal_deductM" HeaderText="sal_deductM" SortExpression="sal_deductM" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sal_totalM" HeaderText="sal_totalM" SortExpression="sal_totalM" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sal_incrementM" HeaderText="sal_incrementM" SortExpression="sal_incrementM" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sal_month" HeaderText="sal_month" SortExpression="sal_month" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sal_year" HeaderText="sal_year" SortExpression="sal_year" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sal_date" HeaderText="sal_date" SortExpression="sal_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sal_sta_id" HeaderText="sal_sta_id" SortExpression="sal_sta_id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Sal_leaveDay" HeaderText="Sal_leaveDay" SortExpression="Sal_leaveDay" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="sal_ID" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="sal_ID" DataNavigateUrlFormatString="Modify.aspx?id={0}"
                                Text="编辑"  />
                            <asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="false"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                </asp:GridView>
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
