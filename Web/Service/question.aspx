<%@ Page Title="" Language="C#" MasterPageFile="~/BeforeMater.Master" AutoEventWireup="true" CodeBehind="question.aspx.cs" Inherits="WalleProject.Web.Service.question" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BeforeTopPlaceHolder" runat="server">
    <h1 style="color: aliceblue;">问题反馈</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="BeforeContentPlaceHolder" runat="server">
    
    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>
    <section class="">
        <div class="container">
            <div class="col-md-4" style="">
                <div class="submenuHolder fl" runat="server" id="div_AboutsubmenuHolder">
                </div>
            </div>

            <div class="col-md-7">
                <div class="our_about_left_content">
                    <h3 class="single_title">问题反馈</h3>
                    <div class="row">

                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <asp:MultiView ID="mv_form" runat="server" ActiveViewIndex="0">
                                    <asp:View ID="v_input" runat="server">


                                        <div class="form-group col-md-6">
                                            <asp:TextBox ID="txt_name" class="form-control" name="name" placeholder="我的名字" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="form-group col-md-6">
                                            <asp:TextBox ID="txt_email" class="form-control" name="name" placeholder="我的邮箱" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="form-group col-md-12">
                                            <asp:TextBox ID="txt_subject" class="form-control" name="name" placeholder="主题" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="form-group col-md-12">

                                            <asp:TextBox ID="txt_msg" class="form-control" name="name" placeholder="消息内容" runat="server"></asp:TextBox>

                                        </div>
                                        <div class="form-group col-md-12 button_area">
                                            <button type="button" value="submit" class="btn submit_blue form-control"
                                                onclientclick="javascript:return alert('确定提交么?');"
                                                onserverclick="Button1_Click"
                                                id="Button1" runat="server">
                                                发送消息 <i class="fa fa-angle-right"></i>
                                            </button>

                                            <button type="reset" value="reset" class="btn submit_blue form-control"
                                                id="Button2" runat="server">
                                                重新填写 <i class="fa fa-angle-right"></i>
                                            </button>
                                            <div id="js-contact-result" data-success-msg="成功，我们很快就会回到你的" data-error-msg="错误，发送失败"></div>
                                        </div>
                                        </div>
                                    </asp:View>
                                    <asp:View ID="v_success" runat="server">
                                        <div class="divInfo_success">
                                            <h4>你的信息已成功提交，我们会尽快处理你的留言.</h4>
                                            <a href="contactFrom.aspx">[返回]</a>

                                        </div>
                                    </asp:View>
                                    <asp:View ID="v_fail" runat="server">
                                        <div class="divInfo_success">
                                            <h4>发送失败，请确定信息是否错误.</h4>
                                            <a href="contactFrom.aspx">[返回]</a>

                                        </div>
                                    </asp:View>
                                </asp:MultiView>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
            </div>




        </div>
    </section>
</asp:Content>
