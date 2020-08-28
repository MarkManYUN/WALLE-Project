<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffMenu.aspx.cs" Inherits="WalleProject.Web.Test.StaffMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" ItemPlaceholderID="TestHoder">
                <LayoutTemplate>
                    <span  runat="server" id="TestHoder">

                    </span>
                </LayoutTemplate>
                <ItemTemplate>
                      <span><%#Eval("menuc_name") %></span><br />
                </ItemTemplate>
            </asp:ListView>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>" ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [t_menucategory] WHERE ([menuc_ID] = ?)">
                <SelectParameters>
                    <asp:CookieParameter CookieName="TEST_MENU" DefaultValue="6" Name="menuc_ID" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>

        </div>
    </form>
</body>
</html>
