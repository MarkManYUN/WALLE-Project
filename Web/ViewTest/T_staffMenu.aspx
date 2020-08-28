<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="T_staffMenu.aspx.cs" Inherits="WalleProject.Web.ViewTest.T_staffMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListView ID="ListView1" runat="server"  ItemPlaceholderID="TestHoder" DataSourceID="SqlDataSource1">
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
                SelectCommand="SELECT * FROM t_menucategory WHERE  menuc_ID = 1">
                <SelectParameters>
                    <asp:CookieParameter CookieName="TEST_MENU" DefaultValue="1" Name="menuc_ID" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>

           

        </div>
    </form>
</body>
</html>
