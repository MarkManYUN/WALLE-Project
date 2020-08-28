<%@ Page Title="" Language="C#" MasterPageFile="~/StaffSystem/StaffSystem.Master" AutoEventWireup="true" CodeBehind="WastePhotoAdd.aspx.cs" Inherits="WalleProject.Web.StaffSystem.WastePhotoAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="TitleHolder" runat="server">
    废品确认
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="navHolder" runat="server">
    废品选项
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentHolder" runat="server">
    <div class="row">
        <div class="col-lg-4  ">
            <p>
                废品名：
        <asp:TextBox ID="was_name" CssClass="form-control" runat="server"></asp:TextBox>
            </p>

            <p>废品价格：<asp:TextBox ID="was_price" CssClass="form-control" runat="server"></asp:TextBox></p>

            <p>废品数量：<asp:TextBox ID="was_number" CssClass="form-control" runat="server"></asp:TextBox></p>

            <asp:DropDownList ID="ddl_super" CssClass="form-control" runat="server" AutoPostBack="True" DataSourceID="class1" DataTextField="wastecc_name" DataValueField="wastecc_ID"></asp:DropDownList>

            <asp:SqlDataSource ID="class1" runat="server" ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
                ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>" SelectCommand="SELECT * FROM  t_wastesupercate "></asp:SqlDataSource>

            <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>


            <asp:UpdatePanel ID="Upnl_ddls" runat="server" RenderMode="Inline"
                UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:DropDownList ID="ddl_c" CssClass="form-control" runat="server" DataSourceID="class2"
                        DataTextField="wasc_name" DataValueField="wasc_ID" AutoPostBack="True" OnDataBound="load_d">
                    </asp:DropDownList>


                    <asp:SqlDataSource ID="class2" runat="server" ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
                        ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
                        SelectCommand="SELECT * FROM t_wastecategory  WHERE  wasc_c_id  = ? ">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="ddl_super" Name="wasc_c_id" PropertyName="SelectedValue" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>

                    <asp:DropDownList ID="ddl_d" CssClass="form-control" runat="server" DataSourceID="SqlDataSource1" OnDataBound="checkitems"
                        DataTextField="wastecate_name" DataValueField="wastecate_id">
                    </asp:DropDownList>

                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
                        ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
                        SelectCommand="SELECT * FROM  t_wastesmailcate  WHERE  wastecate_cid  = ? ">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="ddl_c" Name="wastecate_cid" PropertyName="SelectedValue" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>

                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="ddl_super" />
                </Triggers>
            </asp:UpdatePanel>


            <p>废品单位：<asp:TextBox ID="was_valid" runat="server" CssClass="form-control"></asp:TextBox></p>

            <asp:Button ID="btn_Save" runat="server" CssClass="form-control btn btn-info" Text="保存" OnClick="btn_Save_Click" />
            <asp:Button ID="btn_Cancel" runat="server" CssClass="form-control btn btn-default" Text="取消" OnClick="btn_Cancel_Click" />
        </div>
        <div class="col-lg-6">
            <asp:Image ID="Image1"  runat="server" CssClass=" img-rounded" Style="margin :10%;" Width="400px" />

        </div>
    </div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="NewHolder" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="JavaScriptHolder" runat="server">
</asp:Content>
