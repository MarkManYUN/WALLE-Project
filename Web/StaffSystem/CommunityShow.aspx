<%@ Page Title="" Language="C#" MasterPageFile="~/StaffSystem/StaffSystem.Master" AutoEventWireup="true" CodeBehind="CommunityShow.aspx.cs" Inherits="WalleProject.Web.StaffSystem.CommunityShow" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link href="../StaffSystem/assets/css/loader-style.css" rel="stylesheet" />
    <link href="../StaffSystem/assets/js/upload/demos/css/uploader.css" rel="stylesheet" />
    <link href="../StaffSystem/assets/js/upload/demos/css/demo.css" rel="stylesheet" />
    <script src="../StaffSystem/assets/js/upload/demos/js/demo.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="TitleHolder" runat="server">
    评论区
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="navHolder" runat="server">评论详情
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentHolder" runat="server">

    <!-- 评论主题 -->

         <!--CONTENT-->
            <div class="row" style="margin-top:30px;padding:0 15px;">
                <!--  BLOG CONTENT -->
                <div class="col-sm-12">


    <div class="blog-list-nest">
        <div class="vendor">
            <img class="img-responsive-media img-rounded " runat="server"  id="main_img" src='#' style="max-height:400px;"  alt="Sunset" />
        </div>

        <div class="blog-list-content">
            <h2>用户<asp:Label runat="server" ID="userid"></asp:Label></h2>
            <p runat="server" class=" text-capitalize" id="date"></p>
            <p runat="server" class="text-info" id="content"></p>
            <p class="pull-right">
                <span class="label label-default">环境保护</span>
                <span class="label label-default">系统</span>
                <span class="label label-default">回收</span>
            </p>
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
            <hr />
            <button class="btn btn-info pull-right">返回更多</button>
            <div style="clear: both;"></div>
        </div>
    </div>
</div></div>

    <!--  结束评论主题 -->

    <!-- 评论展示区 -->
    <asp:TextBox ID="TextBox1" runat="server" Style="display: none;"></asp:TextBox>


    <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" ItemPlaceholderID="holder">
        <LayoutTemplate>
            <div runat="server" id="holder"></div>
        </LayoutTemplate>
        <ItemTemplate>
            <div class="vendor">

                <blockquote>
                    <img class="media-object img-rounded img-rounded" style="max-height: 48px; float: left;" src='<%#Eval("pic_valid") %>' alt="Sunset">

                    <p><%#Eval("si_per_type") %>  <%#Eval("si_per_id") %><small><%#Eval("si_date") %></small></p>

                    <p class="text-info"><%#Eval("si_content") %></p>
                </blockquote>
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
        SelectCommand=" select * FROM t_systeminterchange 
INNER JOIN t_systemleave on t_systemleave.sl_id=t_systeminterchange.si_sl_id
INNER JOIN t_picture on t_picture .pic_ID=t_systeminterchange.si_pic_id
"></asp:SqlDataSource>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="NewHolder" runat="server">
    <!-- 参与讨论 -->


    <div class="comment-nest">
        <h2>参与讨论:</h2>
        <div class="well">

            <div class="form-group">
                <label class="control-label label label-default" for="inputNote">讨论话题</label>
                <textarea placeholder="我要发言... " rows="5" id="inputNote" runat="server" class="form-update"></textarea>
            </div>
            <div class="form-group">
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
            <button class="btn btn-info pull-right" runat="server" id="btn_submit" onserverclick="btn_submit_ServerClick" type="submit">发布</button>
            <button class="btn   btn-default pull-right" type="submit" id="btn_canel" runat="server" onserverclick="btn_canel_ServerClick">取消</button>

        </div>
    </div>

    <!-- 结束参与讨论 -->
    <div class="blog-side-nest">
        <h4 class="text-left">标签</h4>
        <hr style="margin: 0" />
        <ul class="list-inline">
            <li>
                <a class="btn btn-info" href="#">系统</a>
            </li>
            <li>
                <a class="btn btn-info" href="#">坏境保护</a>
            </li>
            <li>
                <a class="btn btn-info" href="#">垃圾分类</a>
            </li>
            <li>
                <a class="btn btn-info" href="#">作用</a>
            </li>
            <li>
                <a class="btn btn-info" href="#">服务</a>
            </li>
            <li>
                <a class="btn btn-info" href="#">分布</a>
            </li>
            <li>
                <a class="btn btn-info" href="#">上线</a>
            </li>
            <li>
                <a class="btn btn-info" href="#">投诉</a>
            </li>

        </ul>
    </div>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="JavaScriptHolder" runat="server">
</asp:Content>
