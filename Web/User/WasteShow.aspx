<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master"  EnableEventValidation="false"  AutoEventWireup="true" CodeBehind="WasteShow.aspx.cs" Inherits="WalleProject.Web.User.WasteShow" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            //购买数量
            var number;
            $(".waste_btn_sub").click(function () {
                number = $("#txt_number").val();
                if (parseInt(number) > 0) {
                    $("#txt_number").val(parseInt(number) - 1);
                }
            });
            $(".waste_btn_add").click(function () {
                number = $("#txt_number").val();
                if (parseInt(number) < parseInt($(".lblcom_number").val())) {
                    $("#txt_number").val(parseInt(number) + 1);
                }
            });
            $(".btn_waste_save").click(function () {
                validate();
            });

        });
        function validate() {
            var comnumber = $("#txt_number");
            var alertnumber = $(".lblcom_number")
            if (comnumber.val().length == 0 && parseInt(comnumber.val()) > parseInt(alertnumber.val() && comnumber.val() == 0)
                && parseInt(alertnumber.val()) <= 0) {
                alert("请输入商品数量不正确！");
                comnumber.focus();
                return false;
            }
        }

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManagerProxy runat="server"></asp:ScriptManagerProxy>
    <asp:TextBox ID="userid" runat="server" Style="display: none;"></asp:TextBox>
    <asp:TextBox CssClass="lblcom_number" ID="lblcom_number" Style="display: none;" runat="server" value="2000000000"></asp:TextBox>

    <div class="templatemo-flex-row flex-content-row templatemo-overflow-hidden">

        <!-- overflow hidden for iPad mini landscape view-->
        <div class="col-1 templatemo-overflow-hidden">
            <div class="templatemo-content-widget white-bg templatemo-overflow-hidden">
                <i class="fa fa-times"></i>
                <div class="templatemo-flex-row flex-content-row" style="height: 100%;">
                    <div class="col-1 col-lg-6 col-md-12">

                        <div style="float: left; max-width: 45%;">
                            <img runat="server" src="#" id="lblwas_pic_ID" style="max-width: 80%;" />
                            <div class="templatemo-content-widget blue-bg" style="background-color: #808080;">
                                <table cellspacing="0" cellpadding="0" width="100%" border="0">

                                    <tr>
                                        <td height="25" width="30%" align="right">资源编号：</td>
                                        <td height="25" width="*" align="left">WL2018042500
                                            <asp:Label ID="lblwas_ID" runat="server"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td height="25" width="30%" align="right">资源名：</td>
                                        <td height="25" width="*" align="left">
                                            <asp:Label ID="lblwas_name" runat="server"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>

                                        <td height="25" width="30%" align="right">市场回收价格：</td>
                                        <td height="25" width="*" align="left">
                                            <h1 style="color: #ff0000;">
                                                <asp:Label ID="lblwas_price" runat="server"></asp:Label>
                                                <small style="color: antiquewhite;">元/ 
                                                                <asp:Label ID="lblwas_valid" runat="server"></asp:Label>
                                                </small></h1>
                                        </td>
                                    </tr>
                                    <tr>

                                        <td height="25" width="30%" align="right">系统回收价格：</td>
                                        <td height="25" width="*" align="left">
                                            <h3 style="color: aquamarine;"><del>
                                                <asp:Label ID="lblwas_price2" runat="server"></asp:Label></del>
                                                <small style="color: antiquewhite;">元/ 
                                                                <asp:Label ID="lblwas_valid2" runat="server"></asp:Label></small></h3>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td height="25" width="30%" align="right">二级分类：</td>
                                        <td height="25" width="*" align="left">
                                            <asp:Label ID="lblwas_recoverable" runat="server"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td height="25" width="30%" align="right">已收数量：</td>
                                        <td height="25" width="*" align="left">
                                            <asp:Label ID="lblwas_number" runat="server"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td height="25" width="30%" align="right">类型ID：</td>
                                        <td height="25" width="*" align="left">
                                            <asp:Label ID="lblwas_cate_ID" runat="server"></asp:Label>
                                        </td>
                                    </tr>

                                </table>
                            </div>
                        </div>

                        <div style="float: left; width: 50%;">


                            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">

                                <tr>
                                    <td>
                                        <div class="col-lg-6 col-md-6 form-group" style="float: left;">
                                            <div class="margin-right-15 templatemo-inline-block">
                                                <input type="radio" checked="true" runat="server" name="radio" id="r6" value="" />
                                                <label for="r6" class="font-weight-400"><span></span>使用已存地址</label>
                                            </div>

                                            <div class="row form-group">
                                                <div class="col-lg-12 form-group">
                                                    <div class="margin-right-15 templatemo-inline-block">
                                                        <input type="radio" runat="server" name="radio" id="r4" value="" />
                                                        <label for="r4" class="font-weight-400"><span></span>使用新地址</label>
                                                    </div>

                                                </div>
                                            </div>
                                            历史： 
                                            <asp:DropDownList class="form-control" Width="150%" AutoPostBack="true"
                                                Style="overflow-y: scroll;" ID="ListBox1"
                                                DataSourceID="SqlDataSource1" DataTextField="add_address"
                                                DataValueField="add_ID" runat="server">
                                            </asp:DropDownList>
                                            <asp:SqlDataSource ID="SqlDataSource1" runat="server"
                                                ConnectionString="<%$ ConnectionStrings:walledbConnectionString %>"
                                                ProviderName="<%$ ConnectionStrings:walledbConnectionString.ProviderName %>"
                                                SelectCommand="SELECT * FROM  t_address  WHERE ( add_u_ID  = ?) ORDER BY  add_default  DESC">
                                                <SelectParameters>
                                                    <asp:ControlParameter ControlID="userid" Name="add_u_ID" PropertyName="Text" Type="Int32" />
                                                </SelectParameters>
                                            </asp:SqlDataSource>


                                            新地址：  
                                            <div class="form-group">
                                                <div class="input-group">
                                                    <asp:DropDownList ID="ddl_p" class="form-control" Width="150%" runat="server" DataSourceID="ads_p"
                                                        DataTextField="p_name" DataValueField="p_id" AutoPostBack="True">
                                                    </asp:DropDownList>
                                                    <asp:AccessDataSource ID="ads_p" runat="server" DataFile="~/DATA/China.mdb"
                                                        SelectCommand="SELECT * FROM [T_Province]" />


                                                    <asp:UpdatePanel ID="Upnl_ddls" runat="server" RenderMode="Inline"
                                                        UpdateMode="Conditional">
                                                        <ContentTemplate>

                                                            <asp:DropDownList ID="ddl_c" Width="150%" class="form-control" runat="server" DataSourceID="ads_c"
                                                                DataTextField="c_name" DataValueField="c_id" AutoPostBack="True" OnDataBound="load_d">
                                                            </asp:DropDownList>
                                                            <asp:AccessDataSource ID="ads_c" runat="server" DataFile="../Data/China.mdb"
                                                                SelectCommand="SELECT [c_name], [c_id] FROM [T_City] WHERE ([c_pid] = ?)">
                                                                <SelectParameters>
                                                                    <asp:ControlParameter ControlID="ddl_p" Name="c_pid"
                                                                        PropertyName="SelectedValue" Type="Int32" />
                                                                </SelectParameters>
                                                            </asp:AccessDataSource>



                                                            <asp:DropDownList ID="ddl_d" Width="150%" class="form-control" runat="server" DataSourceID="ads_d" OnDataBound="checkitems"
                                                                DataTextField="d_name" DataValueField="d_id">
                                                            </asp:DropDownList>
                                                            <asp:AccessDataSource ID="ads_d" runat="server" DataFile="../Data/China.mdb"
                                                                SelectCommand="SELECT [d_id], [d_name] FROM [T_District] WHERE ([d_cid] = ?)">
                                                                <SelectParameters>
                                                                    <asp:ControlParameter ControlID="ddl_c" Name="d_cid"
                                                                        PropertyName="SelectedValue" Type="Int32" />
                                                                </SelectParameters>
                                                            </asp:AccessDataSource>


                                                        </ContentTemplate>
                                                        <Triggers>
                                                            <asp:AsyncPostBackTrigger ControlID="ddl_p" />
                                                        </Triggers>
                                                    </asp:UpdatePanel>

                                                    <asp:TextBox type="text" class="form-control" Width="150%" ID="input_Address" runat="server"
                                                        placeholder="详细地址" />

                                                </div>
                                                <div class="form-group">
                                                    <div class="form-group">
                                                        <asp:Label ID="lblMsg" runat="server" BackColor="Transparent" ForeColor="Red"></asp:Label>
                                                    </div>
                                                    <div class="input-group">
                                                        <div class="input-group-addon"><i class="fa fa-user fa-fw"></i></div>
                                                        <asp:TextBox type="text" class="form-control" ID="input_userName" runat="server"
                                                            placeholder="联系人" />
                                                    </div>
                                                </div>
                                                <div class="form-group">
                                                    <div class="input-group">
                                                        <div class="input-group-addon"><i class="fa fa-user fa-fw"></i></div>
                                                        <asp:TextBox type="text" class="form-control" ID="input_phone" runat="server"
                                                            placeholder="联系电话" />

                                                    </div>
                                                </div>
                                            </div>



                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="">
                                        <span class="addsub" style="float: left; margin: 5%;">
                                            <label class="control-label templatemo-block" style="float: left; margin-right: 20%;">出售数量</label>
                                            <img src="../img/sub.png" class="waste_btn_sub" style="float: left;" />
                                            <input type="text" id="txt_number" style="max-width: 20%; float: left;" class="form-control" runat="server" value="1" />
                                            <img src="../img/add.png" class="waste_btn_add" style="float: left;" />
                                        </span>
                                        <br />
                                        <br />
                                        <span class="" style="float: left;">
                                            <asp:Button ID="btnSave" CssClass="btn_waste_save templatemo-blue-button" runat="server" Text="下单"
                                                OnClick="btnSave_Click"  ></asp:Button>
                                            <asp:Button ID="btnCancle" runat="server" Text="取消"
                                                OnClick="btnCancle_Click" class=" templatemo-white-button"></asp:Button>
                                        </span></td>
                                </tr>
                            </table>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footJS" runat="server">
</asp:Content>
