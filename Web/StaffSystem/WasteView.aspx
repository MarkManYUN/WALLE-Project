<%@ Page Title="" Language="C#" MasterPageFile="~/StaffSystem/StaffSystem.Master" AutoEventWireup="true" CodeBehind="WasteView.aspx.cs" Inherits="WalleProject.Web.StaffSystem.WasteView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="assets/js/jquery.js"></script>
    <script src="assets/js/jquery.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#lb_i_img").change(function () {
                $("#img_i_mo").attr("src", $(this).find("option:selected").text());
            });

            $("#lb_e_img").change(function () {
                $("#img_e_mo").attr("src", $(this).find("option:selected").text());
            });
        });
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="TitleHolder" runat="server">
    废品管理
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="navHolder">废品所有列表</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentHolder" runat="server">
    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>

    <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" ItemPlaceholderID="holder" DataKeyNames="was_ID" InsertItemPosition="LastItem">
        <LayoutTemplate>
            <spen runat="server" id="holder"></spen>
        </LayoutTemplate>
        <ItemTemplate>
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
                                    <asp:Button CssClass="btn btn-info form-control" ID="btn_edit" runat="server" Text="编辑"
                                        CommandName="edit" /><br />
                                    <asp:Button ID="btn_delmark" CssClass="btn btn-danger form-control" runat="server" Text="删除"
                                        OnCommand="delmark"
                                        CommandArgument='<%#Eval("was_ID") %>'
                                        OnClientClick="return confirm('确定删除?')" />
                                </td>
                                <td class="armada-devider">
                                    <p>废品名：<asp:Label ID="Label1" runat="server" Text='<%#Eval("was_name")%>'></asp:Label></p> 
                                    <p>回收价格：<asp:Label ID="price" runat="server" Text='<%#Eval("was_price")%>'></asp:Label>元</p>
                                </td>
                                <td class="armada-devider">单位：
                    <asp:Label ID="Label8" runat="server" Text='<%#Eval("was_valid")%>'></asp:Label>
                                    </p>
                                    <p>
                                        废品二类别：
                    <asp:Label ID="Label9" runat="server" Text='<%#Eval("wasc_name")%>'></asp:Label>
                                    </p> <p>
                                        废品三类别：
                    <asp:Label ID="Label3" runat="server" Text='<%#Eval("wastecate_name")%>'></asp:Label>
                                    </p>
                                </td>
                                <td class="armada-devider">
                                    <img src='<%#Eval("pic_valid")%>' class=" " runat="server"
                                        data-src="holder.js/64x64"
                                        alt="64x64"
                                        style="width: 200px; height: 150px;" title='<%#Eval("was_name")%>' />

                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
        </ItemTemplate>



        <ItemSeparatorTemplate>
        </ItemSeparatorTemplate>



        <InsertItemTemplate>
            <div class="Insert">
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
                                        <!-- 空白页-->
                                        <asp:Button ID="btn_insert" runat="server"  CssClass="form-control btn btn-info"
                                            Text="插入记录"
                                            CommandName="insert"
                                            ValidationGroup="v_insert" />
                                        <br />
                                        <asp:Button ID="btn_i_cancel" runat="server"  CssClass="form-control btn  btn-default"
                                            Text="取消添加"
                                            CommandName="cancel" />
                                    </td>
                                    <td class="armada-devider">

                                        <asp:ListBox ID="lb_i_img" runat="server"  CssClass=" list  list-group-item-info media-list"  
                                            DataSourceID="ADS_IMG"
                                            DataTextField="pic_valid" DataValueField="pic_ID"
                                            SelectedValue='<%#Bind("was_pic_ID") %>'
                                            Rows="10" ClientIDMode="Static"></asp:ListBox>
                                    </td>
                                    <td class="armada-devider">
                                        <img alt="废品名" class="" id="img_i_mo" data-src="holder.js/64x64"
                                            style="width: 200px; height: 200px;" src="../_wasteImage/8.jpg" />
                                    </td>
                                    <td class="armada-devider">
                                        <!-- 信息 -->

                                        <p>
                                            废品名称: 
                                <asp:TextBox ID="txt_i_name"
                                    runat="server"   CssClass="form-control"
                                    Text='<%#Bind("was_name") %>' />
                                            <asp:RequiredFieldValidator
                                                ID="r_i_name" runat="server"
                                                ErrorMessage="必须输入产品名称!"
                                                CssClass="warn"
                                                ValidationGroup="v_insert"
                                                SetFocusOnError="true"
                                                ControlToValidate="txt_i_name" />
                                        </p>
                                         
                                        <p>
                                            二级类：   
                                            <asp:DropDownList ID="ddl_c" runat="server" DataSourceID="class2"
                                                SelectedValue='<%#Bind("was_recoverable") %>'   CssClass="form-control"
                                                DataTextField="wasc_name" DataValueField="wasc_ID">
                                            </asp:DropDownList>


                                            <asp:SqlDataSource ID="class2" runat="server"
                                                ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
                                                ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
                                                SelectCommand="SELECT * FROM t_wastecategory  "></asp:SqlDataSource>
                                        </p>
                                        <p>
                                            三级类：
                                            <asp:DropDownList ID="ddl_d" runat="server" DataSourceID="SqlDataSource1ddl_d"  CssClass="form-control"
                                                SelectedValue='<%#Bind("was_cate_ID") %>'
                                                DataTextField="wastecate_name" DataValueField="wastecate_id">
                                            </asp:DropDownList>

                                            <asp:SqlDataSource ID="SqlDataSource1ddl_d" runat="server"  
                                                ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
                                                ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
                                                SelectCommand="SELECT * FROM  t_wastesmailcate   "></asp:SqlDataSource>

                                        </p>
                                        <p>
                                            废品价格: 
                           
                                          <asp:TextBox ID="TextBox1" runat="server"  CssClass="form-control" Text='<%#Bind("was_price") %>'></asp:TextBox>

                                        </p>

                                        <p>
                                            单位:
                                                        <asp:TextBox ID="chk_e_enable"  CssClass="form-control" runat="server" Text='<%#Bind("was_valid") %>'></asp:TextBox>
                                        </p>


                                    </td>

                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </InsertItemTemplate>

        <EditItemTemplate>

            <div class="Edit">
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
                                        <asp:Button ID="btn_update" runat="server" CssClass=" form-control btn  btn-info"
                                            Text="保存修改"
                                            CommandName="UPDATE"
                                            ValidationGroup="v_update" />
                                        <br />
                                        <asp:Button ID="btn_e_cancel"  CssClass="btn btn-danger form-control" runat="server"
                                            Text="取消修改"
                                            CommandName="cancel" />
                                    </td>
                                    <td class="armada-devider">
                                        <asp:ListBox ID="lb_e_img" runat="server"   CssClass=" list  list-group-item-info media-list"  
                                            DataSourceID="ADS_IMG" Width="300"
                                            DataTextField="pic_valid" DataValueField="pic_ID"
                                            SelectedValue='<%#Bind("was_pic_ID") %>'
                                            Rows="7" ClientIDMode="Static"></asp:ListBox></td>
                                    <td class="armada-devider">
                                        <img alt="" id="img_e_mo" data-src="holder.js/64x64"
                                            style="width: 200px; height: 200px;" src='<%#Eval("pic_valid")%>' />
                                    </td>
                                    <td class="armada-devider">
                                        <div class="Info">
                                            <p>
                                                废品名称:
                        <asp:TextBox ID="txt_e_name" CssClass="form-control"
                            runat="server"
                            Text='<%#Bind("was_name") %>' />
                                                <asp:RequiredFieldValidator
                                                    ID="r_e_name" runat="server"
                                                    ErrorMessage="必须输入废品名称!"
                                                    CssClass="warn"
                                                    ValidationGroup="v_update"
                                                    SetFocusOnError="true"
                                                    ControlToValidate="txt_e_name" />
                                            </p>

                                            <p>
                                                二级类：   
                                            <asp:DropDownList ID="ddl_c" runat="server" DataSourceID="class2"  CssClass="form-control"
                                                SelectedValue='<%#Bind("was_recoverable") %>'
                                                DataTextField="wasc_name" DataValueField="wasc_ID">
                                            </asp:DropDownList>


                                                <asp:SqlDataSource ID="class2" runat="server"
                                                    ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
                                                    ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
                                                    SelectCommand="SELECT * FROM t_wastecategory  "></asp:SqlDataSource>
                                            </p>
                                            <p>
                                                三级类：
                                            <asp:DropDownList ID="ddl_d" runat="server" DataSourceID="SqlDataSource1ddl_d"  CssClass="form-control"
                                                SelectedValue='<%#Bind("was_cate_ID") %>'
                                                DataTextField="wastecate_name" DataValueField="wastecate_id">
                                            </asp:DropDownList>

                                                <asp:SqlDataSource ID="SqlDataSource1ddl_d" runat="server"
                                                    ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
                                                    ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
                                                    SelectCommand="SELECT * FROM  t_wastesmailcate   "></asp:SqlDataSource>

                                            </p>

                                            <p>
                                                废品价格:
                                                        <asp:TextBox ID="TextBox1" runat="server"  CssClass="form-control" Text='<%#Bind("was_price") %>'></asp:TextBox>
                                            </p>

                                            <p>
                                                单位:
                                                        <asp:TextBox ID="chk_e_enable"  CssClass=" form-control" runat="server" Text='<%#Bind("was_valid") %>'></asp:TextBox>
                                            </p>
                                    </td>

                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </EditItemTemplate>

    </asp:ListView>
    <asp:SqlDataSource ID="ADS_IMG"
        runat="server" ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
        ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
        SelectCommand="SELECT * FROM  t_picture  WHERE  pic_cate_ID  = ? ">
        <SelectParameters>
            <asp:Parameter DefaultValue="4" Name="pic_cate_ID" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>

    <asp:SqlDataSource ID="ads_ddl_se"
        runat="server" ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
        ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
        SelectCommand="select wasc_name,wasc_ID,wasc_c_id from t_wastecategory "></asp:SqlDataSource>


    <asp:SqlDataSource ID="SqlDataSource1" runat="server"
        ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
        ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
        SelectCommand="SELECT * FROM t_waste 
LEFT JOIN t_wastecategory on t_waste.was_cate_ID=t_wastecategory.wasc_ID
LEFT JOIN t_picture on t_waste.was_pic_ID =t_picture.pic_ID 
LEFT JOIN t_wastesmailcate on t_wastesmailcate.wastecate_id=t_waste.was_recoverable "
        DeleteCommand="DELETE FROM t_waste WHERE was_ID = ?"
        InsertCommand="INSERT INTO t_waste (was_pic_ID,   was_name, was_price, was_recoverable, was_number, was_cate_ID, was_valid) VALUES ( ?, ?, ?, ?, ?, ?, ?)"
        UpdateCommand="UPDATE t_waste SET was_pic_ID = ?, was_name = ?, was_price = ?, was_recoverable = ?, was_number = ?, was_cate_ID = ?, was_valid = ? WHERE was_ID = ?">
        <DeleteParameters>
            <asp:Parameter Name="was_ID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="was_pic_ID" Type="Int32" />

            <asp:Parameter Name="was_name" Type="String" />
            <asp:Parameter Name="was_price" Type="Decimal" />
            <asp:Parameter Name="was_recoverable" Type="Int32" />
            <asp:Parameter Name="was_number" Type="Int32" />
            <asp:Parameter Name="was_cate_ID" Type="Int32" />
            <asp:Parameter Name="was_valid" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="was_pic_ID" Type="Int32" />
            <asp:Parameter Name="was_name" Type="String" />
            <asp:Parameter Name="was_price" Type="Decimal" />
            <asp:Parameter Name="was_recoverable" Type="Int32" />
            <asp:Parameter Name="was_number" Type="Int32" />
            <asp:Parameter Name="was_cate_ID" Type="Int32" />
            <asp:Parameter Name="was_valid" Type="String" />
            <asp:Parameter Name="was_ID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <%--分页控件 --%>
    <div class="divPager">
        <asp:DataPager ID="DataPager1" runat="server" PagedControlID="ListView1" PageSize="7">
            <Fields>
                <asp:NextPreviousPagerField ShowFirstPageButton="true" ShowNextPageButton="false" />
                <asp:NumericPagerField />
                <asp:NextPreviousPagerField ShowLastPageButton="true" ShowPreviousPageButton="false" />
            </Fields>
        </asp:DataPager>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="NewHolder" runat="server"></asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="JavaScriptHolder" runat="server">
</asp:Content>
