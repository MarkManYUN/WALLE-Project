<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WalleProject.Web.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WALL-E首页</title>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <link rel="icon" href="img/fav-icon.png" type="image/x-icon" />
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->

    <!-- Icon css link -->
    <link href="css/font-awesome.min.css" rel="stylesheet"/>

    <!-- Bootstrap -->
    <link href="css/bootstrap.min.css" rel="stylesheet"/>

    <!-- Rev slider css -->
    <link href="vendors/revolution/css/settings.css" rel="stylesheet"/>
    <link href="vendors/revolution/css/layers.css" rel="stylesheet"/>
    <link href="vendors/revolution/css/navigation.css" rel="stylesheet"/>
    <link href="vendors/animate-css/animate.css" rel="stylesheet"/>

    <!-- Extra plugin css -->
    <link href="vendors/owl-carousel/assets/owl.carousel.min.css" rel="stylesheet"/>
    <link href="vendors/magnific-popup/magnific-popup.css" rel="stylesheet"/>

    <link href="css/style.css" rel="stylesheet"/>

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
        <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
        <![endif]-->
</head>
<body>
    <!--================标题区=================-->
    <header class="main_header_area">
        <div class="header_top">
            <div class="container">
                <div class="pull-left">
                    <a href="Default.aspx">
                        <img src="img/logo_3.png" alt=""/></a>
                </div>
                <div class="pull-right">
                    <div class="header_c_text">
                        <h5>公司电话</h5>
                        <h4>159-9619-5524</h4>
                    </div>
                    <div class="header_c_text">
                        <h5>工作时间</h5>
                        <h4>8：00-19:00</h4>
                    </div>
                    <div class="header_c_text">
                        <h5>联系邮箱</h5>
                        <h4>markmanyun@gmail.com</h4>
                    </div>
                    <div class="header_c_text">
                        <a class="quote_btn" href="../User/UserLogin.aspx">用户入口</a>
                        
                    </div>
                    <div class="header_c_text">
                        <a class="quote_btn"  href="Admin/Login.aspx">员工入口</a>
                    </div>

                </div>

            </div>
        </div>
        <div class="main_menu_area">
            <nav class="navbar navbar-default">
                <div class="container">
                    <!-- 品牌和切换组合以更好的移动显示 -->
                    <div class="navbar-header">
                        <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
                            <span class="sr-only">切换导航</span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                        </button>
                    </div>

                    <!-- 收集导航链接、表单和其他用于切换的内容 -->
                    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                        <ul class="nav navbar-nav">
                             <li><a href="../Default.aspx">首页</a></li>
                                <li><a href="../News/newsList.aspx">新闻中心</a></li>
                                <li><a href="../Classroom/garbageclass.aspx">绿色大讲堂</a></li>
                                <li><a href="../Service/download.aspx">服务中心</a></li>
                                <li><a href="../Contact/contactAbout.aspx">关于我们</a></li>
                                
                        </ul>
                        <ul class="nav navbar-nav navbar-right">
                            <li>
                                <div class="input-group">
                                    <input type="text" class="form-control" placeholder="搜索输入...">
                                    <span class="input-group-btn">
                                        <button class="btn btn-default" type="button"><i class="fa fa-search" aria-hidden="true"></i></button>
                                    </span>
                                </div>
                            </li>
                        </ul>
                    </div>
                    <!-- /.navbar-collapse -->
                </div>
                <!-- /.container -->
            </nav>
        </div>
    </header>
    <!--================端部区域 =================-->

    <!--================主滑块区域=================-->
    <section class="main_slider_area">
        <div id="main_slider" class="rev_slider" data-version="5.3.1.6">
            <ul>
                <li data-index="rs-2972" data-transition="fade" data-slotamount="default" data-hideafterloop="0" data-hideslideonmobile="off" data-easein="default" data-easeout="default" data-masterspeed="300" data-rotate="0" data-saveperformance="off" data-title="Creative"
                    data-param1="01" data-param2="" data-param3="" data-param4="" data-param5="" data-param6="" data-param7="" data-param8="" data-param9="" data-param10="" data-description="">
                    <!-- 主图片 -->
                    <img src="img/home-slider/slider-1.jpg" alt="" data-bgposition="center center" data-bgfit="cover" data-bgrepeat="no-repeat" data-bgparallax="5" class="rev-slidebg" data-no-retina>
                    <!-- 布局 -->
                    <div class="slider_text_box">
                        <div class="tp-caption first_text" data-x="['left','left','left','center']" data-y="['top','top','top','top']" data-hoffset="['0','0','0','0']" data-voffset="['250','250','250','140']" data-fontsize="['34','34','34','20']" data-lineheight="['44','44','44','30']"
                            data-width="none" data-height="none" data-whitespace="nowrap" data-type="text" data-responsive_offset="on" data-frames="[{&quot;delay&quot;:10,&quot;speed&quot;:1500,&quot;frame&quot;:&quot;0&quot;,&quot;from&quot;:&quot;y:[-100%];z:0;rX:0deg;rY:0;rZ:0;sX:1;sY:1;skX:0;skY:0;&quot;,&quot;mask&quot;:&quot;x:0px;y:0px;s:inherit;e:inherit;&quot;,&quot;to&quot;:&quot;o:1;&quot;,&quot;ease&quot;:&quot;Power2.easeInOut&quot;},{&quot;delay&quot;:&quot;wait&quot;,&quot;speed&quot;:1500,&quot;frame&quot;:&quot;999&quot;,&quot;to&quot;:&quot;y:[175%];&quot;,&quot;mask&quot;:&quot;x:inherit;y:inherit;s:inherit;e:inherit;&quot;,&quot;ease&quot;:&quot;Power2.easeInOut&quot;}]"
                            data-textalign="['left','left','left','left']" data-paddingtop="[0,0,0,0]" data-paddingright="[0,0,0,0]" data-paddingbottom="[0,0,0,0]" data-paddingleft="[0,0,0,0]">
                            互联网+再生资源回收
                        </div>

                        <div class="tp-caption secand_text" data-x="['left','left','left','center']" data-y="['top','top','top','top']" data-hoffset="['0','0','0','0']" data-voffset="['315','315','315','190']" data-fontsize="['50','50','50','30']" data-lineheight="['60','60','60','40']"
                            data-width="['730','730','730','400']" data-height="none" data-whitespace="['normal','normal','normal','normal']" data-type="text" data-responsive_offset="on" data-frames="[{&quot;delay&quot;:10,&quot;speed&quot;:1500,&quot;frame&quot;:&quot;0&quot;,&quot;from&quot;:&quot;y:[-100%];z:0;rX:0deg;rY:0;rZ:0;sX:1;sY:1;skX:0;skY:0;&quot;,&quot;mask&quot;:&quot;x:0px;y:0px;s:inherit;e:inherit;&quot;,&quot;to&quot;:&quot;o:1;&quot;,&quot;ease&quot;:&quot;Power2.easeInOut&quot;},{&quot;delay&quot;:&quot;wait&quot;,&quot;speed&quot;:1500,&quot;frame&quot;:&quot;999&quot;,&quot;to&quot;:&quot;y:[175%];&quot;,&quot;mask&quot;:&quot;x:inherit;y:inherit;s:inherit;e:inherit;&quot;,&quot;ease&quot;:&quot;Power2.easeInOut&quot;}]"
                            data-textalign="['left','left','left','center']" data-paddingtop="[0,0,0,0]" data-paddingright="[0,0,0,0]" data-paddingbottom="[10,10,10,10]" data-paddingleft="[0,0,0,0]">
                            将可再生资源传统行业转型升级
                        </div>

                        <div class="tp-caption slider_btn" data-x="['left','left','left','center']" data-y="['top','top','top','top']" data-hoffset="['0','0','0','0']" data-voffset="['470','470','470','335']" data-fontsize="['16','16','16','16']" data-lineheight="['26','26','26','26']"
                            data-width="none" data-height="none" data-whitespace="nowrap" data-type="text" data-responsive_offset="on" data-frames='[{"from":"y:[-100%];z:0;rX:0deg;rY:0;rZ:0;sX:1;sY:1;skX:0;skY:0;","mask":"x:0px;y:0px;s:inherit;e:inherit;","speed":1500,"to":"o:1;","delay":150,"ease":"Power2.easeInOut"},{"delay":"wait","speed":300,"to":"opacity:0;","ease":"nothing"}]'
                            data-textalign="['left','left','left','left']" data-paddingtop="[0,0,0,0]" data-paddingright="[0,0,0,0]" data-paddingbottom="[0,0,0,0]" data-paddingleft="[0,0,0,0]">
                            <a class="quote_btn" href="#">想了解更多 <i class="fa fa-angle-right"></i></a>
                        </div>

                        <div class="tp-caption ContentZoom-SmallIcon tp-resizeme rs-parallaxlevel-0" data-x="['left','left','left','center']" data-y="['top','top','top','top']" data-hoffset="['0','0','0','-25']" data-voffset="['190','190','190','80']" data-width="none" data-height="none"
                            data-whitespace="nowrap" data-transform_idle="o:1;" data-transform_hover="o:1;rX:0;rY:0;rZ:0;z:0;s:300;e:Power1.easeInOut;" data-style_hover="c:rgba(111, 124, 130, 1.00);cursor:pointer;" data-transform_in="opacity:0;s:500;e:Power1.easeInOut;"
                            data-transform_out="opacity:0;s:500;e:Power1.easeInOut;s:500;e:Power1.easeInOut;" data-start="0" data-splitin="none" data-splitout="none" data-actions='[{"event":"click","action":"jumptoslide","slide":"previous","delay":""}]' data-responsive_offset="on">
                            <i class="fa fa-angle-left"></i>
                        </div>
                        <div class="tp-caption ContentZoom-SmallIcon tp-resizeme rs-parallaxlevel-0" data-x="['left','left','left','center']" data-y="['top','top','top','top']" data-hoffset="['50','50','50','25']" data-voffset="['190','190','190','80']" data-width="none" data-height="none"
                            data-whitespace="nowrap" data-transform_idle="o:1;" data-transform_hover="o:1;rX:0;rY:0;rZ:0;z:0;s:300;e:Power1.easeInOut;" data-style_hover="c:rgba(111, 124, 130, 1.00);cursor:pointer;" data-transform_in="opacity:0;s:500;e:Power1.easeInOut;"
                            data-transform_out="opacity:0;s:500;e:Power1.easeInOut;s:500;e:Power1.easeInOut;" data-start="0" data-splitin="none" data-splitout="none" data-actions='[{"event":"click","action":"jumptoslide","slide":"next","delay":""}]' data-responsive_offset="on">
                            <i class="fa fa-angle-right"></i>
                        </div>
                    </div>
                </li>
                <li data-index="rs-2973" data-transition="fade" data-slotamount="default" data-hideafterloop="0" data-hideslideonmobile="off" data-easein="default" data-easeout="default" data-masterspeed="300" data-rotate="0" data-saveperformance="off" data-title="Creative"
                    data-param1="01" data-param2="" data-param3="" data-param4="" data-param5="" data-param6="" data-param7="" data-param8="" data-param9="" data-param10="" data-description="">
                    <!-- 主图 -->
                    <img src="img/home-slider/slider-2.jpg" alt="" data-bgposition="center center" data-bgfit="cover" data-bgrepeat="no-repeat" data-bgparallax="5" class="rev-slidebg" data-no-retina>
                    <!-- 布局 -->
                    <div class="slider_text_box">
                        <div class="tp-caption first_text" data-x="['left','left','left','center']" data-y="['top','top','top','top']" data-hoffset="['0','0','0','0']" data-voffset="['250','250','250','140']" data-fontsize="['34','34','34','20']" data-lineheight="['44','44','44','30']"
                            data-width="none" data-height="none" data-whitespace="nowrap" data-type="text" data-responsive_offset="on" data-frames="[{&quot;delay&quot;:10,&quot;speed&quot;:1500,&quot;frame&quot;:&quot;0&quot;,&quot;from&quot;:&quot;y:[-100%];z:0;rX:0deg;rY:0;rZ:0;sX:1;sY:1;skX:0;skY:0;&quot;,&quot;mask&quot;:&quot;x:0px;y:0px;s:inherit;e:inherit;&quot;,&quot;to&quot;:&quot;o:1;&quot;,&quot;ease&quot;:&quot;Power2.easeInOut&quot;},{&quot;delay&quot;:&quot;wait&quot;,&quot;speed&quot;:1500,&quot;frame&quot;:&quot;999&quot;,&quot;to&quot;:&quot;y:[175%];&quot;,&quot;mask&quot;:&quot;x:inherit;y:inherit;s:inherit;e:inherit;&quot;,&quot;ease&quot;:&quot;Power2.easeInOut&quot;}]"
                            data-textalign="['left','left','left','left']" data-paddingtop="[0,0,0,0]" data-paddingright="[0,0,0,0]" data-paddingbottom="[0,0,0,0]" data-paddingleft="[0,0,0,0]">
                            环保与经济共存
                        </div>

                        <div class="tp-caption secand_text" data-x="['left','left','left','center']" data-y="['top','top','top','top']" data-hoffset="['0','0','0','0']" data-voffset="['315','315','315','190']" data-fontsize="['50','50','50','30']" data-lineheight="['60','60','60','40']"
                            data-width="['730','730','730','400']" data-height="none" data-whitespace="['normal','normal','normal','normal']" data-type="text" data-responsive_offset="on" data-frames="[{&quot;delay&quot;:10,&quot;speed&quot;:1500,&quot;frame&quot;:&quot;0&quot;,&quot;from&quot;:&quot;y:[-100%];z:0;rX:0deg;rY:0;rZ:0;sX:1;sY:1;skX:0;skY:0;&quot;,&quot;mask&quot;:&quot;x:0px;y:0px;s:inherit;e:inherit;&quot;,&quot;to&quot;:&quot;o:1;&quot;,&quot;ease&quot;:&quot;Power2.easeInOut&quot;},{&quot;delay&quot;:&quot;wait&quot;,&quot;speed&quot;:1500,&quot;frame&quot;:&quot;999&quot;,&quot;to&quot;:&quot;y:[175%];&quot;,&quot;mask&quot;:&quot;x:inherit;y:inherit;s:inherit;e:inherit;&quot;,&quot;ease&quot;:&quot;Power2.easeInOut&quot;}]"
                            data-textalign="['left','left','left','center']" data-paddingtop="[0,0,0,0]" data-paddingright="[0,0,0,0]" data-paddingbottom="[10,10,10,10]" data-paddingleft="[0,0,0,0]">
                            改善生活环境，重获地球新生
                        </div>

                        <div class="tp-caption slider_btn" data-x="['left','left','left','center']" data-y="['top','top','top','top']" data-hoffset="['0','0','0','0']" data-voffset="['470','470','470','335']" data-fontsize="['16','16','16','16']" data-lineheight="['26','26','26','26']"
                            data-width="none" data-height="none" data-whitespace="nowrap" data-type="text" data-responsive_offset="on" data-frames='[{"from":"y:[-100%];z:0;rX:0deg;rY:0;rZ:0;sX:1;sY:1;skX:0;skY:0;","mask":"x:0px;y:0px;s:inherit;e:inherit;","speed":1500,"to":"o:1;","delay":150,"ease":"Power2.easeInOut"},{"delay":"wait","speed":300,"to":"opacity:0;","ease":"nothing"}]'
                            data-textalign="['left','left','left','left']" data-paddingtop="[0,0,0,0]" data-paddingright="[0,0,0,0]" data-paddingbottom="[0,0,0,0]" data-paddingleft="[0,0,0,0]">
                            <a class="quote_btn" href="#">想了解更多 <i class="fa fa-angle-right"></i></a>
                        </div>

                        <div class="tp-caption ContentZoom-SmallIcon tp-resizeme rs-parallaxlevel-0" data-x="['left','left','left','center']" data-y="['top','top','top','top']" data-hoffset="['0','0','0','-25']" data-voffset="['190','190','190','80']" data-width="none" data-height="none"
                            data-whitespace="nowrap" data-transform_idle="o:1;" data-transform_hover="o:1;rX:0;rY:0;rZ:0;z:0;s:300;e:Power1.easeInOut;" data-style_hover="c:rgba(111, 124, 130, 1.00);cursor:pointer;" data-transform_in="opacity:0;s:500;e:Power1.easeInOut;"
                            data-transform_out="opacity:0;s:500;e:Power1.easeInOut;s:500;e:Power1.easeInOut;" data-start="0" data-splitin="none" data-splitout="none" data-actions='[{"event":"click","action":"jumptoslide","slide":"previous","delay":""}]' data-responsive_offset="on">
                            <i class="fa fa-angle-left"></i>
                        </div>
                        <div class="tp-caption ContentZoom-SmallIcon tp-resizeme rs-parallaxlevel-0" data-x="['left','left','left','center']" data-y="['top','top','top','top']" data-hoffset="['50','50','50','25']" data-voffset="['190','190','190','80']" data-width="none" data-height="none"
                            data-whitespace="nowrap" data-transform_idle="o:1;" data-transform_hover="o:1;rX:0;rY:0;rZ:0;z:0;s:300;e:Power1.easeInOut;" data-style_hover="c:rgba(111, 124, 130, 1.00);cursor:pointer;" data-transform_in="opacity:0;s:500;e:Power1.easeInOut;"
                            data-transform_out="opacity:0;s:500;e:Power1.easeInOut;s:500;e:Power1.easeInOut;" data-start="0" data-splitin="none" data-splitout="none" data-actions='[{"event":"click","action":"jumptoslide","slide":"next","delay":""}]' data-responsive_offset="on">
                            <i class="fa fa-angle-right"></i>
                        </div>
                    </div>
                </li>
            </ul>
        </div>
    </section>
    <!--================最后主要滑块区域 =================-->

    <!--================功能滑块区域 =================-->
    <section class="feature_slider_area">
        <div class="container">
            <div class="row feature_row">
                <div class="feature_slider_inner owl-carousel">
                    <div class="item">
                        <div class="feature_s_item">
                            <img alt="" class="svg social-link" src="img/icon/svg/aeroplane.svg" />
                            <a href="#">
                                <h4>可再生资源</h4>
                            </a>
                            <p>对于可再生资源来说，主要是通过合理调控资源使用率，实现资源的持续利用。可再生资源的持续利用主要受自然增长规律的制约</p>
                        </div>
                    </div>
                    <div class="item">
                        <div class="feature_s_item">
                            <img alt="" class="svg social-link" src="img/icon/svg/ship.svg" />
                            <a href="#">
                                <h4>互联网+</h4>
                            </a>
                            <p>“互联网+”是创新2.0下的互联网发展的新业态，是知识社会创新2.0推动下的互联网形态演进及其催生的经济社会发展新形态。</p>
                        </div>
                    </div>
                    <div class="item">
                        <div class="feature_s_item">
                            <img alt="" class="svg social-link" src="img/icon/svg/delivery-truck.svg" />
                            <a href="#">
                                <h4>环境保护</h4>
                            </a>
                            <p>人类为解决现实的或潜在的环境问题，协调人类与环境的关系，保障经济社会的持续发展而采取的各种行动的总称。其方法和手段有工程技术的、行政管理的、创新研发的，也有法律的、经济的、宣传教育的等。</p>
                        </div>
                    </div>
                    <div class="item">
                        <div class="feature_s_item">
                            <img alt="" class="svg social-link" src="img/icon/svg/aeroplane.svg" />
                            <a href="#">
                                <h4>垃圾分类</h4>
                            </a>
                            <p>按一定规定或标准将垃圾分类储存、分类投放和分类搬运，从而转变成公共资源的一系列活动的总称。分类的目的是提高垃圾的资源价值和经济价值，力争物尽其用。</p>
                        </div>
                    </div>
                    <div class="item">
                        <div class="feature_s_item">
                            <img alt="" class="svg social-link" src="img/icon/svg/ship.svg" />
                            <a href="#">
                                <h4>废品回收</h4>
                            </a>
                            <p>一种有偿性的废品处理生活服务，由专业正规的废品回收站或公司进行收购，之后对废品进行科学处理及分类以达到再次循环利用的标准。废品回收对保护环境、节约能源和带动社会效益起积极作用。</p>
                        </div>
                    </div>
                    <div class="item">
                        <div class="feature_s_item">
                            <img alt="" class="svg social-link" src="img/icon/svg/delivery-truck.svg" />
                            <a href="#">
                                <h4>绿色生活</h4>
                            </a>
                            <p>远离污染。打造绿色生活，可以从点点滴滴生命细节开始：着手减少室内有害气体（不喷发胶）、悬浮颗粒及电磁辐射的污染。纯天然的植物提取物并非都是健康的，自制真正适合自身的护肤品。</p>
                        </div>
                    </div>
                    <div class="item">
                        <div class="feature_s_item">
                            <img alt="" class="svg social-link" src="img/icon/svg/aeroplane.svg" />
                            <a href="#">
                                <h4>能源</h4>
                            </a>
                            <p>人类社会的发展离不开优质能源的出现和先进能源技术的使用。在当今世界，能源的发展，能源和环境，是全世界、全人类共同关心的问题。</p>
                        </div>
                    </div>
                    <div class="item">
                        <div class="feature_s_item">
                            <img alt="" class="svg social-link" src="img/icon/svg/ship.svg" />
                            <a href="#">
                                <h4>新经济</h4>
                            </a>
                            <p>社会占主导地位的产业形态的不同，决定社会经济形态的不同。在不同的历史时期，新经济有不同的内涵。当前新经济是指创新性知识在知识中占主导、创意产业成为龙头产业的智慧经济形态。</p>
                        </div>
                    </div>
                    <div class="item">
                        <div class="feature_s_item">
                            <img alt="" class="svg social-link" src="img/icon/svg/delivery-truck.svg" />
                            <a href="#">
                                <h4>地球家园</h4>
                            </a>
                            <p>一切事物的发生、存在、转化、消亡都是按照一定的规律而运行的，在地球资源严重枯竭、生态环境极速恶化的今天，只有找到这一切现象形成的因缘，才能从根本上转变它。</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--================结束滑块功能区域 =================-->

    <!--================主要功能区域=================-->
    <section class="main_feature_area">
        <div class="left_feature_content">
            <div class="left_feature_inner_text">
                <div class="media">
                    <div class="media-left">
                        <img class="svg social-link" src="img/icon/svg/pointer.svg" alt="" />
                    </div>
                    <div class="media-body">
                        <a href="#">
                            <h4>循环经济</h4>
                        </a>
                        <p>传统经济，转变为依靠生态型资源循环来发展的经济 </p>
                    </div>
                </div>
                <div class="media">
                    <div class="media-left">
                        <img class="svg social-link" src="img/icon/svg/warehouse.svg" alt="" />
                    </div>
                    <div class="media-body">
                        <a href="#">
                            <h4>垃圾分类</h4>
                        </a>
                        <p>垃圾分类是对垃圾收集处置传统方式的改革。 </p>
                    </div>
                </div>
                <div class="media">
                    <div class="media-left">
                        <img class="svg social-link" src="img/icon/svg/route.svg" alt="" />
                    </div>
                    <div class="media-body">
                        <a href="#">
                            <h4>变废为宝</h4>
                        </a>
                        <p>大家也可以利用易拉罐制作笔盒，既环保，又节约资源。 </p>
                    </div>
                </div>
                <div class="media">
                    <div class="media-left">
                        <img class="svg social-link" src="img/icon/svg/delivery-truck2.svg" alt="" />
                    </div>
                    <div class="media-body">
                        <a href="#">
                            <h4>在线预订</h4>
                        </a>
                        <p>与普遍的看法相反，Lorem Ipsum不是简单的随机文本。  </p>
                    </div>
                </div>
                <div class="media">
                    <div class="media-left">
                        <img class="svg social-link" src="img/icon/svg/flight.svg" alt="" />
                    </div>
                    <div class="media-body">
                        <a href="#">
                            <h4>当前形势</h4>
                        </a>
                        <p>最大限度地实现垃圾资源利用。  </p>
                    </div>
                </div>
                <div class="media">
                    <div class="media-left">
                        <img class="svg social-link" src="img/icon/svg/telemarketer.svg" alt="" />
                    </div>
                    <div class="media-body">
                        <a href="#">
                            <h4>回收体制</h4>
                        </a>
                        <p>以旧换新政策也不失为一种非常好的手段。  </p>
                    </div>
                </div>
            </div>
        </div>
        <div class="right_feature_image">
            <img src="img/feature-right.jpg" alt="">
        </div>
    </section>
    <!--================端主要功能区域 =================-->

    <!--================我们的新闻领域=================-->
    <section class="our_blog_area">
        <div class="container">
            <div class="main_title">
                <h5>来自网络</h5>
                <h2>热点新闻</h2>
            </div>
            <div class="row our_blog_inner">
                <div class="col-md-4">
                    <div class="our_blog_item">
                        <div class="our_blog_img">
                            <img src="img/blog/our-blog/our-blog-1.jpg" alt="">
                            <div class="b_date">
                                <h6>3月</h6>
                                <h5>25</h5>
                            </div>
                        </div>
                        <div class="our_blog_content">
                            <a href="#">
                                <h4>增值税税率降低，废塑料老板的税负减轻</h4>
                            </a>
                            <p>从2018年5月1日起，将制造业等行业增值税税率从17%降至16%；将工业企业和商业企业小规模纳税人的年销售额标准由50万元。</p>
                            <h6><a href="#">来源：央视网</a><span>•</span><a href="#">发布时间：2018-03-30</a></h6>
                        </div>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="our_blog_item">
                        <div class="our_blog_img">
                            <img src="img/blog/our-blog/our-blog-2.jpg" alt="">
                            <div class="b_date">
                                <h6>3月</h6>
                                <h5>12</h5>
                            </div>
                        </div>
                        <div class="our_blog_content">
                            <a href="#">
                                <h4>中美“贸易战”打还是不打？</h4>
                            </a>
                            <p>在不同的领导技巧之前，戏剧性地过渡到点击-实体的门户网站。单调的重新获取完整测试后的信息。</p>
                            <h6><a href="#">来源：中国政府网</a><span>•</span><a href="#">发布时间：2018-03-30</a></h6>
                        </div>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="our_blog_item">
                        <div class="our_blog_img">
                            <img src="img/blog/our-blog/our-blog-3.jpg" alt="">
                            <div class="b_date">
                                <h6>3月</h6>
                                <h5>07</h5>
                            </div>
                        </div>
                        <div class="our_blog_content">
                            <a href="#">
                                <h4>环保税开征后，塑料或将全国性
                                    <br class="b_title_br" />
                                    涨价
                                </h4>
                            </a>
                            <p>注意！我国将从2018年4月1日起开征环保税，塑料原料及产品可能要涨价啦。2017年，塑料市场成本涨价最高达18%~35%，2018年还有环保税做推力，涨价是大势所趋。所以，遇到便</p>
                            <h6><a href="#">来源：微LINK化工</a><span>•</span><a href="#">发布时间：2018-03-30</a></h6>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--================结束我们的博客领域=================-->

    <!--================得到引用区域 =================-->
    <section class="get_quote_area">
        <div class="container">
            <div class="pull-left">
                <h4>在全国范围内提供智能的智能回收解决方案</h4>
            </div>
            <div class="pull-right">
                <a class="b_get_btn" href="#">点击加入 <i class="fa fa-angle-right"></i></a>
            </div>
        </div>
    </section>
    <!--================最终得到引用区域 =================-->

    <!--================推荐区域 =================-->
    <section class="testimonials_area">
        <div class="container">
            <div class="testimonials_inner">
                <div class="testimonials_slider owl-carousel">
                    <div class="item">
                        <img class="img-circle" src="img/testimonials/testimonials-1.png" alt="">
                        <p>
                            国家发展和改革委员会印发了《2015年循环经济推进计划》。《计划》明确，我国将推动和引导再生资源回收模式创新，探索“互联网+回收”的模式及路径，积极支持智能回收、自动回收机等新型回收方式发展。
                            <br />
                            这些政策措施落到实处，将会培育中国经济新动能，打造中国未来增长新引擎。
                        </p>
                        <h4>李克强</h4>
                    </div>
                    <div class="item">
                        <img class="img-circle" src="img/testimonials/testimonials-1.png" alt="">
                        <p>
                            国家发展和改革委员会印发了《2015年循环经济推进计划》。《计划》明确，我国将推动和引导再生资源回收模式创新，探索“互联网+回收”的模式及路径，积极支持智能回收、自动回收机等新型回收方式发展。
                            <br />
                            这些政策措施落到实处，将会培育中国经济新动能，打造中国未来增长新引擎。
                        </p>
                        <h4>李克强</h4>
                    </div>
                    <div class="item">
                        <img class="img-circle" src="img/testimonials/testimonials-1.png" alt="">
                        <p>
                            国家发展和改革委员会印发了《2015年循环经济推进计划》。《计划》明确，我国将推动和引导再生资源回收模式创新，探索“互联网+回收”的模式及路径，积极支持智能回收、自动回收机等新型回收方式发展。
                            <br />
                            这些政策措施落到实处，将会培育中国经济新动能，打造中国未来增长新引擎。
                        </p>
                        <h4>李克强</h4>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--================结束感言区域=================-->

    <!--================关于我们的区域 =================-->
    <section class="about_area">
        <div class="container">
            <div class="row">
                <div class="col-md-6">
                    <div class="about_left_text">
                        <h3 class="single_title">关于我们</h3>
                        <p>
                            本系统助力资源利用，可持续发展。
                        </p>
                        <p>
                            在全国范围内重新定位独特的“新型经济”思考和高级过程改进。
                            在未来的专业知识之后，动态地利用灵活的思想。逐步传播多学科的关系。
                       
                        </p>
                        <a class="more_btn" href="#">了解更多 <i class="fa fa-angle-right"></i></a>
                    </div>
                </div>
                <div class="col-md-6">
                    <h4 class="single_title">我们的位置</h4>
                    <!-- 配置您的全球位置在 /js/locations.js -->
                    <div id="jvectormap"></div>
                </div>
            </div>
        </div>
    </section>
    <!--================结束我们的地区 =================-->

    <!--================画廊区 =================-->
    <section class="gallery_area">
        <div class="container">
            <div class="col-md-7">
                <div class="left_gallery_area">
                    <h3 class="single_title">展览</h3>
                    <div class="l_gallery_inner zoom-gallery">
                        <div class="l_gallery_item">
                            <a href="img/gallery/gallery-big-1.jpg">
                                <img src="img/gallery/gallery-1.jpg" alt="">
                            </a>
                        </div>
                        <div class="l_gallery_item">
                            <a href="img/gallery/gallery-big-2.jpg">
                                <img src="img/gallery/gallery-2.jpg" alt="">
                            </a>
                        </div>
                        <div class="l_gallery_item">
                            <a href="img/gallery/gallery-big-3.jpg">
                                <img src="img/gallery/gallery-3.jpg" alt="">
                            </a>
                        </div>
                        <div class="l_gallery_item">
                            <a href="img/gallery/gallery-big-4.jpg">
                                <img src="img/gallery/gallery-4.jpg" alt="">
                            </a>
                        </div>
                        <div class="l_gallery_item">
                            <a href="img/gallery/gallery-big-5.jpg">
                                <img src="img/gallery/gallery-5.jpg" alt="">
                            </a>
                        </div>
                        <div class="l_gallery_item">
                            <a href="img/gallery/gallery-big-6.jpg">
                                <img src="img/gallery/gallery-6.jpg" alt="">
                            </a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-5">
                <div class="right_faq_area">
                    <h3 class="single_title">常见问题</h3>
                    <div class="panel-group" id="accordion" role="tablist" aria-multiselectable="true">
                        <div class="panel panel-default">
                            <div class="panel-heading" role="tab" id="headingOne">
                                <h4 class="panel-title">
                                    <a role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseOne" aria-expanded="true" aria-controls="collapseOne">我们的客户如何跟踪出货？
                                    </a>
                                </h4>
                            </div>
                            <div id="collapseOne" class="panel-collapse collapse in" role="tabpanel" aria-labelledby="headingOne">
                                <div class="panel-body">
                                    在没有企业理念的情况下，协作孵化无所不在的电子商务。在独立之前，客观地抓住2.0质量的矢量
                               
                                </div>
                            </div>
                        </div>
                        <div class="panel panel-default">
                            <div class="panel-heading" role="tab" id="headingTwo">
                                <h4 class="panel-title">
                                    <a class="collapsed" role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">你们提供什么样的保险？
                                    </a>
                                </h4>
                            </div>
                            <div id="collapseTwo" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingTwo">
                                <div class="panel-body">
                                    在没有企业理念的情况下，协作孵化无所不在的电子商务。在独立之前，客观地抓住2。0质量的矢量
                               
                                </div>
                            </div>
                        </div>
                        <div class="panel panel-default">
                            <div class="panel-heading" role="tab" id="headingThree">
                                <h4 class="panel-title">
                                    <a class="collapsed" role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseThree" aria-expanded="false" aria-controls="collapseThree">我怎样付款，你的退款规则是什么？
                                    </a>
                                </h4>
                            </div>
                            <div id="collapseThree" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingThree">
                                <div class="panel-body">
                                    在没有企业理念的情况下，协作孵化无所不在的电子商务。在独立之前，客观地抓住2。0质量的矢量

                                </div>
                            </div>
                        </div>
                        <div class="panel panel-default">
                            <div class="panel-heading" role="tab" id="headingfour">
                                <h4 class="panel-title">
                                    <a class="collapsed" role="button" data-toggle="collapse" data-parent="#accordion" href="#collapsefour" aria-expanded="false" aria-controls="collapsefour">为什么你的利率比其他的低呢？
                                    </a>
                                </h4>
                            </div>
                            <div id="collapsefour" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingfour">
                                <div class="panel-body">
                                    在没有企业理念的情况下，协作孵化无所不在的电子商务。在独立之前，客观地抓住2。0质量的矢量

                                </div>
                            </div>
                        </div>
                        <div class="panel panel-default">
                            <div class="panel-heading" role="tab" id="headingfive">
                                <h4 class="panel-title">
                                    <a class="collapsed" role="button" data-toggle="collapse" data-parent="#accordion" href="#collapsefive" aria-expanded="false" aria-controls="collapsefive">我还有一个问题没有在这里列出
                                    </a>
                                </h4>
                            </div>
                            <div id="collapsefive" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingfive">
                                <div class="panel-body">
                                    在没有企业理念的情况下，协作孵化无所不在的电子商务。在独立之前，客观地抓住2。0质量的矢量

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--================结束画廊区 =================-->

    <!--================客户端滑块区域 =================-->
    <section class="client_logo_area">
        <div class="container">
            <div class="client_slider owl-carousel">
                <div class="item">
                    <img src="img/client-logo/client-1.png" alt="">
                </div>
                <div class="item">
                    <img src="img/client-logo/client-2.png" alt="">
                </div>
                <div class="item">
                    <img src="img/client-logo/client-3.png" alt="">
                </div>
                <div class="item">
                    <img src="img/client-logo/client-4.png" alt="">
                </div>
                <div class="item">
                    <img src="img/client-logo/client-5.png" alt="">
                </div>
            </div>
        </div>
    </section>
    <!--================终端客户端滑块区域 =================-->

    <!--================页脚区 =================-->
    <footer class="footer_area">
        <div class="footer_widget_area">
            <div class="container">
                <div class="row">
                    <div class="col-md-3 col-xs-6">
                        <aside class="f_widget about_widget">
                            <img src="img/footer-logo.png" alt="">
                            <p>基于互联网+的WALL-E可再生资源回收系统是响应国家号召，高效处理传统低效率回收业的系统。</p>
                            <ul>
                                <li><a href="#"><i class="fa fa-facebook"></i></a></li>
                                <li><a href="#"><i class="fa fa-twitter"></i></a></li>
                                <li><a href="#"><i class="fa fa-linkedin"></i></a></li>
                                <li><a href="#"><i class="fa fa-pinterest"></i></a></li>
                            </ul>
                        </aside>
                    </div>
                    <div class="col-md-3 col-xs-6">
                        <aside class="f_widget link_widget">
                            <div class="f_title">
                                <h3>快速通道</h3>
                            </div>
                            <ul>
                                <li><a href="#">投资者关系</a></li>
                                <li><a href="#">新闻及传媒</a></li>
                                <li><a href="#">职业机会</a></li>
                                <li><a href="#">我们的合作伙伴</a></li>
                                <li><a href="#">法律通知</a></li>
                                <li><a href="#">政策</a></li>
                                <li><a href="#">条款和条件</a></li>
                            </ul>
                        </aside>
                    </div>
                    <div class="col-md-3 col-xs-6">
                        <aside class="f_widget service_widget">
                            <div class="f_title">
                                <h3>服务</h3>
                            </div>
                            <ul>
                                <li><a href="#">标准空运服务</a></li>
                                <li><a href="#">海上货运服务</a></li>
                                <li><a href="#">满载和部件装载</a></li>
                                <li><a href="#">专门的运输</a></li>
                                <li><a href="#">物流解决方案</a></li>
                                <li><a href="#">定制项目运输</a></li>
                            </ul>
                        </aside>
                    </div>
                    <div class="col-md-3 col-xs-6">
                        <aside class="f_widget info_widget">
                            <div class="f_title">
                                <h3>联系</h3>
                            </div>
                            <div class="contact_details">
                                <p>
                                    淮阴工学院
                                    <br class="info_br" />
                                    WALL-E可再生资源回收系统
                                </p>
                                <p>电话: <a href="tel:+1-(255)-7899">187-8548-2564</a></p>
                                <p>传真: <a href="#">525-5884254</a></p>
                                <p>邮箱: <a href="mailto:hello@logistics.com">markmanyun@hyit.com</a></p>
                            </div>
                        </aside>
                    </div>
                </div>
            </div>
        </div>
        <div class="footer_copy_right">
            <div class="container">
                <h4>版权所有 &copy; 2018.基于互联网+的WALL-E可再生资源回收系统.</h4>
            </div>
        </div>
    </footer>
    <!--================最终页脚区 =================-->

    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="js/jquery-2.2.4.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
    <!-- Rev slider js -->
    <script src="vendors/revolution/js/jquery.themepunch.tools.min.js"></script>
    <script src="vendors/revolution/js/jquery.themepunch.revolution.min.js"></script>
    <script src="vendors/revolution/js/extensions/revolution.extension.actions.min.js"></script>
    <script src="vendors/revolution/js/extensions/revolution.extension.video.min.js"></script>
    <script src="vendors/revolution/js/extensions/revolution.extension.slideanims.min.js"></script>
    <script src="vendors/revolution/js/extensions/revolution.extension.layeranimation.min.js"></script>
    <script src="vendors/revolution/js/extensions/revolution.extension.navigation.min.js"></script>
    <!-- Extra Plugin js -->
    <script src="vendors/owl-carousel/owl.carousel.min.js"></script>
    <script src="vendors/magnific-popup/jquery.magnific-popup.min.js"></script>
    <!-- jVector maps -->
    <script src="vendors/jvectormap/jvectormap.min.js"></script>
    <script src="vendors/jvectormap/jvectormap-worldmill.js"></script>
    <script src="js/locations.js"></script>
    <!-- Main js -->
    <script src="js/script.js"></script>
</body>

</html>
