<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WalleProject.Web.User.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Main content -->

    <!-- Main content -->
    <div class="templatemo-content col-1 light-gray-bg" style="background-color:#EFEFEF;">
        <div class="templatemo-content-widget white-bg">
            <h2 class="margin-bottom-10">亲爱的<asp:Label runat="server" ID="lab_Name"></asp:Label>:</h2>
            <p class="margin-bottom-0" style="margin-left:10%;">
                 你上一次登录时间：<asp:Label runat="server" ID="lab_lasttime"></asp:Label>

            </p>
        </div>

        <div class="templatemo-content-container">
            <div class="templatemo-flex-row flex-content-row">
                <div class="templatemo-content-widget white-bg col-2">
                    <i class=" fa fa-paper-plane-o"></i>
                     
                    <h2 class="templatemo-inline-block">WALL-E可再生资源回收系统</h2>
                    <hr />
                   <p>&nbsp;&nbsp;&nbsp; &nbsp;在现今背景下，可再生资源的宣传和回收也只是一种形式，多地区分类回收形同虚设。 就算市民们分类，到头来也会成为一堆垃圾，通过处理厂的统一分拣回收的效率太低。
                         
                        在废品回收方面人们生活中的垃圾都是一点一点的不断产生， 而可再生资源的分拣堆放需要一定的空间，同时在与回收员取得联系也实属不易。</p>
                  
                    <p>&nbsp;&nbsp;&nbsp; &nbsp;而通过本回收系统可以通过线上预约、下单、宣传、信息提供、交易并存， 线下回收、分拣、物流并存，通过这个平台将人们的生活代入多快好省的步伐中。</p>
                     
                </div>
                <div class="templatemo-content-widget white-bg col-1 text-center">
                    <i class="fa fa-times"></i>
                    <h2 class="text-uppercase"><asp:Label runat="server" ID="d_lab_user"></asp:Label></h2>
                    <h3 class="text-uppercase margin-bottom-10"><%Response.Write(DateTime.Now.ToLongDateString()); %></h3>
                    <img src="images/bicycle.jpg" alt="Bicycle" class="img-circle img-thumbnail" id="d_img_user" runat="server"/>
                </div>
                <div class="templatemo-content-widget white-bg col-1">
                    <i class="fa fa-times"></i>
                    <h2 class="text-uppercase">WALL-E系统</h2>
                    <h3 class="text-uppercase">活跃度</h3>
                    <hr/>
                    <div class="progress">
                        <div class="progress-bar progress-bar-info" role="progressbar" aria-valuenow="60" aria-valuemin="0" aria-valuemax="100" style="width: 60%;"></div>
                    </div>
                    <div class="progress">
                        <div class="progress-bar progress-bar-success" role="progressbar" aria-valuenow="60" aria-valuemin="0" aria-valuemax="100" style="width: 50%;"></div>
                    </div>
                    <div class="progress">
                        <div class="progress-bar progress-bar-warning" role="progressbar" aria-valuenow="60" aria-valuemin="0" aria-valuemax="100" style="width: 60%;"></div>
                    </div>
                </div>
            </div>
            <div class="templatemo-flex-row flex-content-row">
                <div class="col-1">
                    <div class="templatemo-content-widget orange-bg">
                        <i class="fa fa-times"></i>
                        <div class="media">
                            <div class="media-left">
                                <a href="#">
                                    <img class="media-object img-circle" src="images/sunset.jpg" alt="Sunset"/>
                                </a>
                            </div>
                            <div class="media-body">
                                <h2 class="media-heading text-uppercase">最新接单回收员<asp:Label runat="server" ID="d_staff"></asp:Label></h2>
                                <p>下单废品：<label runat="server" id="d_new_waste"></label></p>
                            </div>
                        </div>
                    </div>
                    <div class="templatemo-content-widget white-bg">
                        <i class="fa fa-times"></i>
                        <div class="media">
                            <div class="media-left">
                                <a href="#">
                                    <img class="media-object img-circle" src="images/sunset.jpg" alt="Sunset"/>
                                </a>
                            </div>
                            <div class="media-body">
                                <h2 class="media-heading text-uppercase"> 未评论订单</h2>
                                <p>下单废品：<label runat="server" id="d_last_waste"></label></p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-1">
                    <div class="panel panel-default templatemo-content-widget white-bg no-padding templatemo-overflow-hidden">
                        <i class="fa fa-times"></i>
                        <div class="panel-heading templatemo-position-relative">
                            <h2 class="text-uppercase">用户环保榜单</h2>
                        </div>
                        <!-- 用户环保榜单 -->
                        <div class="table-responsive">
                            <table class="table table-striped table-bordered">
                                <thead>
                                    <tr>
                                        <td>No.</td>
                                        <td>用户名</td>
                                        <td>昵称</td>
                                        <td>环保值/积分</td>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>1.</td>
                                        <td>潘兴波</td>
                                        <td>黑风暴龙</td>
                                        <td>2500</td>
                                    </tr>
                                    <tr>
                                        <td>2.</td>
                                        <td>刘坤</td>
                                        <td>坤之大魔王</td>
                                        <td>1300</td>
                                    </tr>
                                    <tr>
                                        <td>3.</td>
                                        <td>马云山</td>
                                        <td>Mark</td>
                                        <td>1250</td>
                                    </tr>
                                    <tr>
                                        <td>4.</td>
                                        <td>竺颖林</td>
                                        <td>Bride</td>
                                        <td>1100</td>
                                    </tr>
                                    <tr>
                                        <td>5.</td>
                                        <td>Paul</td>
                                        <td>Richard</td>
                                        <td>1000</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Second row ends -->
            <div class="templatemo-flex-row flex-content-row templatemo-overflow-hidden">
                <!-- overflow hidden for iPad mini landscape view-->
                <div class="col-1 templatemo-overflow-hidden">
                    <div class="templatemo-content-widget white-bg templatemo-overflow-hidden">
                        <i class="fa fa-times"></i>
                        <div class="templatemo-flex-row flex-content-row">
                            <div class="col-1 col-lg-6 col-md-12">
                                <h2 class="text-center">我的环保力量<span class="badge">new</span></h2>
                                <div id="pie_chart_div" class="templatemo-chart"></div>
                                <!-- Pie chart div -->
                            </div>
                            <div class="col-1 col-lg-6 col-md-12">
                                <h2 class="text-center">Interactive<span class="badge">new</span></h2>
                                <div id="bar_chart_div" class="templatemo-chart"></div>
                                <!-- Bar chart div -->
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            
        </div>
    </div>

</asp:Content>
<asp:Content ContentPlaceHolderID="footJS" runat="server">
    <!-- JS -->
    <script src="http://apps.bdimg.com/libs/jquery/1.11.1/jquery.min.js"></script>
    <!-- jQuery -->
    <script src="js/jquery-migrate-1.2.1.min.js"></script>
    <!--  jQuery Migrate Plugin -->
    <script src="https://www.google.com/jsapi"></script>
    <!-- Google Chart -->
    <script>
        /* Google Chart 
        -------------------------------------------------------------------*/
        // Load the Visualization API and the piechart package.
        google.load('visualization', '1.0', { 'packages': ['corechart'] });

        // Set a callback to run when the Google Visualization API is loaded.
        google.setOnLoadCallback(drawChart);

        // Callback that creates and populates a data table,
        // instantiates the pie chart, passes in the data and
        // draws it.
        function drawChart() {

            // Create the data table.
            var data = new google.visualization.DataTable();
            data.addColumn('string', 'Topping');
            data.addColumn('number', '比值');
            data.addRows([
                ['塑料瓶', 3],
                ['废书', 1],
                ['废铁', 1],
                ['废铁', 1],
                ['其他', 2]
            ]);

            // Set chart options
            var options = { 'title': '这一年贡献了多少环保力量？' };

            // Instantiate and draw our chart, passing in some options.
            var pieChart = new google.visualization.PieChart(document.getElementById('pie_chart_div'));
            pieChart.draw(data, options);

            var barChart = new google.visualization.BarChart(document.getElementById('bar_chart_div'));
            barChart.draw(data, options);
        }

        $(document).ready(function () {
            if ($.browser.mozilla) {
                //refresh page on browser resize
                // http://www.sitepoint.com/jquery-refresh-page-browser-resize/
                $(window).bind('resize', function (e) {
                    if (window.RT) clearTimeout(window.RT);
                    window.RT = setTimeout(function () {
                        this.location.reload(false); /* false to get page from cache */
                    }, 200);
                });
            } else {
                $(window).resize(function () {
                    drawChart();
                });
            }
        });

    </script>
    <script type="text/javascript" src="js/templatemo-script.js"></script>
    <!-- Templatemo Script -->

</asp:Content>
