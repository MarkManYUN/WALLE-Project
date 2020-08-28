<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SalaryAdd.aspx.cs" Inherits="WalleProject.Web.StaffSystem.SalaryAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="" />
    <meta name="author" content="" />

    <link rel="stylesheet" href="assets/css/bootstrap.css" />

    <link rel="shortcut icon" href="assets/ico/minus.png" />

</head>
<body>
    <form id="form1" runat="server">

        <div class="content-wrap" style="margin-right: 20%;">
            <div class="row">
                <div class="col-lg-8">
                    <div id="RealTimeClose" class="nest">
                        <div class="title-alt">

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
                        <div id="RealTime" style="min-height: 296px; width: 100%;" class="body-nest">

                            <div class="form-horizontal " role="form">
                                <div class="form-group">
                                    <label class="control-label">员工编号：</label>
                                    <div class="col-lg-8">
                                        <asp:Label ID="lblsal_staff" runat="server"></asp:Label>
                                    </div>
                                    <label class="control-label" style="display:none;">工资表编号：</label>
                                    <div class="col-lg-8">
                                        <asp:Label ID="lblsal_ID" runat="server"></asp:Label>

                                    </div>
                                    <label class="col-lg-3 control-label">奖金：</label>
                                    <div class="col-lg-8">
                                        <asp:TextBox class="form-control" ID="txtsal_bonusM" runat="server" Width="200px"></asp:TextBox>
                                    </div>
                                    <label class="col-lg-3 control-label">扣除：</label>
                                    <div class="col-lg-8">
                                        <asp:TextBox ID="txtsal_deductM" class="form-control" runat="server" Width="200px"></asp:TextBox>

                                    </div>
                                    <label class="col-lg-3 control-label">当前工资：</label>
                                    <div class="col-lg-8">
                                        <asp:TextBox ID="txtsal_totalM" ReadOnly="true" class="form-control" runat="server" Width="200px"></asp:TextBox>

                                    </div>
                                    <label class="col-lg-3 control-label">工资基础增长：</label>
                                    <div class="col-lg-8">

                                        <asp:TextBox ID="txtsal_incrementM" class="form-control" runat="server" Width="200px"></asp:TextBox>

                                    </div>
                                    <label class="col-lg-3 control-label">请假天数：</label>
                                    <div class="col-lg-8">
                                        <asp:TextBox ID="txtSal_leaveDay" class="form-control" runat="server" Width="200px"></asp:TextBox>

                                    </div>
                                    <label class="col-lg-3 control-label">旷工天数：</label>
                                    <div class="col-lg-8">
                                        <asp:TextBox ID="txtSal_absenteeismDay" class="form-control" runat="server" Width="200px"></asp:TextBox>

                                    </div>
                                </div>



                                <div class="form-group">
                                    <label class="col-lg-3 control-label">描述：</label>
                                    <div class="col-lg-8">
                                        <textarea placeholder="内容" id="txtsal_describe" readonly="readonly" width="200px" runat="server" rows="5" class="form-update"></textarea>
                                    </div>

                                </div>
                                <div class="form-group">
                                    <label class="col-md-3 control-label"></label>
                                    <div class="col-md-8">
                                        <asp:Button ID="btnSave" runat="server" Text="保存"
                                            OnClick="btnSave_Click" class="inputbutton btn btn-primary"></asp:Button>
                                        <asp:Button ID="btnCancle" runat="server" Text="取消"
                                            OnClick="btnCancle_Click" class="inputbutton btn btn-default"></asp:Button>

                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                </div> 

            </div>
        </div>
    </form>
</body>
</html>
