<%@ Page Title="" Language="C#" MasterPageFile="~/StaffSystem/StaffSystem.Master" AutoEventWireup="true" CodeBehind="NewsManage.aspx.cs" Inherits="WalleProject.Web.StaffSystem.NewsManage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="TitleHolder" runat="server">
    新闻管理
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="navHolder" runat="server">
    新闻列表
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentHolder" runat="server">
    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate> 
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                        <b>关键字：</b>
                    </td>
                    <td class="tdbg">
                        <asp:TextBox ID="txtKeyword" runat="server"  ></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="查询"   CssClass="btn-default btn"  OnClick="btnSearch_Click"></asp:Button>

                    </td>
                    <td class="tdbg"></td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" CssClass="table able-halte" AllowPaging="True" Width="100%" CellPadding="3"
                OnPageIndexChanging="gridView_PageIndexChanging"
                BorderWidth="1px" DataKeyNames="new_ID" OnRowDataBound="gridView_RowDataBound"
                AutoGenerateColumns="false" PageSize="10" RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择">
                        <ItemTemplate>
                            <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:BoundField DataField="new_title" HeaderText=" 标题" SortExpression="new_title" ItemStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="new_creatDate" HeaderText="发布时间" SortExpression="new_creatDate" ItemStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="new_cate_id" HeaderText=" 类别" SortExpression="new_cate_id" ItemStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="new_pic_id" HeaderText=" 图片" SortExpression="new_pic_id" ItemStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="new_valid" HeaderText="概述" SortExpression="new_valid" ItemStyle-HorizontalAlign="Center" />

                       <asp:HyperLinkField HeaderText="详情"  ControlStyle-CssClass="btn-default btn form-control"  ControlStyle-Width="50" DataNavigateUrlFields="new_ID" DataNavigateUrlFormatString="NewsManage.aspx?id={0}"
                        Text="详情" />
                    <asp:HyperLinkField HeaderText="编辑" ControlStyle-CssClass="btn-default btn form-control"  ControlStyle-Width="50" DataNavigateUrlFields="new_ID" DataNavigateUrlFormatString="NewsEdit.aspx?id={0}"
                        Text="编辑" />
                    <asp:TemplateField ControlStyle-Width="50" HeaderText="删除" Visible="false">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" ControlStyle-CssClass="btn-default btn form-control"  runat="server" CausesValidation="False" CommandName="Delete"
                                Text="删除"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;"></td>
                    <td align="left">
                        <asp:Button ID="btnDelete" runat="server" CssClass="btn-default btn"  Text="删除" OnClick="btnDelete_Click" />
                    </td>
                </tr>
            </table>




        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btnSearch" />
        </Triggers>
    </asp:UpdatePanel><hr />
    <a href="NewsAdd.aspx" class="btn  btn-info"><h3>添加新闻</h3></a>

</asp:Content>

<asp:Content ID="Content5" ContentPlaceHolderID="NewHolder" runat="server">

    <div class="content-wrap">
        <div class="row">

            <div class="col-lg-12">
                <div id="RealTimeClose" class="nest">
                    <div class="title-alt">
                        <h6>
                            <span class="fontawesome-resize-horizontal"></span>&nbsp;图片信息</h6>
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
                    <div id="RealTime" style="min-height: 296px; padding-top: 10px;" class="body-nest">
                        <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                            <tr>
                                <td class="tdbg">

                                    <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                        <tr>
                                            <td height="25" width="30%" align="right">新闻标题：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:Label ID="lblnew_title" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">发布时间：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:Label ID="lblnew_creatDate" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">新闻类型：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:Label ID="lblnew_cate_id" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">图片ID：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:Label ID="lblnew_pic_id" runat="server"></asp:Label>
                                            </td>
                                        </tr>

                                        <tr>
                                            <td height="25" width="30%" align="right">新闻简述：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:Label ID="lblnew_valid" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="25" width="30%" align="right">新闻编号：</td>
                                            <td height="25" width="*" align="left">
                                                <asp:Label ID="lblnew_ID" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                    </table>

                                </td>
                            </tr>
                        </table>

                        <h2 height="25" width="10%"  align="left">新闻内容：</h2>


                        <p>
                            <asp:Label ID="lblnew_content" runat="server"></asp:Label></p>

                    </div>
                </div>
            </div>

        </div>
    </div>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="JavaScriptHolder" runat="server">
</asp:Content>
