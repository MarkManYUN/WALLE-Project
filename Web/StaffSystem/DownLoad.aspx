<%@ Page Title="" Language="C#" MasterPageFile="~/StaffSystem/StaffSystem.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="DownLoad.aspx.cs" Inherits="WalleProject.Web.StaffSystem.DownLoad" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
    <script type="text/javascript">
        $(document).ready(function () {
            $("#fup1").val("");
            $("#img_upload").click(function () {
                $("#fup1").click();
            });
            $("#fup1").change(
                function () {
                    $("#btn_addSession").click();
                });
        });

        function datacheck() {
            if ($("#fup1").val() == "") {
                alert("请选择文件");
                $("#fup1").focus();
                return false;
            }

            var _file = document.getElementById("<%=fup1.ClientID %>");//查找页面中的id为fup的控件    |
            var _size = _file.files[0].size;
            if (_size > 8000000) {
                alert("文件大于8M!");
                $("#fup1").focus();//焦点回到文件选择
                return false;
            }
            var _count = $("#<%=txt_FilesCount.ClientID %>").val();
            if (_count >= 10) {
                disp_alert();
                return false;
            }
            $("#<%=txt_FilesCount.ClientID %>").val(parseInt(_count) + 1);
            return true;
        }
        function disp_alert() {
            alert("最多只能上传10个文件！")
        }
    </script>

    <style type="text/css">
        #img_upload {
            cursor: pointer;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="TitleHolder" runat="server">
    文件下载
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentHolder" runat="server">
    <section class="">
        <div class="container">
            <div class="row">
                <div class="col-md-10">
                    <!--================ Area =================-->
                    <table class="table table-bordered table-striped cf">
                        <thead class="cf">
                            <tr>
                                <th class="numeric">文件编号</th>
                                <th class="numeric">文件名</th>
                                <th class="numeric">上传时间</th>
                                <th class="numeric">点击下载</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:ListView ID="ListView1" runat="server" DataSourceID="Download" ItemPlaceholderID="ItemHolder">
                                <LayoutTemplate>
                                    <asp:PlaceHolder ID="ItemHolder" runat="server"></asp:PlaceHolder>
                                </LayoutTemplate>
                                <ItemTemplate>
                                    <tr>
                                        <th class="numeric"><%#Eval("File_ID") %></th>
                                        <th class="numeric"><%#Eval("File_Title") %></th>
                                        <th class="numeric"><%#Eval("File_Date")%></th>
                                        <th class="numeric">
                                            <asp:Button ID="Button1" class="submit_blue btn  " BackColor="#F5F5F5"
                                                runat="server" Text="点击下载" OnCommand="fdownload"
                                                CommandArgument='<%#Eval("File_ID") %>' /></th>
                                    </tr>
                                </ItemTemplate>

                            </asp:ListView>
                        </tbody>
                    </table>
                    <asp:SqlDataSource ID="Download" runat="server"
                        ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
                        ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
                        SelectCommand="SELECT t_file.file_ID, t_file.file_date, t_file.file_title, t_file.file_catefory_ID, t_file.file_Name, t_file.file_valid, t_filecategory.filec_ID, t_filecategory.filec_name, t_filecategory.filec_path, t_filecategory.file_ext FROM t_file INNER JOIN t_filecategory ON t_file.file_catefory_ID = t_filecategory.filec_ID"></asp:SqlDataSource>
                    <%--分页控件 --%>
                    <div class="divPager">
                        <asp:DataPager ID="DataPager1" runat="server" PagedControlID="ListView1" PageSize="10">
                            <Fields>
                                <asp:NextPreviousPagerField ShowFirstPageButton="true" ShowNextPageButton="false" />
                                <asp:NumericPagerField />
                                <asp:NextPreviousPagerField ShowLastPageButton="true" ShowPreviousPageButton="false" />
                            </Fields>
                        </asp:DataPager>
                    </div>

                    <!--================End Area =================-->
                </div>
            </div>
        </div>

    </section>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="NewHolder" runat="server">
    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>
    <div class="row">
        <div class="col-sm-12">
            <!-- 空白页-->

            <div class="nest" id="Blank_PageClose">
                <div class="title-alt">

                    <h2 style="text-align: center; margin-top: 1em;">多文件上传
                    </h2>
                    <div class="titleClose">
                        <a class="gone" href="#Blank_PageClose">
                            <span class="entypo-cancel"></span>
                        </a>
                    </div>
                    <div class="titleToggle">
                        <a class="nav-toggle-alt" href="#Blank_Page_Content">
                            <span class="entypo-up-open"></span>
                        </a>
                    </div>

                </div>

                <div class="body-nest" id="Blank_Page_Content">
                    <div>

                        <img src="../img/upload3.png" width="32" alt="" id="img_upload" />
                        <div id="div_hidden" style="display: none;">
                            <asp:FileUpload ID="fup1" runat="server" UseSubmitBehavior="false" />
                            <asp:Button ID="btn_addSession" runat="server" Text="Button" OnClientClick="return datacheck()"
                                OnClick="btn_addSession_Click" />
                            <asp:TextBox ID="txt_FilesCount" Text="0" runat="server" />
                        </div>

 <iframe id="ifm_1" src="Upload_info.aspx" style="width: 100%; border: none"></iframe>
                    </div>
                </div>
            </div>
        </div>
        <!-- 结束空白页 -->
    </div>
 
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="JavaScriptHolder" runat="server">
</asp:Content>
