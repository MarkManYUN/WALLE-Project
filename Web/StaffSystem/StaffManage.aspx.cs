using Maticsoft.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.StaffSystem
{
    public partial class StaffManage : System.Web.UI.Page
    {
        public string strid = "";

        WalleProject.BLL.t_staff bll = new WalleProject.BLL.t_staff();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                gridView.BorderColor = ColorTranslator.FromHtml(Application[Session["Style"].ToString() + "xtable_bordercolorlight"].ToString());
                gridView.HeaderStyle.BackColor = ColorTranslator.FromHtml(Application[Session["Style"].ToString() + "xtable_titlebgcolor"].ToString());
                btnDelete.Attributes.Add("onclick", "return confirm(\"你确认要删除吗？\")");
                BindData();
                if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
                {
                    strid = Request.Params["id"];
                    long sta_id = (Convert.ToInt64(strid));
                    ShowInfo(sta_id);
                    ShowInfoEdit(sta_id);
                }
            }

        }

        private void ShowInfoEdit(long sta_id)
        {
            WalleProject.BLL.t_staff bll = new WalleProject.BLL.t_staff();
            WalleProject.Model.t_staff model = bll.GetModel(sta_id);
            this.lblsta_id.Text = model.sta_id.ToString();
            this.txtEdit_sta_userName.Text = model.sta_userName;
            this.txtEdit_sta_entryDate.Text = model.sta_entryDate.ToString();
            this.txtEdit_sta_passWord.Text = MD5Enctypt.MD5.Md5Decrypt( model.sta_passWord);
            this.txtEdit_sta_maritalStatus.Text = model.sta_maritalStatus;
            this.txtEdit_sta_IDNumber.Text = model.sta_IDNumber;
            this.txtEdit_sta_homeAddress.Text = model.sta_homeAddress;
            this.txtEdit_sta_phone.Text = model.sta_phone;
            this.txtEdit_sta_name.Text = model.sta_name; 
            this.txtEdit_sta_tra_id.Text = model.sta_tra_id.ToString();
            this.txtEdit_sta_lastLogindate.Text = model.sta_lastLogindate.ToString();
            this.txtEdit_sta_salary.Text = model.sta_salary.ToString(); 
        }

        public void btnEditSave_Click(object sender, EventArgs e)
        {

            string strErr = "";
            if (this.txtEdit_sta_userName.Text.Trim().Length == 0)
            {
                strErr += "用户名不能为空！\\n";
            } 
            if (this.txtEdit_sta_passWord.Text.Trim().Length == 0)
            {
                strErr += "密码不能为空！\\n";
            } 
            if (this.txtEdit_sta_IDNumber.Text.Trim().Length == 0)
            {
                strErr += "身份证号码不能为空！\\n";
            } 
            if (this.txtEdit_sta_phone.Text.Trim().Length == 0)
            {
                strErr += "电话号码不能为空！\\n";
            }
            if (this.txtEdit_sta_name.Text.Trim().Length == 0)
            {
                strErr += "姓名不能为空！\\n";
            } 
            if (!PageValidate.IsNumber(txtEdit_sta_tra_id.Text))
            {
                strErr += "用户类型格式错误！\\n";
            } 
            if (!PageValidate.IsDecimal(txtEdit_sta_salary.Text))
            {
                strErr += "工资格式错误！\\n";
            }

            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            long sta_id = long.Parse(this.lblsta_id.Text);
            string sta_userName = this.txtEdit_sta_userName.Text;
            DateTime sta_entryDate = DateTime.Parse(this.txtEdit_sta_entryDate.Text);
            string sta_passWord =MD5Enctypt.MD5.Md5Encrypt( this.txtEdit_sta_passWord.Text.Trim());
            string sta_maritalStatus = this.txtEdit_sta_maritalStatus.Text;
            string sta_IDNumber = this.txtEdit_sta_IDNumber.Text;
            string sta_homeAddress = this.txtEdit_sta_homeAddress.Text;
            string sta_phone = this.txtEdit_sta_phone.Text;
            string sta_name = this.txtEdit_sta_name.Text;
            int sta_tra_id = int.Parse(this.txtEdit_sta_tra_id.Text);
            DateTime sta_lastLogindate = DateTime.Parse(this.txtEdit_sta_lastLogindate.Text);
            decimal sta_salary = decimal.Parse(this.txtEdit_sta_salary.Text);


            WalleProject.Model.t_staff model =new BLL.t_staff().GetModel(sta_id); 
            model.sta_userName = sta_userName;
            model.sta_entryDate = sta_entryDate;
            model.sta_passWord = sta_passWord;
            model.sta_maritalStatus = sta_maritalStatus;
            model.sta_IDNumber = sta_IDNumber;
            model.sta_homeAddress = sta_homeAddress;
            model.sta_phone = sta_phone;
            model.sta_name = sta_name;
            model.sta_tra_id = sta_tra_id;
            model.sta_lastLogindate = sta_lastLogindate;
            model.sta_salary = sta_salary;

            WalleProject.BLL.t_staff bll = new WalleProject.BLL.t_staff();
            bll.Update(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "StaffManage.aspx");

        }

        private void ShowInfo(long sta_id)
        {
            WalleProject.BLL.t_staff bll = new WalleProject.BLL.t_staff();
            WalleProject.Model.t_staff model = bll.GetModel(sta_id);
            this.lblsta_id.Text = model.sta_id.ToString();
            this.lblsta_userName.Text = model.sta_userName;
            this.lblsta_entryDate.Text = model.sta_entryDate.ToString();
            this.lblsta_passWord.Text = model.sta_passWord;
            this.lblsta_maritalStatus.Text = model.sta_maritalStatus;
            this.lblsta_IDNumber.Text = model.sta_IDNumber;
            this.lblsta_homeAddress.Text = model.sta_homeAddress;
            this.lblsta_phone.Text = model.sta_phone;
            this.lblsta_name.Text = model.sta_name;
            this.lblsta__pic_id.Text = model.sta__pic_id.ToString();
            this.lblsta_tra_id.Text = model.sta_tra_id.ToString();
            this.lblsta_lastLogindate.Text = model.sta_lastLogindate.ToString();
            this.lblsta_salary.Text = model.sta_salary.ToString();

        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BindData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string idlist = GetSelIDlist();
            if (idlist.Trim().Length == 0)
                return;
            bll.DeleteList(idlist);
            BindData();
        }

        #region gridView

        public void BindData()
        {
            #region
            //if (!Context.User.Identity.IsAuthenticated)
            //{
            //    return;
            //}
            //AccountsPrincipal user = new AccountsPrincipal(Context.User.Identity.Name);
            //if (user.HasPermissionID(PermId_Modify))
            //{
            //    gridView.Columns[6].Visible = true;
            //}
            //if (user.HasPermissionID(PermId_Delete))
            //{
            //    gridView.Columns[7].Visible = true;
            //}
            #endregion

            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            if (txtKeyword.Text.Trim() != "")
            {
                strWhere.AppendFormat("sta_name like '%{0}%'", txtKeyword.Text.Trim());
            }
            ds = bll.GetList(strWhere.ToString());
            gridView.DataSource = ds;
            gridView.DataBind();
        }

        protected void gridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridView.PageIndex = e.NewPageIndex;
            BindData();
        }
        protected void gridView_OnRowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                //e.Row.Cells[0].Text = "<input id='Checkbox2' type='checkbox' onclick='CheckAll()'/><label></label>";
            }
        }
        protected void gridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Attributes.Add("style", "background:#FFF");
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton linkbtnDel = (LinkButton)e.Row.FindControl("LinkButton1");
                linkbtnDel.Attributes.Add("onclick", "return confirm(\"你确认要删除吗\")");

                //object obj1 = DataBinder.Eval(e.Row.DataItem, "Levels");
                //if ((obj1 != null) && ((obj1.ToString() != "")))
                //{
                //    e.Row.Cells[1].Text = obj1.ToString();
                //}

            }
        }

        protected void gridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            
            //int ID = (int)gridView.DataKeys[e.RowIndex].Value;
            //bll.Delete(ID);
            //gridView.OnBind();
        }

        private string GetSelIDlist()
        {
            string idlist = "";
            bool BxsChkd = false;
            for (int i = 0; i < gridView.Rows.Count; i++)
            {
                CheckBox ChkBxItem = (CheckBox)gridView.Rows[i].FindControl("DeleteThis");
                if (ChkBxItem != null && ChkBxItem.Checked)
                {
                    BxsChkd = true;
                    
                    if (gridView.DataKeys[i].Value != null)
                    {
                        idlist += gridView.DataKeys[i].Value.ToString() + ",";
                    }
                }
            }
            if (BxsChkd)
            {
                idlist = idlist.Substring(0, idlist.LastIndexOf(","));
            }
            return idlist;
        }

        #endregion


        protected void btnSave_Click(object sender, EventArgs e)
        {

            string strErr = "";
            if (this.txtsta_userName.Text.Trim().Length == 0)
            {
                strErr += "用户名不能为空！\\n";
            }
            if (this.txtsta_passWord.Text.Trim().Length == 0)
            {
                strErr += "密码不能为空！\\n";
            }
            if (this.txtsta_maritalStatus.Text.Trim().Length == 0)
            {
                strErr += "婚姻状况不能为空！\\n";
            }
            if (this.txtsta_IDNumber.Text.Trim().Length == 0)
            {
                strErr += "身份证号码不能为空！\\n";
            }
            if (this.txtsta_homeAddress.Text.Trim().Length == 0)
            {
                strErr += "家庭住址不能为空！\\n";
            }
            if (this.txtsta_phone.Text.Trim().Length == 0)
            {
                strErr += "电话号码不能为空！\\n";
            }
            if (this.txtsta_name.Text.Trim().Length == 0)
            {
                strErr += "真实姓名不能为空！\\n";
            } 
            if (!PageValidate.IsNumber(txtsta_tra_id.Text))
            {
                strErr += "用户类型格式错误！\\n";
            }
            if (!PageValidate.IsDecimal(txtsta_salary.Text))
            {
                strErr += "工资格式错误！\\n";
            }

            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            string sta_userName = this.txtsta_userName.Text;
            DateTime sta_entryDate = DateTime.Now;
            string sta_passWord =MD5Enctypt.MD5.Md5Encrypt( this.txtsta_passWord.Text.Trim());
            string sta_maritalStatus = this.txtsta_maritalStatus.Text;
            string sta_IDNumber = this.txtsta_IDNumber.Text;
            string sta_homeAddress = this.txtsta_homeAddress.Text;
            string sta_phone = this.txtsta_phone.Text;
            string sta_name = this.txtsta_name.Text;
            int sta_pic_id =1;
            int sta_tra_id = int.Parse(this.txtsta_tra_id.SelectedValue);
            DateTime sta_lastLogindate = DateTime.Now;
            decimal sta_salary = decimal.Parse(this.txtsta_salary.Text);

            WalleProject.Model.t_staff model = new WalleProject.Model.t_staff();
            model.sta_userName = sta_userName;
            model.sta_entryDate = sta_entryDate;
            model.sta_passWord = sta_passWord;
            model.sta_maritalStatus = sta_maritalStatus;
            model.sta_IDNumber = sta_IDNumber;
            model.sta_homeAddress = sta_homeAddress;
            model.sta_phone = sta_phone;
            model.sta_name = sta_name;
            model.sta__pic_id = sta_pic_id;
            model.sta_tra_id = sta_tra_id;
            model.sta_lastLogindate = sta_lastLogindate;
            model.sta_salary = sta_salary;

            WalleProject.BLL.t_staff bll = new WalleProject.BLL.t_staff();
            bll.Add(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "StaffManage.aspx");

        }


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffManage.aspx");
        }


    }
}