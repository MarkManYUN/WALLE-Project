<%@ Page Language="C#" AutoEventWireup="true" ValidateRequest="false" CodeBehind="NewsAdd.aspx.cs" Inherits="WalleProject.Web.StaffSystem.NewsAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>添加新闻</title>
    <link href="kindeditor/plugins/code/prettify.css" rel="stylesheet" type="text/css" />
    <script src="kindeditor/lang/zh_CN.js" type="text/javascript"></script>
    <script src="kindeditor/kindeditor.js" type="text/javascript"></script>
    <script src="kindeditor/plugins/code/prettify.js" type="text/javascript"></script>
    <script type="text/javascript">
        KindEditor.ready(function (K) {
            var editor = K.create('#content', {
                //上传管理
                uploadJson: 'kindeditor/asp.net/upload_json.ashx',
                //文件管理
                fileManagerJson: 'kindeditor/asp.net/file_manager_json.ashx',
                allowFileManager: true,
                //设置编辑器创建后执行的回调函数
                afterCreate: function () {
                    var self = this;
                    K.ctrl(document, 13, function () {
                        self.sync();
                        K('form[name=example]')[0].submit();
                    });
                    K.ctrl(self.edit.doc, 13, function () {
                        self.sync();
                        K('form[name=example]')[0].submit();
                    });
                },
                //上传文件后执行的回调函数,获取上传图片的路径
                afterUpload: function (url) {
                    alert(url);
                },
                //编辑器高度
                width: '700px',
                //编辑器宽度
                height: '450px;',
                //配置编辑器的工具栏
                items: [
                    'source', '|', 'undo', 'redo', '|', 'preview', 'print', 'template', 'code', 'cut', 'copy', 'paste',
                    'plainpaste', 'wordpaste', '|', 'justifyleft', 'justifycenter', 'justifyright',
                    'justifyfull', 'insertorderedlist', 'insertunorderedlist', 'indent', 'outdent', 'subscript',
                    'superscript', 'clearhtml', 'quickformat', 'selectall', '|', 'fullscreen', '/',
                    'formatblock', 'fontname', 'fontsize', '|', 'forecolor', 'hilitecolor', 'bold',
                    'italic', 'underline', 'strikethrough', 'lineheight', 'removeformat', '|', 'image', 'multiimage',
                    'flash', 'media', 'insertfile', 'table', 'hr', 'emoticons', 'baidumap', 'pagebreak',
                    'anchor', 'link', 'unlink', '|', 'about'
                ]
            });
            prettyPrint();
        });
    </script>

    <link rel="stylesheet" href="assets/css/bootstrap.css" />
    <script src="assets/js/jquery.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#lb_i_img").change(function () {
                $("#img_i_mo").attr("src", $(this).find("option:selected").text());
            });

            $("#lb_e_img").change(function () {
                $("#img_e_mo").attr("src", $(this).find("option:selected").text());
            });
        });
    </script>
    <link href="assets/css/loader-style.css" rel="stylesheet" />
    <link href="assets/js/upload/demos/css/uploader.css" rel="stylesheet" />
    <link href="assets/js/upload/demos/css/demo.css" rel="stylesheet" />
    <script src="assets/js/upload/demos/js/demo.min.js"></script>


    <link rel="shortcut icon" href="assets/ico/minus.png" />
</head>
<body style="background-image: url(../images/45890.jpg); background-position: center; background-repeat: repeat-y">
    <form id="form1" runat="server">
        <div class="row" style="padding: 10%;">
            <div class="col-lg-4" style="">
                <!-- D&D Zone-->
                <div id="drag-and-drop-zone" class="uploader">
                    <div>拖动 &amp;  图片到此处</div>
                    <div class="or">-or-</div>
                    <div class="browser">
                        <label>
                            <span>文件中选择</span>
                            <asp:FileUpload ID="fup_com_img" type="file" runat="server" title='点击添加图片' />
                        </label>
                    </div>
                </div>
                <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                    <tr>
                        <td class="tdbg">

                            <table cellspacing="0" cellpadding="0" width="100%" border="0">

                                <tr>
                                    <td height="25" width="30%" align="right"></td>
                                    <td height="25" width="*" align="left">
                                        <asp:TextBox ID="txtnew_title" TextMode="MultiLine" placeholder="新闻标题" CssClass="form-control" runat="server" Width="200px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="25" width="30%" align="right"></td>
                                    <td height="25" width="*" align="left">
                                        <asp:DropDownList runat="server" Width="200px" placeholder="新闻类型" CssClass="form-control" DataTextField="newc_name" DataValueField="newc_ID" ID="txtnew_cate_id" DataSourceID="SqlDataSource1"></asp:DropDownList>
                                        <asp:SqlDataSource ID="SqlDataSource1" runat="server"
                                            ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
                                            ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
                                            SelectCommand="SELECT * FROM  t_newscategory "></asp:SqlDataSource>
                                    </td>
                                </tr>
                                <tr>

                                    <td>
                                        <img alt="新闻名" class=" img-rounded" id="img_i_mo" data-src="holder.js/64x64"
                                            style="max-width: 150px; margin: 1%;" src="../_wasteImage/8.jpg" />
                                    </td>
                                    <td>
                                        <asp:ListBox ID="lb_i_img" runat="server" placeholder="选择新闻图片" Width="200px" CssClass=" list  list-group-item-info media-list"
                                            DataSourceID="ADS_IMG"
                                            
                                            DataTextField="pic_valid" DataValueField="pic_ID"
                                            Rows="7" ClientIDMode="Static"></asp:ListBox>
                                    </td>
                                </tr>

                                <tr>
                                    <td height="25" width="30%" align="right"></td>
                                    <td height="25" width="*" align="left">
                                        <asp:TextBox ID="txtnew_valid" TextMode="MultiLine" placeholder="新闻简述" CssClass="form-control" runat="server" Width="200px"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                            <script src="/js/calendar1.js" type="text/javascript"></script>

                        </td>
                    </tr>
                    <tr>
                        <td class="tdbg" align="center" valign="bottom"></td>
                    </tr>
                </table>
                <br />

            </div>
            <div class="col-lg-8" style="">
                <h2 style="color: aliceblue;">新闻内容</h2>
                <p height="25" width="100%;" align="left">
                </p>
                <textarea id="content" cols="100" rows="8" style="width: 700px; height: 200px; visibility: hidden;" runat="server"></textarea>
                <br />
                <p class="tdbg" align="center" valign="bottom">
                    <asp:Button ID="btnSave" runat="server" Text="保存"
                        OnClick="btnSave_Click" class="btn btn-info"></asp:Button>
                    <asp:Button ID="btnCancle" runat="server" Text="取消"
                        OnClick="btnCancle_Click" class="btn btn-default"></asp:Button>
                </p>
            </div>

        </div>
        <asp:SqlDataSource ID="ADS_IMG"
            runat="server" ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
            ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
            SelectCommand="SELECT * FROM  t_picture  WHERE  pic_cate_ID  = ? ">
            <SelectParameters>
                <asp:Parameter DefaultValue="1" Name="pic_cate_ID" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
