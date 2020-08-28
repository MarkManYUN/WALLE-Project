<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu2.aspx.cs" Inherits="WalleProject.Web.ViewTest.Menu2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListView ID="ListView1" runat="server"  ItemPlaceholderID="TestHoder" DataSourceID="SqlDataSource1" >
                <LayoutTemplate>
                    <span  runat="server" id="TestHoder">

                    </span>
                </LayoutTemplate>
                <ItemTemplate>
                      <span><%#Eval("menuc_name") %></span><br />
                </ItemTemplate>
            </asp:ListView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"
                ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>" 
                ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
                SelectCommand="SELECT * FROM  t_menucategory  WHERE  menuc_name  = ? ">
                <SelectParameters>
                    <asp:CookieParameter CookieName="id" DefaultValue="评论管理 or menuc_ID=1" Name="menuc_name" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
