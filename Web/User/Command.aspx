<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="Command.aspx.cs" Inherits="WalleProject.Web.User.Command" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .wrapper {
            height: 20px;
            padding: 5px;
            width: 130px;
            margin: 100px auto 10px;
        }

        button {
            width: 100px;
            height: 40px;
            line-height: 40px;
        }
    </style>

    <link href="../StaffSystem/assets/css/loader-style.css" rel="stylesheet" />
    <link href="../StaffSystem/assets/js/upload/demos/css/uploader.css" rel="stylesheet" />
    <link href="../StaffSystem/assets/js/upload/demos/css/demo.css" rel="stylesheet" />
    <script src="../StaffSystem/assets/js/upload/demos/js/demo.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label runat="server" ID="traid" Style="display: none;"></asp:Label>
    <input type="text" runat="server" id="grade" class="star_grade" style="display: none;" />


    <asp:TextBox ID="userid" runat="server" Style="display: none;"></asp:TextBox>
    <div class="templatemo-flex-row flex-content-row templatemo-overflow-hidden">

        <!-- overflow hidden for iPad mini landscape view-->
        <div class="col-1 templatemo-overflow-hidden">
            <div class="templatemo-content-widget white-bg templatemo-overflow-hidden">
                <i class="fa fa-times"></i>
                <div class="templatemo-flex-row flex-content-row" style="height: 100%;">
                    <div class="col-1 col-lg-6 col-md-12">

                        <asp:MultiView ID="MultiView1" runat="server">
                            <asp:View ID="inpuContent" runat="server">

                                <!-- 评论内容 -->
                                <div class="row form-group" runat="server">
                                    <div class="col-lg-12 form-group">
                                        <label class="control-label" for="inputNote">输入评论</label>
                                        <textarea runat="server" class="form-control" id="inputNote" rows="3"></textarea>
                                    </div>
                                </div>
                                <div class="row form-group" runat="server">
                                    <label class="control-label" for="inputNote">选择图片</label>
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
                                <!-- 星级 -->
                                <div class="jquery-star1">星级：</div>
                                <br />


                                <!-- 提交评论 -->
                                <button class="btn btn-default btn-primary" runat="server" onserverclick="Unnamed_ServerClick" type="submit">完成评论</button>
                                <button class="btn btn-default" type="submit">取消</button>
                            </asp:View>
                            <asp:View ID="CommandArea" runat="server">
                                <p>评论成功</p>
                            </asp:View>
                            <asp:View ID="ComandView" runat="server">
                                <p>已经评论</p>
                            </asp:View>
                        </asp:MultiView>





                        <asp:ListView ID="ListView1" runat="server" ItemPlaceholderID="holder" DataSourceID="SqlDataSource1">
                            <LayoutTemplate>
                                <div runat="server" id="holder"></div>
                            </LayoutTemplate>
                            <ItemTemplate>
                                <div class="row item" style="padding: 10px;">

                                    <div class="col-md-2">
                                        <asp:Image ID="Image2" Height="80px" Width="100px" runat="server" CssClass="fl img-circle" ImageUrl='<%#Eval("pic_valid") %>' />
                                    </div>
                                    <div class="col-md-10">
                                        <div class="row">
                                            <h3><%#Eval("oe_per_type")  %>的评论   <small><mark>[<%#Eval("oe_grade") %>星]</mark></small></h3>
                                        </div>
                                        <div class="row">
                                            <blockquote class="blockquote-reverse">
                                                <span class="fr text-right "><%#Eval("oe_date","{0:F}") %></span>
                                                评论内容
                                                <p class="text-left text-success"><%#Eval("oe_content") %></p>
                                            </blockquote>
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:ListView>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server"
                            ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
                            ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
                            SelectCommand="SELECT * from t_orderevaluate
inner join t_user on t_orderevaluate.oe_per_id=t_user.u_ID
INNER JOIN  t_tradingrecord on t_tradingrecord.tra_ID=t_orderevaluate.oe_tra_id
INNER JOIN  t_picture ON pic_ID=t_orderevaluate.oe_pic_id  
inner join t_address on t_address.add_ID=t_tradingrecord.tra_addressID    WHERE ( oe_tra_id  = ?)">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="traid" Name="oe_tra_id" PropertyName="Text" Type="Int32" />
                            </SelectParameters>
                        </asp:SqlDataSource>

                    </div>
                </div>
            </div>
        </div>
    </div>



</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footJS" runat="server">
    <script src="starjs/jquery.star.js"></script>
    <link href="starjs/jquery.star.min.css" rel="stylesheet" />

    <script type="text/javascript">
        $('.jquery-star1').star({
            //number : 5, 默认5星
            onSelect: function (index, offEvt) {
                console.log(this);
                console.log(index);
                var grade = $('.star_grade');
                grade.val(index);
            }
        });

        $('.jquery-star2').star({
            number: 10,
            onSelect: function (index, offEvt) {
                console.log(this);
                console.log(index);
                offEvt(); //取消事件
            }
        });
    </script>
</asp:Content>
