<%@ Page Title="t_user" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="WalleProject.Web.t_user.List" %>
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
                    BorderWidth="1px" DataKeyNames="u_ID" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="u_address" HeaderText="u_address" SortExpression="u_address" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="u_lastLoginDate" HeaderText="u_lastLoginDate" SortExpression="u_lastLoginDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="u_creaditsLogID" HeaderText="u_creaditsLogID" SortExpression="u_creaditsLogID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="u_registrationDate" HeaderText="u_registrationDate" SortExpression="u_registrationDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="u_nickName" HeaderText="u_nickName" SortExpression="u_nickName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="u_category" HeaderText="u_category" SortExpression="u_category" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="u_birthDate" HeaderText="u_birthDate" SortExpression="u_birthDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="u_state" HeaderText="u_state" SortExpression="u_state" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="u_passWord" HeaderText="u_passWord" SortExpression="u_passWord" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="u_integral" HeaderText="u_integral" SortExpression="u_integral" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="u_creditGrade" HeaderText="u_creditGrade" SortExpression="u_creditGrade" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="u_name" HeaderText="u_name" SortExpression="u_name" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="u_pic_ID" HeaderText="u_pic_ID" SortExpression="u_pic_ID" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="u_ID" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="u_ID" DataNavigateUrlFormatString="Modify.aspx?id={0}"
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
