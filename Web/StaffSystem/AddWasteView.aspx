<%@ Page Title="" Language="C#" MasterPageFile="~/StaffSystem/StaffSystem.Master" AutoEventWireup="true" CodeBehind="AddWasteView.aspx.cs" Inherits="WalleProject.Web.StaffSystem.AddWasteView" %>

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
    添加废品
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="navHolder">废品添加</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentHolder" runat="server">
    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>

    <div class="col-md-6">
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
    </div>
    <!-- /D&D Zone -->

    <div id="site" class="body-nest" style="min-height: 296px;">
        <div class="table-responsive">
            <table class="table">
                <thead>
                    <tr>
                        <th></th>
                        <th></th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    <tr>

                        <td class="armada-devider">
                            <!-- 信息 -->

                             <p>
                                            废品名称: 
                                <asp:TextBox ID="txt_i_name"
                                    runat="server"   CssClass="form-control"  />
                                            <asp:RequiredFieldValidator
                                                ID="r_i_name" runat="server"
                                                ErrorMessage="必须输入产品名称!"
                                                CssClass="warn"
                                                ValidationGroup="v_insert"
                                                SetFocusOnError="true"
                                                ControlToValidate="txt_i_name" />
                                        </p>

                            <p>
                                二级类：   
                                            <asp:DropDownList ID="ddl_c" runat="server" DataSourceID="class2"
                                                CssClass="form-control"
                                                DataTextField="wasc_name" DataValueField="wasc_ID">
                                            </asp:DropDownList>


                                <asp:SqlDataSource ID="class2" runat="server"
                                    ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
                                    ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
                                    SelectCommand="SELECT * FROM t_wastecategory  "></asp:SqlDataSource>
                            </p>
                            <p>
                                三级类：
                                            <asp:DropDownList ID="ddl_d" runat="server" DataSourceID="SqlDataSource1ddl_d" CssClass="form-control"
                                                DataTextField="wastecate_name" DataValueField="wastecate_id">
                                            </asp:DropDownList>

                                <asp:SqlDataSource ID="SqlDataSource1ddl_d" runat="server"
                                    ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
                                    ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
                                    SelectCommand="SELECT * FROM  t_wastesmailcate   "></asp:SqlDataSource>

                            </p>
                            <p>
                                废品价格: 
                           
                                          <asp:TextBox ID="iprice" runat="server" CssClass="form-control"></asp:TextBox>

                            </p>

                            <p>
                                单位:
                                 <asp:TextBox ID="chk_e_enable" CssClass="form-control" runat="server"></asp:TextBox>
                            </p>

                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
        <asp:Button ID="Button2" CssClass="btn btn-info form-control" runat="server" Text="添加" OnClick="Button1_Click" Width="200px" />
    </div>
    <asp:SqlDataSource ID="ADS_IMG"
        runat="server" ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
        ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
        SelectCommand="SELECT * FROM  t_picture  WHERE  pic_cate_ID  = ? ">
        <SelectParameters>
            <asp:Parameter DefaultValue="4" Name="pic_cate_ID" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="ads_ddl_se"
        runat="server" ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
        ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
        SelectCommand="SELECT * FROM  t_wastesmailcate "></asp:SqlDataSource>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="NewHolder" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="JavaScriptHolder" runat="server">
</asp:Content>
