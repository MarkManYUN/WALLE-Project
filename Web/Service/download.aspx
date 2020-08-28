<%@ Page Title="" Language="C#" MasterPageFile="~/BeforeMater.Master" AutoEventWireup="true" CodeBehind="download.aspx.cs" Inherits="WalleProject.Web.Service.download" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #Button1 {
            color: darkblue;
            background-color: #000;
        }
    </style>
     <style type="text/css">
        .item:hover {
            background-color:Silver;
        }
        /*分页控件*/
        /*注意定义步骤*/
        /*1. 定义外框*/
        div.divPager {
            text-align: center;
            padding: 20px;
            font-size: 12px;
        }

        /*2. 定义不活动按钮: .aspNetDisabled为系统分配的类名*/
        .divPager .aspNetDisabled {
            color: Silver;
            background-color: White;
        }

        /*3. 定义页码项通用格式 包括活动链接,非活动链接 当前页*/
        .divPager a, .divPager span span {
            padding: 3px 10px;
            border: 1px solid #dadada;
            border-radius: 4px;
            color: #666;
            background: #f3f3f3;
        }

            /*4. 活动超链接hover伪类 [非活动超链接没有href属性 (系统设定) ]*/
            /*5. 覆盖当前页样式*/
            .divPager a[href]:hover, .divPager span span {
                background-color: #0094ff;
                color: Black;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BeforeTopPlaceHolder" runat="server">
    <h1 style="color: aliceblue;">资料下载</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="BeforeContentPlaceHolder" runat="server">
    <section class="">
        <div class="container">
            <div class="col-md-2" style="">
                <div class="submenuHolder fl" runat="server" id="div_AboutsubmenuHolder">
                </div>
            </div>


            <div class="container">
                <div class="row">
                    <div class="col-md-10">
                        <!--================ Area =================-->

                        <asp:ListView ID="ListView1" runat="server" DataSourceID="Download" ItemPlaceholderID="ItemHolder">
                            <LayoutTemplate>
                                <asp:PlaceHolder ID="ItemHolder" runat="server"></asp:PlaceHolder>
                            </LayoutTemplate>
                            <ItemTemplate>

                                <h3>下载文件： <%#Eval("File_Title") %>
                                    <small style="padding-left: 2em; padding-right: 2em;">上传时间：<%#Eval("File_Date")%> </small>


                                    <asp:Button ID="Button1" class="submit_blue btn  form-control" BackColor="#2ecc71" runat="server" Text="点击下载" OnCommand="fdownload"
                                        CommandArgument='<%#Eval("File_ID") %>' />
                                </h3>
                            </ItemTemplate>
                        </asp:ListView>
                        <asp:SqlDataSource ID="Download" runat="server"
                            ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
                            ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
                            SelectCommand="SELECT t_file.file_ID, t_file.file_date, t_file.file_title,
                            t_file.file_catefory_ID, t_file.file_Name, t_file.file_valid, t_filecategory.filec_ID,
                            t_filecategory.filec_name, t_filecategory.filec_path, t_filecategory.file_ext FROM t_file 
                            INNER JOIN t_filecategory ON t_file.file_catefory_ID = t_filecategory.filec_ID"></asp:SqlDataSource>
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
        </div>
    </section>
</asp:Content>
