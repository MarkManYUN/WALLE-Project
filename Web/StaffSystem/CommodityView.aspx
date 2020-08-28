<%@ Page Title="" Language="C#" MasterPageFile="~/StaffSystem/StaffSystem.Master" AutoEventWireup="true" CodeBehind="CommodityView.aspx.cs" Inherits="WalleProject.Web.StaffSystem.CommodityView" %>

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
    商品管理
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="navHolder" runat="server">
    所有商品列表
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentHolder" runat="server">
    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>

    <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" ItemPlaceholderID="holder" DataKeyNames="com_ID" InsertItemPosition="LastItem">
        <LayoutTemplate>
            <spen runat="server" id="holder"></spen>
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
                                    <asp:Button ID="btn_edit" runat="server" Text="编辑" CssClass="form-control btn btn-info"
                                        CommandName="edit" /><br />
                                    <asp:Button ID="btn_delmark" runat="server" Text="删除" CssClass="form-control btn  btn-default"
                                        OnCommand="delmark"
                                        CommandArgument='<%#Eval("com_ID") %>'
                                        OnClick="btn_delmark_Click"
                                        OnClientClick="return confirm('确定删除?')" />
                                </td>
                                <td class="armada-devider">
                                    <p>商品名：<asp:Label ID="Label1" runat="server" Text='<%#Eval("com_name")%>'></asp:Label></p>
                                    <p>数量：<asp:Label ID="Label2" runat="server" Text='<%#Eval("com_number")%>'></asp:Label></p>
                                    <p>生产日期：<asp:Label ID="Label3" runat="server" Text='<%#Eval("com_productDate")%>'></asp:Label></p>
                                    <p>
                                        货架号：<asp:Label ID="Label4" runat="server" Text='<%#Eval("com_strageID")%>'></asp:Label>
                                    </p>
                                    <p>
                                        价格：<asp:Label ID="Label13" runat="server" Text='<%#Eval("com_pri_ID")%>'></asp:Label>
                                    </p>
                                </td>

                                <td class="armada-devider">最低预警值：<asp:Label ID="Label5" runat="server" Text='<%#Eval("com_alertNumber")%>'></asp:Label>
                                    <p>入库日期：<asp:Label ID="Label6" runat="server" Text='<%#Eval("com_date")%>'></asp:Label></p>
                                    <p>
                                        兑换积分：
                    <asp:Label ID="Label7" runat="server" Text='<%#Eval("com_conversionInt")%>'></asp:Label>
                                    </p>
                                    <p>
                                        商品单位：
                    <asp:Label ID="Label8" runat="server" Text='<%#Eval("com_valid")%>'></asp:Label>
                                    </p>
                                    <p>
                                        商品类别：
                    <asp:Label ID="Label9" runat="server" Text='<%#Eval("comc_name")%>'></asp:Label>
                                    </p>
                                    <p>
                                        商品库存：
                    <asp:Label ID="Label10" runat="server" Text='<%#Eval("com_number")%>'></asp:Label>
                                    </p>
                                    <p>
                                        货架号：
                    <asp:Label ID="Label11" runat="server" Text='<%#Eval("com_strageID")%>'></asp:Label>
                                    </p>
                                    <p>
                                        商品预警值：
                    <asp:Label ID="Label12" runat="server" Text='<%#Eval("com_alertNumber")%>'></asp:Label>
                                    </p>
                                </td>
                                <td class="armada-devider">
                                    <img src='<%#Eval("pic_valid")%>' class=" " runat="server"
                                        data-src="holder.js/64x64"
                                        alt="64x64"
                                        style="width: 200px; height: 150px;" title='<%#Eval("com_name")%>' />
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
                                        <asp:Button ID="btn_insert" runat="server" CssClass="form-control btn btn-info"
                                            Text="插入记录"
                                            CommandName="insert"
                                            ValidationGroup="v_insert" />
                                        <br />
                                        <asp:Button ID="btn_i_cancel" runat="server" CssClass="form-control btn btn-info"
                                            Text="取消添加"
                                            CommandName="cancel" />
                                    </td>
                                    <td class="armada-devider">

                                        <asp:ListBox ID="lb_i_img" runat="server"
                                            DataSourceID="ADS_IMG" Width="200px"
                                            DataTextField="pic_valid" DataValueField="pic_ID"
                                            SelectedValue='<%#Bind("com_pic_ID") %>'
                                            Rows="10" ClientIDMode="Static"></asp:ListBox>
                                    </td>
                                    <td class="armada-devider">
                                        <img alt="商品名" class="" id="img_i_mo" data-src="holder.js/64x64"
                                            style="width: 200px; height: 200px;" src="../_commodityImage/74.jpg" />
                                    </td>
                                    <td class="armada-devider">
                                        <!-- 信息 -->

                                        <p>
                                            商品名称: 
                                <asp:TextBox ID="txt_i_name" CssClass="form-control"
                                    runat="server"
                                    Text='<%#Bind("com_name") %>' />
                                            <asp:RequiredFieldValidator
                                                ID="r_i_name" runat="server"
                                                ErrorMessage="必须输入产品名称!"
                                                CssClass="warn"
                                                ValidationGroup="v_insert"
                                                SetFocusOnError="true"
                                                ControlToValidate="txt_i_name" />
                                        </p>

                                        <p>
                                            类别名称: 
                                <asp:DropDownList ID="ddl_i_se" runat="server" DataSourceID="ads_ddl_se" CssClass="form-control"
                                    DataTextField="comc_name" DataValueField="comc_ID"
                                    SelectedValue='<%#Bind("com_comc_ID") %>'>
                                </asp:DropDownList>
                                        </p>

                                        <p>
                                            商品价格: 
                              
                                           <asp:TextBox ID="txt_i_price" CssClass="form-control" runat="server" Text='<%#Bind("com_pri_ID") %>'></asp:TextBox>

                                        </p>

                                        <p>
                                            单位:
                                                        <asp:TextBox ID="chk_i_enable" CssClass="form-control" runat="server" Text='<%#Bind("com_valid") %>'></asp:TextBox>
                                        </p>


                                    </td>
                                    <td class="armada-devider">
                                        <p>
                                            库存: 
                                <asp:TextBox ID="txt_i_number" CssClass="form-control"
                                    runat="server"
                                    Text='<%#Bind("com_number") %>' />
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2"
                                                runat="server" ErrorMessage="请输入数值!"
                                                ControlToValidate="txt_i_number"
                                                CssClass="warn"
                                                ValidationExpression="^[0-9]*$"
                                                ValidationGroup="v_insert" />

                                        </p>
                                        <p>
                                            货架号: 
                                <asp:TextBox ID="txt_i_strageID" CssClass="form-control"
                                    runat="server"
                                    Text='<%#Bind("com_strageID") %>' />
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator3"
                                                runat="server" ErrorMessage="请输入数值!"
                                                ControlToValidate="txt_i_strageID"
                                                CssClass="warn"
                                                ValidationExpression="^[0-9]*$"
                                                ValidationGroup="v_insert" />

                                        </p>
                                        <p>
                                            预警值: 
                                <asp:TextBox ID="txt_i_alertNumber" CssClass="form-control"
                                    runat="server"
                                    Text='<%#Bind("com_alertNumber") %>' />
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
                                                runat="server" ErrorMessage="请输入数值!"
                                                ControlToValidate="txt_i_alertNumber"
                                                CssClass="warn"
                                                ValidationExpression="^[0-9]*$"
                                                ValidationGroup="v_insert" />

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
                                        <asp:Button ID="btn_update" runat="server" CssClass="form-control btn btn-info"
                                            Text="保存修改"
                                            CommandName="UPDATE"
                                            ValidationGroup="v_update" />
                                        <br />
                                        <asp:Button ID="btn_e_cancel" runat="server" CssClass="form-control btn btn-info"
                                            Text="取消修改"
                                            CommandName="cancel" />
                                    </td>
                                    <td class="armada-devider">
                                        <asp:ListBox ID="lb_e_img" runat="server" Width="200px"
                                            DataSourceID="ADS_IMG"
                                            DataTextField="pic_valid" DataValueField="pic_ID"
                                            SelectedValue='<%#Bind("com_pic_ID") %>'
                                            Rows="15" ClientIDMode="Static"></asp:ListBox>

                                    </td>
                                    <td class="armada-devider">
                                        <img alt="" id="img_e_mo" data-src="holder.js/64x64"
                                            style="width: 200px; height: 200px;" src='<%#Eval("pic_valid")%>' />

                                    </td>
                                    <td class="armada-devider">
                                        <div class="Info">
                                            <p>
                                                商品名称:
                        <asp:TextBox ID="txt_e_name" CssClass="form-control"
                            runat="server"
                            Text='<%#Bind("com_name") %>' />
                                                <asp:RequiredFieldValidator
                                                    ID="r_e_name" runat="server"
                                                    ErrorMessage="必须输入商品名称!"
                                                    CssClass="warn"
                                                    ValidationGroup="v_update"
                                                    SetFocusOnError="true"
                                                    ControlToValidate="txt_e_name" />
                                            </p>
                                        </div>
                                        <p>
                                            类别名称:
                        <asp:DropDownList ID="ddl_e_se" runat="server" DataSourceID="ads_ddl_se" CssClass="form-control"
                            DataTextField="comc_name" DataValueField="comc_ID"
                            SelectedValue='<%#Bind("com_comc_ID") %>'>
                        </asp:DropDownList>
                                        </p>

                                        <p>
                                            商品价格:
                        
                          <asp:TextBox ID="txt_e_price" CssClass="form-control" runat="server" Text='<%#Bind("com_pri_ID") %>'></asp:TextBox>

                                        </p>

                                        <p>
                                            单位:
                              
                          <asp:TextBox ID="chk_e_enable" CssClass="form-control" runat="server" Text='<%#Bind("com_valid") %>'></asp:TextBox>
                                        </p>
                                    </td>
                                    <td class="armada-devider">
                                        <p>
                                            库存:
                                            <asp:TextBox ID="txt_e_order" CssClass="form-control"
                                                runat="server"
                                                Text='<%#Bind("com_number") %>' />
                                            <asp:RegularExpressionValidator ID="RegularExpresseionValidator2txt_e_order"
                                                runat="server" ErrorMessage="请输入数值!"
                                                ControlToValidate="txt_e_order"
                                                CssClass="warn"
                                                ValidationExpression="^[0-9]*$"
                                                ValidationGroup="v_update" />
                                        </p>
                                        <p>
                                            货架号:
                        <asp:TextBox ID="txt_e_strageID" CssClass="form-control"
                            runat="server"
                            Text='<%#Bind("com_strageID") %>' />
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator3txt_e_strageID"
                                                runat="server" ErrorMessage="请输入数值!"
                                                ControlToValidate="txt_e_strageID"
                                                CssClass="warn"
                                                ValidationExpression="^[0-9]*$"
                                                ValidationGroup="v_update" />

                                        </p>
                                        <p>
                                            预警值:
                        <asp:TextBox ID="txt_e_alertNumber" CssClass="form-control"
                            runat="server"
                            Text='<%#Bind("com_alertNumber") %>' />
                                            <asp:RegularExpressionValidator ID="RegularExdpressionValidator1txt_e_alertNumber"
                                                runat="server" ErrorMessage="请输入数值!"
                                                ControlToValidate="txt_e_alertNumber"
                                                CssClass="warn"
                                                ValidationExpression="^[0-9]*$"
                                                ValidationGroup="v_update" /> 
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
            <asp:Parameter DefaultValue="3" Name="pic_cate_ID" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>

    <asp:SqlDataSource ID="ads_ddl_se"
        runat="server" ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
        ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
        SelectCommand="SELECT * FROM  t_commoditycategory "></asp:SqlDataSource>


    <asp:SqlDataSource ID="SqlDataSource1" runat="server"
        ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
        ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
        SelectCommand="select * from t_commodity LEFT  JOIN t_picture on t_picture.pic_ID =t_commodity.com_pic_ID
 LEFT JOIN t_commoditycategory on t_commoditycategory.comc_ID=t_commodity.com_comc_ID
LEFT JOIN t_pricerecord on t_pricerecord.pri_ID =t_commodity.com_pri_ID"
        DeleteCommand="DELETE FROM  t_commodity  WHERE  com_ID  = ?"
        InsertCommand="INSERT INTO  t_commodity  (  com_name ,  com_productDate ,  com_number ,  com_strageID ,  com_alertNumber , 
                com_pic_ID ,  com_date ,  com_pri_ID ,   com_comc_ID ,  com_valid ) 
                VALUES (?, ?, ?, ?, ?, ?, NOW(), ?, ?, ?)"
        UpdateCommand="UPDATE  t_commodity  SET  com_name = ?,  com_productDate = ?,  com_number  = ?,  com_strageID  = ?, 
                 com_alertNumber = ?,  com_pic_ID  = ?,com_date=NOW(),  com_pri_ID  = ?,  com_conversionInt = ?,  com_comc_ID  = ?,
                 com_valid  = ? WHERE  com_ID  = ?">
        <DeleteParameters>
            <asp:Parameter Name="com_ID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>

            <asp:Parameter Name="com_name" Type="String" />
            <asp:Parameter Name="com_productDate" Type="DateTime" />
            <asp:Parameter Name="com_number" Type="Int32" />
            <asp:Parameter Name="com_strageID" Type="String" />
            <asp:Parameter Name="com_alertNumber" Type="Int32" />
            <asp:Parameter Name="com_pic_ID" Type="Int32" />
            <asp:Parameter Name="com_pri_ID" Type="Decimal" />
            <asp:Parameter Name="com_conversionInt" Type="Int32" />
            <asp:Parameter Name="com_comc_ID" Type="Int32" />
            <asp:Parameter Name="com_valid" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="com_name" Type="String" />
            <asp:Parameter Name="com_productDate" Type="DateTime" />
            <asp:Parameter Name="com_number" Type="Int32" />
            <asp:Parameter Name="com_strageID" Type="String" />
            <asp:Parameter Name="com_alertNumber" Type="Int32" />
            <asp:Parameter Name="com_pic_ID" Type="Int32" />

            <asp:Parameter Name="com_pri_ID" Type="Decimal" />
            <asp:Parameter Name="com_conversionInt" Type="Int32" />
            <asp:Parameter Name="com_comc_ID" Type="Int32" />
            <asp:Parameter Name="com_valid" Type="String" />
            <asp:Parameter Name="com_ID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>


</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="NewHolder" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="JavaScriptHolder" runat="server">
</asp:Content>
