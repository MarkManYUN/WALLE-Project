<%@ Page Title="" Language="C#" MasterPageFile="~/StaffSystem/StaffSystem.Master" AutoEventWireup="true" CodeBehind="AddStaff.aspx.cs" Inherits="WalleProject.Web.StaffSystem.AddStaff" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="TitleHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentHolder" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="NewHolder" runat="server">
     <div class="col-lg-4">
                <div id="siteClose" class="nest">
                    <div class="title-alt">
                        <h6>
                            <span class="fontawesome-truck"></span>&nbsp;添加员工</h6>
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
                            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                                <tr>
                                    <td class="tdbg">

                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                            <tr>
                                                <td height="25" width="30%" align="right">用户名：</td>
                                                <td height="25" width="*" align="left">
                                                    <asp:TextBox CssClass="form-control"   ID="txtsta_userName" runat="server" Width="200px"></asp:TextBox>
                                                </td>
                                            </tr> 
                                            <tr>
                                                <td height="25" width="30%" align="right">用户密码：</td>
                                                <td height="25" width="*" align="left">
                                                    <asp:TextBox CssClass="form-control"   ID="txtsta_passWord" runat="server" Width="200px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="25" width="30%" align="right">婚姻状况：</td>
                                                <td height="25" width="*" align="left">
                                                    <asp:TextBox  CssClass="form-control"  ID="txtsta_maritalStatus" runat="server" Width="200px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="25" width="30%" align="right">身份证号码：</td>
                                                <td height="25" width="*" align="left">
                                                    <asp:TextBox CssClass="form-control"   ID="txtsta_IDNumber" runat="server" Width="200px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="25" width="30%" align="right">家庭住址：</td>
                                                <td height="25" width="*" align="left">
                                                    <asp:TextBox CssClass="form-control"   ID="txtsta_homeAddress" runat="server" Width="200px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="25" width="30%" align="right">电话号码：</td>
                                                <td height="25" width="*" align="left">
                                                    <asp:TextBox CssClass="form-control"   ID="txtsta_phone" runat="server" Width="200px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="25" width="30%" align="right">真实姓名：</td>
                                                <td height="25" width="*" align="left">
                                                    <asp:TextBox CssClass="form-control"   ID="txtsta_name" runat="server" Width="200px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="25" width="30%" align="right">头像id：</td>
                                                <td height="25" width="*" align="left">
                                                    <asp:TextBox CssClass="form-control"   ID="txtsta__pic_id" runat="server" Width="200px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="25" width="30%" align="right">类别id：</td>
                                                <td height="25" width="*" align="left">
                                                    <asp:TextBox CssClass="form-control"   ID="txtsta_tra_id" runat="server" Width="200px"></asp:TextBox>
                                                </td>
                                            </tr> 
                                            <tr>
                                                <td height="25" width="30%" align="right">当前工资：</td>
                                                <td height="25" width="*" align="left">
                                                    <asp:TextBox CssClass="form-control"   ID="txtsta_salary" runat="server" Width="200px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                        <script src="/js/calendar1.js" type="text/javascript"></script>

                                    </td>
                                </tr>
                                <tr>
                                    <td class="tdbg" align="center" valign="bottom">
                                        <asp:Button ID="btnSave" runat="server" CssClass="btn-info" Text="保存"
                                            OnClick="btnSave_Click" class="inputbutton"  ></asp:Button>
                                        <asp:Button ID="btnCancle" runat="server" CssClass="btn-default" Text="取消"
                                            OnClick="btnCancle_Click" class="inputbutton"  ></asp:Button>
                                    </td>
                                </tr>
                            </table>
                            <br />
                        </div>
                    </div>
                </div>
            </div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="JavaScriptHolder" runat="server">
</asp:Content>
