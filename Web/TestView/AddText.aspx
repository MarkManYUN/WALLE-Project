<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddText.aspx.cs" Inherits="WalleProject.Web.TestView.AddText" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" Height="300px" ID="txt_content" Width="100%"></asp:TextBox>
            <br />


            <asp:DropDownList ID="DropDownList1" runat="server" DataTextField="wasc_name" DataValueField="wasc_ID" DataSourceID="wastecategory"></asp:DropDownList>

            <asp:Button Text="插入" runat="server" ID="buttonAdd" OnClick="buttonAdd_Click" />
            
            
            
            <asp:SqlDataSource ID="wastecategory" runat="server"
                ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
                ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
                SelectCommand="SELECT * FROM t_wastecategory"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
