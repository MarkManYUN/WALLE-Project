<%@ Page Title="" Language="C#" MasterPageFile="~/BeforeMater.Master" AutoEventWireup="true" CodeBehind="contactUs.aspx.cs" Inherits="WalleProject.Web.Contact.contactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="http://api.map.baidu.com/api?v=2.0&ak=NOraeOytceNxSBgQ7pY9qbrl"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BeforeTopPlaceHolder" runat="server">
    <h1 style="color: aliceblue;">联系方式</h1>
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

                        <div id="div_baiduMap"  style="height: 400px; ">
                            <script type="text/javascript">
                                var map = new BMap.Map("div_baiduMap");
                                map.centerAndZoom(new BMap.Point(119.044855, 33.551576), 18);

                                //控件设置
                                //平移缩放
                                map.addControl(new BMap.NavigationControl());
                                //鼠标滚轮放大缩小
                                map.enableScrollWheelZoom();
                                map.getPanorama();




                                //  获取位置坐标点
                                //map.addEventListener("click", function (e) {
                                //    alert(e.point.lng+","+e.point.lat);
                                //});
                                //添加静态标志
                                var _p = new BMap.Point(119.044855, 33.551576);
                                //var _m1 = new BMap.Marker(_p);
                                //map.addOverlay(_m1);
                                //动画
                                //_m1.setAnimation(BMAP_ANIMATION_BOUNCE);
                               
                                //2.标签提示
                                var _opts = { position: _p, offset: new BMap.Size(25, -10) }
                                var _lab = new BMap.Label("WALL-E", _opts);
                                map.addOverlay(_lab);
                                _lab.setStyle({ color: "RED", fontsize: "15px", padding: "2px" })
                                //自定义图标
                                var _icon = new BMap.Icon("../img/testimonials/testimonials-3.png", new BMap.Size(40, 40));
                                var _m2 = new BMap.Marker(_p, { icon: _icon });
                                map.addOverlay(_m2);
                                //向地图中添加比例尺控件
                                var ctrl_sca = new BMap.ScaleControl({ anchor: BMAP_ANCHOR_BOTTOM_LEFT });
                                map.addControl(ctrl_sca);
                                //向地图中添加缩略图控件
                                var ctrl_ove = new BMap.OverviewMapControl({ anchor: BMAP_ANCHOR_BOTTOM_RIGHT, isOpen: 1 });
                                map.addControl(ctrl_ove);
                                //向地图中添加缩放控件
                                var ctrl_nav = new BMap.NavigationControl({ anchor: BMAP_ANCHOR_TOP_LEFT, type: BMAP_NAVIGATION_CONTROL_LARGE });
                                map.addControl(ctrl_nav);
                            </script>
                        </div>

                        <div class="col-md-15">
                            <div class="contact_details_inner">
                                <div class="media">
                                    <div class="media-left">
                                        <i class="fa fa-map-marker"></i>
                                    </div>
                                    <div class="media-body">
                                        <p>B - 562, MeiCheng Rd.No 1 </p>
                                        <p>Huai An HYIT, NY 200 3001</p>
                                    </div>
                                </div>
                                <div class="media">
                                    <div class="media-left">
                                        <i class="fa fa-envelope-o"></i>
                                    </div>
                                    <div class="media-body">
                                        <a href="#">walle@walle.com</a>
                                        <a href="#">wallesystem@walle.com</a>
                                    </div>
                                </div>
                                <div class="media">
                                    <div class="media-left">
                                        <i class="fa fa-phone"></i>
                                    </div>
                                    <div class="media-body">
                                        <a href="#">+ 159 9618 5425</a>
                                        <a href="#">+ 158 6854 5844</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>



        <!--================End Banner Area =================-->



        </div>
    </section>
  
</asp:Content>
