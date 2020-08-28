<%@ Page Title="t_tradingrecord" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="WalleProject.Web.t_tradingrecord.List" %>
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
                    BorderWidth="1px" DataKeyNames="tra_ID" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="tra_U_ID" HeaderText="tra_U_ID" SortExpression="tra_U_ID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tra_transactionAmount" HeaderText="tra_transactionAmount" SortExpression="tra_transactionAmount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tra_transactionDate" HeaderText="tra_transactionDate" SortExpression="tra_transactionDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tra_accomplish" HeaderText="tra_accomplish" SortExpression="tra_accomplish" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tra_staff_id" HeaderText="tra_staff_id" SortExpression="tra_staff_id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sta_comwas_id" HeaderText="sta_comwas_id" SortExpression="sta_comwas_id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tra_number" HeaderText="tra_number" SortExpression="tra_number" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tra_addressID" HeaderText="tra_addressID" SortExpression="tra_addressID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tra_type" HeaderText="tra_type" SortExpression="tra_type" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tra_vaild" HeaderText="tra_vaild" SortExpression="tra_vaild" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tra_sort" HeaderText="tra_sort" SortExpression="tra_sort" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="tra_ID" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="tra_ID" DataNavigateUrlFormatString="Modify.aspx?id={0}"
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
