<%@ Page Title="" Language="C#" MasterPageFile="~/StaffSystem/StaffSystem.Master" AutoEventWireup="true" CodeBehind="ImageView.aspx.cs" Inherits="WalleProject.Web.StaffSystem.ImageView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="assets/css/loader-style.css" rel="stylesheet" />
    <link href="assets/js/upload/demos/css/uploader.css" rel="stylesheet" />
    <link href="assets/js/upload/demos/css/demo.css" rel="stylesheet" />
    <script src="assets/js/upload/demos/js/demo.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#ctl00_NewHolder_fup1").val("");
            $("#img_upload").click(function () {
                $("#ctl00_NewHolder_fup1").click();
            });
            $("#ctl00_NewHolder_fup1").change(
                function () {
                    $("#ctl00_NewHolder_btn_addSession").click();
                });
        });

        function datacheck() {
            if ($("#ctl00_NewHolder_fup1").val() == "") {
                alert("请选择文件");
                $("#ctl00_NewHolder_fup1").focus();
                return false;
            }

            var _file = document.getElementById("<%=fup_com_img.ClientID %>");//查找页面中的id为fup的控件    |
            var _size = _file.files[0].size;
            if (_size > 8000000) {
                alert("文件大于8M!");
                $("#fup1").focus();//焦点回到文件选择
                return false;
            }
            return true;
        }

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="TitleHolder" runat="server">
    图片管理
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="navHolder" runat="server">
    所有图片
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentHolder" runat="server">
    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                        <b>关键字：</b>
                    </td>
                    <td class="tdbg">
                        <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="查询" Width="200px" CssClass="form-control btn btn-info" OnClick="btnSearch_Click"></asp:Button>

                    </td>
                    <td class="tdbg"></td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" class=" table-hover table" AllowPaging="True" Width="100%" CellPadding="3" OnPageIndexChanging="gridView_PageIndexChanging"
                BorderWidth="1px" DataKeyNames="pic_ID" OnRowDataBound="gridView_RowDataBound"
                AutoGenerateColumns="false" PageSize="10" RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择">
                        <ItemTemplate>
                            <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:BoundField DataField="pic_cate_ID" HeaderText="图片类别" SortExpression="pic_cate_ID" ItemStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="pic_date" HeaderText="发布时间" SortExpression="pic_date" ItemStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="pic_name" HeaderText="图片名" SortExpression="pic_name" ItemStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="pic_valid" HeaderText="图片路径" SortExpression="pic_valid" ItemStyle-HorizontalAlign="Center" />

                    <asp:HyperLinkField HeaderText="编辑" ControlStyle-CssClass="btn" ControlStyle-Width="50" DataNavigateUrlFields="pic_ID" DataNavigateUrlFormatString="ImageView.aspx?id={0}"
                        Text="编辑" />
                    <asp:TemplateField ControlStyle-Width="50" HeaderText="删除" Visible="false">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                Text="删除"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;"></td>
                    <td align="left">
                        <asp:Button ID="btnDelete" runat="server" Width="200px" CssClass="form-control btn btn-info" Text="删除" OnClick="btnDelete_Click" />
                    </td>
                </tr>
            </table>




        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btnSearch" />
        </Triggers>
    </asp:UpdatePanel>

</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="NewHolder" runat="server">





    <div class="content-wrap">
        <div class="row">
            <div class="col-lg-5">
                <div id="siteClose" class="nest">
                    <div class="title-alt">
                        <h6>
                            <span class="fontawesome-truck"></span>&nbsp;添加图片</h6>
                        <div class="titleClose">
                            <a class="gone" href="#siteClose">
                                <span class="entypo-cancel"></span>
                            </a>
                        </div>
                        <div class="titleToggle">
                            <a class="nav-toggle-alt" href="#site">
                                <span class="entypo-up-open"></span>
                            </a>
                        </div>

                    </div>
                    <div id="site" class="body-nest" style="min-height: 320px;">
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
                        <!-- /D&D Zone -->
                        <div class="table-responsive">
                            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                                <tr>
                                    <td class="tdbg">

                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">

                                            <tr>
                                                <td height="25" width="30%" align="right">图片类别：</td>
                                                <td height="25" width="*" align="left">

                                                    <asp:DropDownList CssClass="form-control" ID="ddl_add" runat="server"
                                                        DataTextField="picca_name" DataValueField="picca_ID" DataSourceID="SqlDataSource1" Width="200px">
                                                    </asp:DropDownList>
                                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server"
                                                        ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
                                                        ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
                                                        SelectCommand="SELECT * FROM  t_picturecategory "></asp:SqlDataSource>
                                                </td>
                                            </tr>

                                            <tr>
                                                <td height="25" width="30%" align="right">图片名：</td>
                                                <td height="25" width="*" align="left">
                                                    <asp:TextBox ID="txtpic_name" CssClass="form-control" runat="server" Width="200px"></asp:TextBox>
                                                </td>
                                            </tr>

                                        </table>
                                    </td>
                                </tr>
                                <tr>

                                    <td class="tdbg" align="center" valign="bottom">
                                        <hr />
                                        <asp:Button ID="btnSave" runat="server" CssClass="inputbutton form-control btn btn-info" Text="保存"
                                            OnClick="btnSave_Click"></asp:Button>
                                        <asp:Button ID="btnCancle" runat="server" Text="取消"
                                            OnClick="btnCancle_Click" CssClass="inputbutton form-control btn btn-default"></asp:Button>
                                    </td>
                                </tr>
                            </table>
                            <br />
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-lg-4">
                <div id="RealTimeClose" class="nest">
                    <div class="title-alt">
                        <h6>
                            <span class="fontawesome-resize-horizontal"></span>&nbsp;编辑图片</h6>
                        <div class="titleClose">
                            <a class="gone" href="#RealTimeClose">
                                <span class="entypo-cancel"></span>
                            </a>
                        </div>
                        <div class="titleToggle">
                            <a class="nav-toggle-alt" href="#RealTime">
                                <span class="entypo-up-open"></span>
                            </a>
                        </div>

                      
                    </div>
                    <div id="RealTime" style="min-height: 296px; padding-top: 20px;" class="body-nest">
                        
                        <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">

                            <tr>
                                <td class="tdbg">

                                    <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                        <tr>
                                            <td height="25" width="30%" align="right">图片类别：

                                            </td>

                                            <td height="25" width="*" align="left">
                                                <asp:DropDownList ID="ddl_edit" CssClass="form-control" runat="server" DataTextField="picca_name" DataValueField="picca_ID" DataSourceID="SqlDataSource1" Width="200px"></asp:DropDownList>

                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">上传时间：</td>

                                            <td height="25" width="*" align="left">
                                                <asp:TextBox ID="edit_date" runat="server" ReadOnly="true" CssClass="form-control" Width="200px" onfocus="setday(this)"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">图片名：</td>

                                            <td height="25" width="*" align="left">
                                                <asp:TextBox ID="edit_name" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">图片路径：</td>

                                            <td height="25" width="*" align="left">
                                                <asp:TextBox ID="edit_path" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <script src="/js/calendar1.js" type="text/javascript"></script>

                                </td>
                            </tr>
                            <tr>
                                <td class="tdbg" align="center" valign="bottom">
                                    <hr />
                                    <asp:Button ID="edit_save" runat="server" Text="保存"
                                        OnClick="edit_save_Click"
                                        CssClass="inputbutton form-control btn btn-info"></asp:Button>
                                    <asp:Button ID="edit_cancle" runat="server" Text="取消"
                                        OnClick="btnCancle_Click" CssClass="inputbutton form-control btn btn-default"></asp:Button>
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
            </div>
            <div class="col-lg-3">
                <div id="RealTimeClose" class="nest">
                    <div class="title-alt  ">
                        <h6>
                            <span class="fontawesome-resize-horizontal"></span>&nbsp;图片信息</h6>
                        <div class="titleClose">
                            <a class="gone" href="#RealTimeClose">
                                <span class="entypo-cancel"></span>
                            </a>
                        </div>
                        <div class="titleToggle">
                            <a class="nav-toggle-alt" href="#RealTime">
                                <span class="entypo-up-open"></span>
                            </a>
                        </div>

                    </div>
                    <div id="RealTime" style="min-height: 296px; padding-top: 20px;" class="body-nest  ">
                        <div>
                            <img runat="server" src="#" id="img" style="max-width: 200px;" />
                        </div>
                        <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                            <tr>
                                <td class="tdbg">

                                    <table cellspacing="0" cellpadding="0" width="100%" border="0">

                                        <tr>
                                            <td height="25" width="30%" align="right">类别：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:Label ID="lblpic_cate_ID" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">图片ID：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:Label ID="lblpic_ID" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">上传时间：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:Label ID="lblpic_date" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">图片名
	：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:Label ID="lblpic_name" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">图片路径
	：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:Label ID="lblpic_valid" runat="server"></asp:Label>
                                            </td>
                                        </tr>

                                    </table>
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>




</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="JavaScriptHolder" runat="server">
</asp:Content>
