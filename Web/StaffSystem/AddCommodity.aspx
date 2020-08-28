<%@ Page Title="" Language="C#" MasterPageFile="~/StaffSystem/StaffSystem.Master" AutoEventWireup="true" CodeBehind="AddCommodity.aspx.cs" Inherits="WalleProject.Web.StaffSystem.AddCommodity" %>

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
    添加商品
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="navHolder">
    添加商品
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentHolder" runat="server">

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
                                商品名称: 
                                <asp:TextBox ID="txt_i_name" CssClass="form-control"
                                    runat="server" />
                                <asp:RequiredFieldValidator
                                    ID="r_i_name" runat="server"
                                    ErrorMessage="必须输入产品名称!"
                                    CssClass="warn"
                                    ValidationGroup="v_insert"
                                    SetFocusOnError="true"
                                    ControlToValidate="txt_i_name" />
                            </p>

                            <p>
                                类别名称: 
                                <asp:DropDownList ID="ddl_i_se" runat="server" DataSourceID="ads_ddl_se" CssClass="form-control"
                                    DataTextField="comc_name" DataValueField="comc_ID">
                                </asp:DropDownList>
                            </p>

                            <p>
                                商品价格: 
                              
                      <asp:TextBox ID="txt_i_price" CssClass="form-control" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator
                                    ID="RequiredFieldValidator1" runat="server"
                                    ErrorMessage="必须输入商品价格!"
                                    CssClass="warn"
                                    ValidationGroup="v_insert"
                                    SetFocusOnError="true"
                                    ControlToValidate="txt_i_price" />
                            </p>

                            <p>
                                单位:
                       <asp:TextBox ID="txt_i_valid" CssClass="form-control" runat="server"></asp:TextBox>
                            </p>
                            <p>
                                生产日期:
                       <asp:TextBox ID="txt_com_productDate" type="date" CssClass="form-control" runat="server"></asp:TextBox>

                            </p>

                        </td>
                        <td class="armada-devider">
                            <p>
                                库存: 
                                <asp:TextBox ID="txt_i_number" CssClass="form-control"
                                    runat="server" />
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2"
                                    runat="server" ErrorMessage="请输入数值!"
                                    ControlToValidate="txt_i_number"
                                    CssClass="warn"
                                    ValidationExpression="^[0-9]*$"
                                    ValidationGroup="v_insert" />

                            </p>
                            <p>
                                货架号: 
                                <asp:TextBox ID="txt_i_strageID" CssClass="form-control"
                                    runat="server" />
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator3"
                                    runat="server" ErrorMessage="请输入数值!"
                                    ControlToValidate="txt_i_strageID"
                                    CssClass="warn"
                                    ValidationExpression="^[0-9]*$"
                                    ValidationGroup="v_insert" />

                            </p>
                            <p>
                                预警值: 
                                <asp:TextBox ID="txt_i_alertNumber" CssClass="form-control"
                                    runat="server" />
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
                                    runat="server" ErrorMessage="请输入数值!"
                                    ControlToValidate="txt_i_alertNumber"
                                    CssClass="warn"
                                    ValidationExpression="^[0-9]*$"
                                    ValidationGroup="v_insert" />

                            </p>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
        <asp:Button ID="Button2" CssClass="btn btn-info form-control" runat="server" Text="添加" OnClick="Button1_Click" Width="200px" />
    </div>
    <asp:SqlDataSource ID="ads_ddl_se"
        runat="server" ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
        ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
        SelectCommand="SELECT * FROM  t_commoditycategory "></asp:SqlDataSource>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="NewHolder" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="JavaScriptHolder" runat="server">
</asp:Content>
