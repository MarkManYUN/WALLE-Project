<%@ Page Title="" Language="C#" MasterPageFile="~/StaffSystem/StaffSystem.Master" AutoEventWireup="true" CodeBehind="FileView.aspx.cs" Inherits="WalleProject.Web.StaffSystem.FileView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="TitleHolder" runat="server">文件管理
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="navHolder" runat="server">文件管理
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentHolder" runat="server">
      <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>关键字：</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword"  CssClass=" input-group-sm" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Style="width:200px;" CssClass="form-control btn btn-info"  Text="查询"  OnClick="btnSearch_Click" >
                    </asp:Button>                    
                        
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView"  class=" table-hover  table" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="file_ID" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText=" 删除"    >
                                <ItemTemplate> 
                                    <asp:CheckBox  type="checkbox"  CssClass="checkbox " ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="file_date" HeaderText="上传时间" SortExpression="file_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="file_title" HeaderText="文件原名" SortExpression="file_title" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="file_catefory_ID" HeaderText="类型ID" SortExpression="file_catefory_ID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="file_Name" HeaderText="文件名" SortExpression="file_Name" ItemStyle-HorizontalAlign="Center"  /> 
		                  
                            
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
                        <asp:Button ID="btnDelete" Style="width:200px;" CssClass="form-control btn btn-info" runat="server" Text="删除" OnClick="btnDelete_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="NewHolder" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="JavaScriptHolder" runat="server">
</asp:Content>
