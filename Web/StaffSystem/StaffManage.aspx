<%@ Page Title="" Language="C#" MasterPageFile="~/StaffSystem/StaffSystem.Master" AutoEventWireup="true" CodeBehind="StaffManage.aspx.cs" Inherits="WalleProject.Web.StaffSystem.StaffManage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="TitleHolder" runat="server">
    员工管理
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="navHolder">员工列表</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentHolder" runat="server">

    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
             
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                        <b>关键字：</b>
                    </td>
                    <td class="tdbg">
                        <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" CssClass="btn-info" Text="查询" OnClick="btnSearch_Click"></asp:Button>

                    </td>
                    <td class="tdbg"></td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3" OnPageIndexChanging="gridView_PageIndexChanging"
                BorderWidth="1px" DataKeyNames="sta_id" OnRowDataBound="gridView_RowDataBound"
                AutoGenerateColumns="false" PageSize="10" RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择">
                        <ItemTemplate>
                            <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:BoundField DataField="sta_userName" HeaderText="用户名" SortExpression="sta_userName" ItemStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="sta_entryDate" HeaderText="注册日期" SortExpression="sta_entryDate" ItemStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="sta_passWord" HeaderText="密码" SortExpression="sta_passWord" ItemStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="sta_maritalStatus" HeaderText="婚姻状况" SortExpression="sta_maritalStatus" ItemStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="sta_IDNumber" HeaderText="身份证号" SortExpression="sta_IDNumber" ItemStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="sta_homeAddress" HeaderText="地址" SortExpression="sta_homeAddress" ItemStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="sta_phone" HeaderText="联系方式" SortExpression="sta_phone" ItemStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="sta_name" HeaderText="用户姓名" SortExpression="sta_name" ItemStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="sta__pic_id" HeaderText="员工头像ID" SortExpression="sta__pic_id" ItemStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="sta_tra_id" HeaderText="员工类别" SortExpression="sta_tra_id" ItemStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="sta_lastLogindate" HeaderText="最后一次登陆时间" SortExpression="sta_lastLogindate" ItemStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="sta_salary" HeaderText="当前工资" SortExpression="sta_salary" ItemStyle-HorizontalAlign="Center" />


                    <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="sta_id" DataNavigateUrlFormatString="StaffManage.aspx?id={0}"
                        Text="编辑" />
                    <asp:TemplateField ControlStyle-Width="50" HeaderText="删除" Visible="false">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                Text="删除"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;"></td>
                    <td align="left">
                        <asp:Button ID="btnDelete" runat="server" CssClass=" btn-danger" Text="删除" OnClick="btnDelete_Click" />
                    </td>
                </tr>
            </table>




        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btnSearch" />
        </Triggers>
    </asp:UpdatePanel>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="NewHolder" runat="server">

    <div class="content-wrap">
        <div class="row">
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
                                                    <asp:TextBox CssClass="form-control" ID="txtsta_userName" runat="server" Width="200px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="25" width="30%" align="right">用户密码：</td>
                                                <td height="25" width="*" align="left">
                                                    <asp:TextBox CssClass="form-control" ID="txtsta_passWord" runat="server" Width="200px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="25" width="30%" align="right">婚姻状况：</td>
                                                <td height="25" width="*" align="left">
                                                    <asp:TextBox CssClass="form-control" ID="txtsta_maritalStatus" runat="server" Width="200px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="25" width="30%" align="right">身份证号码：</td>
                                                <td height="25" width="*" align="left">
                                                    <asp:TextBox CssClass="form-control" ID="txtsta_IDNumber" runat="server" Width="200px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="25" width="30%" align="right">家庭住址：</td>
                                                <td height="25" width="*" align="left">
                                                    <asp:TextBox CssClass="form-control" ID="txtsta_homeAddress" runat="server" Width="200px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="25" width="30%" align="right">电话号码：</td>
                                                <td height="25" width="*" align="left">
                                                    <asp:TextBox CssClass="form-control" ID="txtsta_phone" runat="server" Width="200px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="25" width="30%" align="right">真实姓名：</td>
                                                <td height="25" width="*" align="left">
                                                    <asp:TextBox CssClass="form-control" ID="txtsta_name" runat="server" Width="200px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            
                                            <tr>
                                                <td height="25" width="30%" align="right">类别：</td>
                                                <td height="25" width="*" align="left">
                                                    <asp:DropDownList runat="server" CssClass="form-control" DataTextField="stac_name" DataValueField="stac_ID"  ID="txtsta_tra_id" Width="200px" DataSourceID="SqlDataSource2"></asp:DropDownList>
                                                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                                                        ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
                                                        ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>" 
                                                        SelectCommand="SELECT  stac_name ,  stac_ID  FROM   t_staffcategory "></asp:SqlDataSource>
                                                </td>
                                            </tr> 
                                            <tr>
                                                <td height="25" width="30%" align="right">当前工资：</td>
                                                <td height="25" width="*" align="left">
                                                    <asp:TextBox CssClass="form-control" ID="txtsta_salary" runat="server" Width="200px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>

                                    </td>
                                </tr>
                                <tr>
                                    <td class="tdbg" align="center" valign="bottom">
                                        <asp:Button ID="btnSave" runat="server" CssClass="btn-info" Text="保存"
                                            OnClick="btnSave_Click" class="inputbutton"></asp:Button>
                                        <asp:Button ID="btnCancle" runat="server" CssClass="btn-default" Text="取消"
                                            OnClick="btnCancle_Click" class="inputbutton"></asp:Button>
                                    </td>
                                </tr>
                            </table>
                            <br />
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-lg-4">
                <div id="RealTimeClose" class="nest">
                    <div class="title-alt">
                        <h6>
                            <span class="fontawesome-resize-horizontal"></span>&nbsp;编辑员工信息</h6>
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
                        <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                            <tr>
                                <td class="tdbg">


                                    <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                        <asp:Label ID="Label1" runat="server" Style="display: none"></asp:Label>

                                        <tr>
                                            <td height="25" width="30%" align="right">用户名：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:TextBox CssClass="form-control" ID="txtEdit_sta_userName" runat="server" Width="200px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">注册时间：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:TextBox CssClass="form-control" ID="txtEdit_sta_entryDate" runat="server" Width="200px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">用户密码：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:TextBox CssClass="form-control" ID="txtEdit_sta_passWord" runat="server" Width="200px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">婚姻状况：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:TextBox CssClass="form-control" ID="txtEdit_sta_maritalStatus" runat="server" Width="200px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">身份证号：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:TextBox CssClass="form-control" ID="txtEdit_sta_IDNumber" runat="server" Width="200px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">家庭住址：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:TextBox CssClass="form-control" ID="txtEdit_sta_homeAddress" runat="server" Width="200px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">电话号码：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:TextBox CssClass="form-control" ID="txtEdit_sta_phone" runat="server" Width="200px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">真实姓名：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:TextBox CssClass="form-control" ID="txtEdit_sta_name" runat="server" Width="200px" /></asp:TextBo>
                                            </td>
                                        </tr>

                                        <tr>
                                            <td height="25" width="30%" align="right">类别ID：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:TextBox CssClass="form-control" ID="txtEdit_sta_tra_id" runat="server" Width="200px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">最后登录：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:TextBox CssClass="form-control" ID="txtEdit_sta_lastLogindate" runat="server" Width="200px" onfocus="setday(this)"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">当前工资：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:TextBox CssClass="form-control" ID="txtEdit_sta_salary" runat="server" Width="200px"></asp:TextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <script src="/js/calendar1.js" type="text/javascript"></script>

                                </td>
                            </tr>
                            <tr>
                                <td class="tdbg" align="center" valign="bottom">
                                    <asp:Button ID="Button21" runat="server" CssClass="btn-info" Text="保存"
                                        OnClick="btnEditSave_Click" class="inputbutton"></asp:Button>
                                    <asp:Button ID="Button2" runat="server" CssClass="btn-default" Text="取消"
                                        OnClick="btnCancle_Click" class="inputbutton"></asp:Button>
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
            </div>
            <div class="col-lg-4">
                <div id="RealTimeClose" class="nest">
                    <div class="title-alt">
                        <h6>
                            <span class="fontawesome-resize-horizontal"></span>&nbsp;员工信息</h6>
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
                        <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                            <tr>
                                <td class="tdbg">

                                    <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                        <tr>
                                            <td height="25" width="30%" align="right">用户ID：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:Label ID="lblsta_id" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">用户名：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:Label ID="lblsta_userName" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">注册时间：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:Label ID="lblsta_entryDate" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">密码：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:Label ID="lblsta_passWord" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">婚姻状况：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:Label ID="lblsta_maritalStatus" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">身份证号码：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:Label ID="lblsta_IDNumber" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">家庭住址：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:Label ID="lblsta_homeAddress" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">电话号码：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:Label ID="lblsta_phone" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">真实姓名：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:Label ID="lblsta_name" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">头像ID：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:Label ID="lblsta__pic_id" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">用户类型：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:Label ID="lblsta_tra_id" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">最后登陆：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:Label ID="lblsta_lastLogindate" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">工资：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:Label ID="lblsta_salary" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                    </table>

                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>




</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="JavaScriptHolder" runat="server">
</asp:Content>
