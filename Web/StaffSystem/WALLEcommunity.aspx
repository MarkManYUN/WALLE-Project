<%@ Page Title="" Language="C#" MasterPageFile="~/StaffSystem/StaffSystem.Master" AutoEventWireup="true" CodeBehind="WALLEcommunity.aspx.cs" Inherits="WalleProject.Web.StaffSystem.WALLEcommunity" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    
    <link href="assets/css/loader-style.css" rel="stylesheet" />
    <link href="assets/js/upload/demos/css/uploader.css" rel="stylesheet" />
    <link href="assets/js/upload/demos/css/demo.css" rel="stylesheet" />
    <script src="assets/js/upload/demos/js/demo.min.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="TitleHolder" runat="server">
    欢迎来到WALL-E社区
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="navHolder" runat="server">
    WALL-E社区
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentHolder" runat="server">


    <asp:TextBox ID="userid" runat="server" Style="display: none;"></asp:TextBox>


    <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" ItemPlaceholderID="holder">
        <LayoutTemplate>
            <div runat="server" id="holder"></div>
        </LayoutTemplate>
        <ItemTemplate>
            <div class="templatemo-content-widget white-bg" style="margin-left: 5%;">
                <div class="media">
                    <div class="media-left">
                        <a href='CommunityShow.aspx?cid=<%#Eval("sl_id") %>'>
                            <img class="media-object  img-rounded" style="max-height: 48px;" src='<%#Eval("pic_valid") %>' alt="Sunset">
                    </div>
                    <div class="media-body">
                        <h2 class="media-heading text-uppercase">用户<%#Eval("sl_per_id") %> <small class="navbar-right" style="margin-right: 20%;"><%#Eval("sl_date") %></small></h2>
                        <p class="text-info"><%#Eval("sl_content") %></p>
                        <ul class="list-inline">
                            <li>
                                <a href="#">
                                    <span class="entypo-network"></span>&nbsp;两天前</a>
                            </li>
                            <li>
                                <a href="#">
                                    <span class="entypo-chat"></span>&nbsp;2 条评论</a>
                            </li>
                            <li>
                                <a href="#">
                                    <span class="entypo-share"></span>&nbsp;14 条分享</a>
                            </li>
                        </ul>
                        </a>
                        <a class="navbar-right" style="margin-right: 20%;" href='CommunityShow.aspx?cid=<%#Eval("sl_id") %>'>查看详情</a>
                    </div>
                </div>
            </div>

        </ItemTemplate>
    </asp:ListView>
    <%--分页控件 --%>
    <div class="divPager text-center">
        <asp:DataPager ID="DataPager1" runat="server" PagedControlID="ListView1" PageSize="5">
            <Fields>
                <asp:NextPreviousPagerField ShowFirstPageButton="true" ShowNextPageButton="false" />
                <asp:NumericPagerField />
                <asp:NextPreviousPagerField ShowLastPageButton="true" ShowPreviousPageButton="false" />
            </Fields>
        </asp:DataPager>
    </div>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server"
        ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
        ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
        SelectCommand="SELECT * FROM  t_systemleave 
                INNER JOIN t_picture on t_picture.pic_ID=t_systemleave.sl_pic_id"></asp:SqlDataSource>




</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="NewHolder" runat="server">

    <div class="content-wrap">
        <div class="row" style="background-color: aliceblue;">


            <!-- 参与讨论 -->
            <div class="col-lg-12">

                <h2>我要发言:</h2>

                <div class="form-group">
                    <label class="control-label label label-default" for="inputNote">输入话题</label>
                    <textarea placeholder="我要发言... " rows="5" id="inputNote" runat="server" class="form-update"></textarea>
                </div>
                <div class="form-group">
                    <label class="control-label label label-default" for="inputNote">选择图片</label>
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
                <!-- 提交  -->
                <button class="btn btn-info pull-right " runat="server" id="btn_submit" onserverclick="btn_submit_ServerClick" type="submit">发布</button>
                <button class="btn btn-default pull-right" type="submit" id="btn_canel" runat="server" onserverclick="btn_canel_ServerClick">取消</button>
            </div>

            <!-- 结束参与讨论 -->

        </div>
    </div>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="JavaScriptHolder" runat="server">
</asp:Content>
