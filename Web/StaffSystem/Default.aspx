<%@ Page Title="" Language="C#" MasterPageFile="~/StaffSystem/StaffSystem.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WalleProject.Web.StaffSystem.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="assets/js/jquery.js"></script>

    <link rel="stylesheet" href="assets/css/style.css" />
    <link rel="stylesheet" href="assets/css/loader-style.css" />
    <link rel="stylesheet" href="assets/css/bootstrap.css" />
    <link rel="stylesheet" href="assets/css/media.css" />
    <link rel="stylesheet" href="assets/css/social.css" />


</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="TitleHolder" runat="server">
    员工系统主页
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="navHolder">
    欢迎页
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="server">
    <div class="row">
        <div class="col-lg-7">

            <img src="../images/1271524_1481079904YaMa.jpg" class="img-thumbnail"  style="max-height:500px;max-width:500px;"/>
        </div>
        <!--  信息页 -->
        <!--  BLOG SIDE CONTENT -->
        <div class="row" >
            <div class="col-sm-5">
                <div class="panel panel-default" style="">
                    <img class="media-object img-circle blog-profile" data-src="holder.js/64x64"
                        alt="64x64" runat="server" id="default_img" style="margin-left: 42%; max-height: 80px; max-width: 80px;"
                        src="http://api.randomuser.me/portraits/thumb/men/10.jpg" />
                    <hr style="margin: 0;" />

                    <div class="panel-body">
                        <p class="lead text-center">
                            <label runat="server" id="username"></label>
                        </p>
                        <p class="tex-center social-blog-profile"  >
                            <a href="#">
                                <span class="entypo-facebook-circled" style="color: #428BCA;"></span>
                            </a>
                            <a class="tweet-link" href="#">
                                <span class="entypo-twitter-circled" style="color: #0AA699;"></span>
                            </a>
                            <a class="gplus-textcolor" href="#">
                                <span class="entypo-instagrem" style="color: #FF6B6B;"></span>
                            </a>

                        </p>
                        <p class="social-follower text-center">
                            <label runat="server" id="usertype"></label>
                        </p>



                    </div>
                </div>

                <div class="blog-side-nest">
                    <h4 class="text-center">进入时事通讯</h4>
                    <p class="text-center">报名参加我们的每日新闻</p>
                    <form role="form">
                        <div class="row">
                            <div class="col-xs-8">
                                <div class="form-group">
                                    <input type="email" class="form-control" placeholder="输入电子邮件">
                                </div>
                            </div>
                            <!-- /.col-xs-8 -->
                            <div class="col-xs-4 col-full-width-left">
                                <button type="submit" class="btn btn-info btn-block">参加</button>
                            </div>
                            <!-- /.col-xs-4 -->
                        </div>
                        <!-- /.row -->
                    </form>

                </div>

            </div>
        </div>
        <!--  END OF BLOG SIDE CONTENT -->
        <!--  结束信息页 -->
    </div>
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="NewHolder">
    <div class="content-wrap">
        <div class="row">
            <div class="col-lg-8">
                <div id="siteClose" class="nest">
                    <div class="title-alt">
                        <h6>
                            <span class="fontawesome-truck"></span>&nbsp;员工业务榜</h6>
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
                                            <div class="armada">
                                                <span style="background: #65C3DF">
                                                    <span class="maki-bus"></span>&nbsp;&nbsp;Trans Berlin</span>
                                                <p>
                                                    <span class="entypo-gauge"></span>&nbsp;12 Km/<i>Hours</i>
                                                </p>
                                            </div>
                                        </td>
                                        <td class="driver-devider">
                                            <img class="armada-pic img-circle" alt="" src="http://api.randomuser.me/portraits/thumb/men/14.jpg">
                                            <h3>Mark Zukenbeirg</h3>
                                            <br>
                                            <p>Driver</p>
                                        </td>
                                        <td class="progress-devider">


                                            <section id="basic">
                                                <article>

                                                    <div class="number-pb">
                                                        <div class="number-pb-shown"></div>
                                                        <div class="number-pb-num">0</div>
                                                    </div>
                                                </article>
                                            </section>
                                            <span class="label pull-left">Berlin</span>
                                            <span class="label pull-right">Muchen</span>

                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="armada-devider">
                                            <div class="armada">
                                                <span style="background: #45B6B0">
                                                    <span class="fontawesome-plane"></span>&nbsp;&nbsp;Fly Airlines</span>
                                                <p>
                                                    <span class="entypo-gauge"></span>&nbsp;600 Km/<i>Hours</i>
                                                </p>
                                            </div>
                                        </td>
                                        <td class="driver-devider">
                                            <img class="armada-pic img-circle" alt="" src="http://api.randomuser.me/portraits/thumb/men/38.jpg">
                                            <h3>Marko Freytag</h3>
                                            <br>
                                            <p>Pilot</p>
                                        </td>
                                        <td class="progress-devider">


                                            <section id="percentage">
                                                <article>
                                                    <div class="number-pb">
                                                        <div class="number-pb-shown dream"></div>
                                                        <div class="number-pb-num">0%</div>
                                                    </div>
                                                </article>
                                            </section>


                                            <span class="label pull-left">Berlin</span>
                                            <span class="label pull-right">London</span>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="armada-devider">
                                            <div class="armada">
                                                <span style="background: #FF6B6B">
                                                    <span class="maki-aboveground-rail"></span>&nbsp;&nbsp;Fazttrain</span>
                                                <p>
                                                    <span class="entypo-gauge"></span>&nbsp;40 Km/<i>Hours</i>
                                                </p>
                                            </div>
                                        </td>
                                        <td class="driver-devider">
                                            <img class="armada-pic img-circle" alt="" src="http://api.randomuser.me/portraits/thumb/men/39.jpg">
                                            <h3>Dieter Gruenewald</h3>
                                            <br>
                                            <p>machinist</p>
                                        </td>
                                        <td class="progress-devider">

                                            <section id="step">
                                                <article>

                                                    <div class="number-pb">
                                                        <div class="number-pb-shown sun"></div>
                                                        <div class="number-pb-num">0/0</div>
                                                    </div>
                                                </article>
                                            </section>

                                            <span class="label pull-left">Berlin</span>
                                            <span class="label pull-right">Dortmund</span>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-lg-4">
                <div id="RealTimeClose" class="nest">
                    <div class="title-alt">
                        <h6>
                            <span class="fontawesome-resize-horizontal"></span>&nbsp;Direction</h6>
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
                        <ul class="direction">
                            <li>
                                <span class="direction-icon maki-fuel" style="background: #FF6B6B"></span>
                                <h3>
                                    <span>Gas Station</span>
                                </h3>
                                <p>
                                    5 Km Foward&nbsp;&nbsp;<i class="fa fa-arrow-circle-up"></i>
                                </p>
                                <p><i>Estimated time </i>:&nbsp;<i class="fa fa-clock-o"></i>&nbsp;&nbsp;20 Min</p>
                            </li>
                            <li class="divider"></li>
                            <li>
                                <span class="direction-icon maki-fast-food" style="background: #65C3DF"></span>
                                <h3>
                                    <span>Restourant</span>
                                </h3>
                                <p>
                                    1 Km Turn Left&nbsp;&nbsp;<i class="fa fa-reply"></i>
                                </p>
                                <p><i>Estimated time </i>:&nbsp;<i class="fa fa-clock-o"></i>&nbsp;&nbsp;20 Min</p>
                            </li>
                            <li class="divider"></li>
                            <li>
                                <span class="direction-icon maki-giraffe" style="background: #45B6B0"></span>
                                <h3>
                                    <span>Zoo</span>
                                </h3>
                                <p>
                                    3 Km Turn Right &nbsp;&nbsp;<i class="fa fa-share"></i>
                                </p>
                                <p><i>Estimated time </i>:&nbsp;<i class="fa fa-clock-o"></i>&nbsp;&nbsp;20 Min</p>
                            </li>
                            <li class="divider"></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>




    <div class="content-wrap">
        <div class="row">
            <div class="col-lg-6">
                <div class="chart-wrap">
                    <div class="chart-dash">
                        <div id="placeholder" style="width: 100%; height: 200px;"></div>
                    </div>
                    <div class="row">
                        <div class="col-lg-8">
                            <div class="speed">
                                <h2>平均月回收总额</h2>
                                <h1>25
                                            <span>万元</span>
                                </h1>
                            </div>
                        </div>
                        <div class="col-lg-4">
                            <div class="traffic">
                                <h2>月增长率</h2>
                                <h1>2.5874<span>%</span></h1>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-4">
                            <div class="traffic-rates">
                                <h4>3月回收总额</h4>
                                <h1>20
                                            <span>-1,2 %</span>
                                </h1>
                            </div>
                        </div>
                        <div class="col-lg-4">
                            <div class="traffic-rates">
                                <h4>2月回收总额</h4>
                                <h1>30
                                            <span>+1,8 %</span>
                                </h1>
                            </div>
                        </div>
                        <div class="col-lg-4">
                            <div class="traffic-rates">
                                <h4>1月回收总额</h4>
                                <h1>26
                                            <span>-0,2 %</span>
                                </h1>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- 天气预报 -->
            <div class="col-lg-6">
                <div class="weather-wrap">
                    <div class="row">
                        <div class="col-lg-12">
                            <div class="temperature">
                                <b><% Response.Write(@DateTime.Now.ToLongDateString()); %></b>

                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-lg-4">
                            <div class="weather-icon">
                                <i class="wi-day-cloudy"></i>
                            </div>
                        </div>
                        <div class="col-lg-8">
                            <div class="weather-text">
                                <h2>淮安
                                            <br />
                                    <i>多云</i>
                                </h2>
                            </div>
                        </div>
                    </div>
                    <!-- 温度 -->
                    <div class="row">
                        <div class="col-lg-12">
                            <div class="weather-text">
                                <h3><i class="wi-thermometer"></i>18<i class="wi-celcius"></i>
                                </h3>
                            </div>
                        </div>
                    </div>
                    <!-- 未来天气 -->
                    <div class="weather-dash">
                        <div class="row">
                            <div class="col-lg-2">
                                <div class="daily-weather">
                                    <h2>Mon</h2>
                                    <h3>85
                                                <span><i class="wi-fahrenheit"></i>
                                                </span>
                                    </h3>
                                    <h4>
                                        <span><i class="wi-day-lightning"></i>
                                        </span>
                                    </h4>
                                    <h5>15
                                                <i>km/h</i>
                                    </h5>
                                </div>
                            </div>
                            <div class="col-lg-2">
                                <div class="daily-weather">
                                    <h2>Tue</h2>
                                    <h3>81
                                                <span><i class="wi-fahrenheit"></i>
                                                </span>
                                    </h3>
                                    <h4><i class="wi-day-cloudy"></i>
                                    </h4>
                                    <h5>12
                                                <i>km/h</i>
                                    </h5>
                                </div>
                            </div>
                            <div class="col-lg-2">
                                <div class="daily-weather">
                                    <h2>Wed</h2>
                                    <h3>83
                                                <span><i class="wi-fahrenheit"></i>
                                                </span>
                                    </h3>
                                    <h4><i class="wi-rain-mix"></i>
                                    </h4>
                                    <h5>14
                                                <i>km/h</i>
                                    </h5>
                                </div>
                            </div>
                            <div class="col-lg-2">
                                <div class="daily-weather">
                                    <h2>Thu</h2>
                                    <h3>80
                                                <span><i class="wi-fahrenheit"></i>
                                                </span>
                                    </h3>
                                    <h4><i class="wi-day-sunny"></i>
                                    </h4>
                                    <h5>15
                                                <i>km/h</i>
                                    </h5>
                                </div>
                            </div>
                            <div class="col-lg-2">
                                <div class="daily-weather">
                                    <h2>Fri</h2>
                                    <h3>79
                                                <span><i class="wi-fahrenheit"></i>
                                                </span>
                                    </h3>
                                    <h4><i class="wi-day-storm-showers"></i>
                                    </h4>
                                    <h5>11
                                                <i>km/h</i>
                                    </h5>
                                </div>
                            </div>
                            <div class="col-lg-2">
                                <div class="daily-weather">
                                    <h2>Sat</h2>
                                    <h3>82
                                                <span><i class="wi-fahrenheit"></i>
                                                </span>
                                    </h3>
                                    <h4><i class="wi-cloudy"></i>
                                    </h4>
                                    <h5>10
                                                <i>km/h</i>
                                    </h5>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
            <!-- 结束天气预报 -->
        </div>
    </div>

    <!-- /最后的内容-->

</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="JavaScriptHolder">

    <script>
        // Basic FitVids Test
        $(".blog-list-nest").fitVids();
        // Custom selector and No-Double-Wrapping Prevention Test
        $(".blog-list-nest").fitVids();
    // Custom selector and No-Double-Wrapping Prevention Test
    </script>




    <!-- 轨距 -->


    <script type="text/javascript" src="assets/js/chart/jquery.flot.js"></script>
    <script type="text/javascript" src="assets/js/chart/jquery.flot.resize.js"></script>
    <script type="text/javascript" src="assets/js/chart/realTime.js"></script>
    <script type="text/javascript" src="assets/js/speed/canvasgauge-coustom.js"></script>
    <script type="text/javascript" src="assets/js/countdown/jquery.countdown.js"></script>



    <script src="assets/js/jhere-custom.js"></script>

    <script>
        var gauge4 = new Gauge("canvas4", {
            'mode': 'needle',
            'range': {
                'min': 0,
                'max': 90
            }
        });
        gauge4.draw(Math.floor(Math.random() * 90));
        var run = setInterval(function () {
            gauge4.draw(Math.floor(Math.random() * 90));
        }, 3500);
    </script>


    <script type="text/javascript">
        /* Javascript
         *
         * See http://jhere.net/docs.html for full documentation
         */
        $(window).on('load', function () {
            $('#mapContainer').jHERE({
                center: [52.500556, 13.398889],
                type: 'smart',
                zoom: 10
            }).jHERE('marker', [52.500556, 13.338889], {
                icon: 'assets/img/marker.png',
                anchor: {
                    x: 12,
                    y: 32
                },
                click: function () {
                    alert('Hallo from Berlin!');
                }
            })
                .jHERE('route', [52.711, 13.011], [52.514, 13.453], {
                    color: '#FFA200',
                    marker: {
                        fill: '#86c440',
                        text: '#'
                    }
                });
        });
    </script>
    <script type="text/javascript">
        var output, started, duration, desired;

        // Constants
        duration = 5000;
        desired = '50';

        // Initial setup
        output = $('#speed');
        started = new Date().getTime();

        // Animate!
        animationTimer = setInterval(function () {
            // If the value is what we want, stop animating
            // or if the duration has been exceeded, stop animating
            if (output.text().trim() === desired || new Date().getTime() - started > duration) {
                console.log('animating');
                // Generate a random string to use for the next animation step
                output.text('' + Math.floor(Math.random() * 60)

                );

            } else {
                console.log('animating');
                // Generate a random string to use for the next animation step
                output.text('' + Math.floor(Math.random() * 120)

                );
            }
        }, 5000);
    </script>
    <script src="assets/js/flatvideo/jquery.fitvids.js"></script>
    <script type="text/javascript">

        $('#getting-started').countdown('2018/06/01', function (event) {
            $(this).html(event.strftime(

                '<span>%M</span>' + '<span class="start-min">:</span>' + '<span class="start-min">%S</span>'));
        });
    </script>
    <script>
        // Basic FitVids Test
        $(".blog-list-nest").fitVids();
        // Custom selector and No-Double-Wrapping Prevention Test
        $(".blog-list-nest").fitVids();
    // Custom selector and No-Double-Wrapping Prevention Test
    </script>

</asp:Content>

