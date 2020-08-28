<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="datasorce.aspx.cs" Inherits="WalleProject.Web.TestView.datasorce" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" 
                runat="server" ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>" 
                ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>" 
                SelectCommand="SELECT * FROM [t_pricerecord] ORDER BY [pri_date] DESC">
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
