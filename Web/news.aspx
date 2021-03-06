﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="news.aspx.cs" Inherits="WalleProject.Web.news" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <link rel="icon" href="img/fav-icon.png" type="image/x-icon" />
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>新闻中心</title>

    <!-- Icon css link -->
    <link href="css/font-awesome.min.css" rel="stylesheet">

    <!-- Bootstrap -->
    <link href="css/bootstrap.min.css" rel="stylesheet">

    <!-- Extra plugin css -->
    <link href="vendors/owl-carousel/assets/owl.carousel.min.css" rel="stylesheet">

    <link href="css/style.css" rel="stylesheet">

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
        <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
        <![endif]-->
</head>
<body>
    
    <!--================Header Area =================-->
    <header class="main_header_area">
        <div class="header_top">
            <div class="container">
                <div class="pull-left">
                    <a href="index.html">
                        <img src="img/logo_3.png" alt=""></a>
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
                        <h4>hello@logistics.com</h4>
                    </div>
                    <div class="header_c_text">
                        <a class="quote_btn" href="#">登录</a>
                    </div>
                </div>
            </div>
        </div>
        <div class="main_menu_area">
            <nav class="navbar navbar-default">
                <div class="container">
                    <!-- Brand and toggle get grouped for better mobile display -->
                    <div class="navbar-header">
                        <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
                            <span class="sr-only">Toggle navigation</span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                        </button>
                    </div>

                    <!-- Collect the nav links, forms, and other content for toggling -->
                    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                        <ul class="nav navbar-nav">
                            <li><a href="default.aspx">首页</a></li>
                            <li><a href="news.aspx">新闻中心</a></li>
                            <li><a href="serve.aspx">服务中心</a></li>
                            <li><a href="contact.aspx">联系我们</a></li>
                            <li><a href="about.aspx">关于我们</a></li>
                        </ul>
                    </div>
                    <!-- /.navbar-collapse -->
                </div>
                <!-- /.container -->
            </nav>
        </div>
    </header>
    <!--================End Header Area =================-->

    <!--================Banner Area =================-->
    <section class="banner_area">
        <div class="container">
            <div class="pull-left">
                <h3>新闻中心</h3>
            </div>
            <div class="pull-right">
                <a href="index.html">Home</a>
                <a href="contact2.html">Contact</a>
            </div>
        </div>
    </section>
    <!--================End Banner Area =================-->

    <!--================End Banner Area =================-->
    <section class="contact_form_area2">
        <div class="container">
            <div class="row">
                <div class="col-md-7">
                    <h3 class="single_title">Contact Form</h3>
                    <div class="row">
                        <form class="contact_us_form" action="php/contact.php" method="post" id="phpcontactform">
                            <div class="form-group col-md-6">
                                <input type="text" class="form-control" id="name" name="name" placeholder="Your Name">
                            </div>
                            <div class="form-group col-md-6">
                                <input type="email" class="form-control" id="email" name="email" placeholder="Email">
                            </div>
                            <div class="form-group col-md-12">
                                <input type="text" class="form-control" id="subject" name="subject" placeholder="Subject">
                            </div>
                            <div class="form-group col-md-12">
                                <textarea class="form-control" id="message" name="message" placeholder="Message" rows="1"></textarea>
                            </div>
                            <div class="form-group col-md-12 button_area">
                                <button type="submit" value="submit your quote" class="btn submit_blue form-control" id="js-contact-btn">Send message <i class="fa fa-angle-right"></i></button>
                                <div id="js-contact-result" data-success-msg="Success, We will get back to you soon" data-error-msg="Oops! Something went wrong"></div>
                            </div>
                        </form>
                    </div>
                </div>
                <div class="col-md-5">
                    <h3 class="single_title">Contact Details</h3>
                    <div class="contact_details_inner">
                        <div class="media">
                            <div class="media-left">
                                <i class="fa fa-map-marker"></i>
                            </div>
                            <div class="media-body">
                                <p>B - 562, Mallin Street </p>
                                <p>New Youk, NY 100 254</p>
                            </div>
                        </div>
                        <div class="media">
                            <div class="media-left">
                                <i class="fa fa-envelope-o"></i>
                            </div>
                            <div class="media-body">
                                <a href="#">info@consultplus.com</a>
                                <a href="#">support@consultplus.com</a>
                            </div>
                        </div>
                        <div class="media">
                            <div class="media-left">
                                <i class="fa fa-phone"></i>
                            </div>
                            <div class="media-body">
                                <a href="#">+ 1800 562 2487</a>
                                <a href="#">+ 3215 546 8975</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--================End Banner Area =================-->

    <!--================Map Area =================-->
    <!-- Things to modify: Your Location Latitude, Longitude, Map Zoom and Google Maps API Key. [[[ See Docs ]]]  -->
    <div class="google-map" id="gmaps" data-lat="40.6700" data-lon="-73.9400" data-maps-apikey="AIzaSyDMTUkJAmi1ahsx9uCGSgmcSmqDTBF9ygg" data-zoom="11"></div>
    <!--================End Map Area =================-->

    <!--================Footer Area =================-->
    <footer class="footer_area">
        <div class="footer_widget_area">
            <div class="container">
                <div class="row">
                    <div class="col-md-3 col-xs-6">
                        <aside class="f_widget about_widget">
                            <img src="img/footer-logo.png" alt="">
                            <p>Start.ly Logistics is a mobile first responsive website template for logistics or transportation.</p>
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
                                <h3>Quick Links</h3>
                            </div>
                            <ul>
                                <li><a href="#">INVESTER RELATIONS</a></li>
                                <li><a href="#">PRESS & MEDIA</a></li>
                                <li><a href="#">CAREER OPENINGS</a></li>
                                <li><a href="#">OUR PARTNERS</a></li>
                                <li><a href="#">LEGAL NOTICE</a></li>
                                <li><a href="#">COOKIE POLICY</a></li>
                                <li><a href="#">TERMS & CONDITIONS</a></li>
                            </ul>
                        </aside>
                    </div>
                    <div class="col-md-3 col-xs-6">
                        <aside class="f_widget service_widget">
                            <div class="f_title">
                                <h3>Services</h3>
                            </div>
                            <ul>
                                <li><a href="#">Standard Air Freight Services</a></li>
                                <li><a href="#">Sea Freight Services</a></li>
                                <li><a href="#">Full loads and part loads</a></li>
                                <li><a href="#">Specialized Transport</a></li>
                                <li><a href="#">Logistics Solutions</a></li>
                                <li><a href="#">Tailored Project Transport</a></li>
                            </ul>
                        </aside>
                    </div>
                    <div class="col-md-3 col-xs-6">
                        <aside class="f_widget info_widget">
                            <div class="f_title">
                                <h3>Contact</h3>
                            </div>
                            <div class="contact_details">
                                <p>21 E. Valley Stream Blvd.<br class="info_br" />
                                    Valley Stream, NY 11580, USA</p>
                                <p>Phone: <a href="tel:+1-(255)-7899">+1 (255) 7899</a></p>
                                <p>Fax: <a href="#">+1 (320) 5228</a></p>
                                <p>Email: <a href="mailto:hello@logistics.com">hello@logistics.com</a></p>
                            </div>
                        </aside>
                    </div>
                </div>
            </div>
        </div>
        <div class="footer_copy_right">
            <div class="container">
                <h4>Copyright &copy; 2017.Company name All rights reserved.</h4>
            </div>
        </div>
    </footer>
    <!--================End Footer Area =================-->


    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="js/jquery-2.2.4.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>

    <!-- Extra Plugin js -->
    <script src="vendors/owl-carousel/owl.carousel.min.js"></script>
    <script src="vendors/magnific-popup/jquery.magnific-popup.min.js"></script>

    <!-- Contact js -->
    <script src="js/validate.js"></script>
    <script src="js/contact.js"></script>

    <script src="js/script.js"></script>
</body>
</html>
