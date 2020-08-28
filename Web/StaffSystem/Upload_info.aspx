<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Upload_info.aspx.cs" Inherits="WalleProject.Web.StaffSystem.Upload_info" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="../js/jquery-2.2.4.js"></script>
        <script type="text/javascript">
        $(document).ready(function () {
            var _h = div_main.offsetHeight + 30;
            var _ifm = parent.document.getElementById("ifm_1");
            $(_ifm).attr("height", _h);
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
         <div id="div_main" runat="server" style="color:#9CA1A4;">
        <asp:Table ID="tbl_sessionList" runat="server">
        </asp:Table>

        <asp:HyperLink ID="HyperLink1"  ForeColor="#fff" runat="server" NavigateUrl="Upload_done.aspx">上传全部文件</asp:HyperLink>
    </div>
        
    </form>
</body>
</html>
