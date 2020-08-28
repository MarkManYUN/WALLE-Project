using Maticsoft.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.StaffSystem
{
    public partial class ImageView : System.Web.UI.Page
    {
        public string strid = "";
        WalleProject.BLL.t_picture bll = new WalleProject.BLL.t_picture();

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
                    int pic_ID = (Convert.ToInt32(strid));
                    ShowInfo(pic_ID);
                }
            }
        }




        protected void btnSave_Click(object sender, EventArgs e)
        {

            string strErr = "";
            if (!PageValidate.IsNumber(ddl_add.SelectedValue))
            {
                strErr += "格式错误！\\n";
            }
            if (this.txtpic_name.Text.Trim().Length == 0)
            {
                strErr += " 不能为空！\\n";
            }

            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            int pic_cate_ID = int.Parse(ddl_add.SelectedValue);
            DateTime pic_date = DateTime.Now;
            string pic_name = this.txtpic_name.Text;

            HttpPostedFile file = fup_com_img.PostedFile;
            int imgId = UploadFile(file);
            if (imgId == -1)
            {
                Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存失败！", "ImageView.aspx");

            }
            else
            {
                Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "ImageView.aspx");
            }

        }


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("ImageView.aspx");
        }

        private void ShowInfo(int pic_ID)
        {
            WalleProject.BLL.t_picture bll = new WalleProject.BLL.t_picture();
            WalleProject.Model.t_picture model = bll.GetPicturModel(pic_ID);
            this.lblpic_cate_ID.Text = model.picturecategory.picca_name;
            this.lblpic_ID.Text = model.pic_ID.ToString();
            this.lblpic_date.Text = model.pic_date.ToString();
            this.lblpic_name.Text = model.pic_name;
            this.lblpic_valid.Text = model.pic_valid;

            this.ddl_edit.SelectedValue = model.pic_cate_ID.ToString();
            this.edit_date.Text = model.pic_date.ToString();
            this.edit_name.Text = model.pic_name;
            this.edit_path.Text = model.pic_valid;
            img.Src = model.pic_valid;

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
                strWhere.AppendFormat("pic_name like '%{0}%'", txtKeyword.Text.Trim());
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

        protected void edit_save_Click(object sender, EventArgs e)
        {
            string strErr = "";
            if (!PageValidate.IsNumber(ddl_edit.SelectedValue))
            {
                strErr += "格式错误！\\n";
            }
            if (!PageValidate.IsDateTime(edit_date.Text))
            {
                strErr += "时间格式错误！\\n";
            }
            if (this.edit_name.Text.Trim().Length == 0)
            {
                strErr += " 不能为空！\\n";
            }
            if (this.edit_path.Text.Trim().Length == 0)
            {
                strErr += " 不能为空！\\n";
            }

            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            int pic_cate_ID = int.Parse(this.ddl_edit.SelectedValue);
            DateTime pic_date = DateTime.Parse(this.edit_date.Text);
            string pic_name = this.edit_name.Text;
            string pic_valid = this.edit_path.Text;

            WalleProject.Model.t_picture model = new WalleProject.Model.t_picture();
            model.pic_cate_ID = pic_cate_ID;

            model.pic_date = pic_date;
            model.pic_name = pic_name;
            model.pic_valid = pic_valid;
            model.pic_ID = Convert.ToInt32(Request.Params["id"]);
            WalleProject.BLL.t_picture bll = new WalleProject.BLL.t_picture();
            bll.Update(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "ImageView.aspx");
        }

        protected int UploadFile(HttpPostedFile _file)
        {
            string fileName = _file.FileName;
            Model.t_picture picture = new Model.t_picture();
            int id = new BLL.t_picture().GetMaxId();

            string sqlwhere = " pic_name like '%" + fileName + "%'";

            DataSet datas = new BLL.t_picture().GetList(sqlwhere);
            if (datas != null && datas.Tables[0].Rows.Count > 0)
            {
                string js = "alert('文件已存在');";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "", js, true);
                return -1;
            }
            string Img_Path = Page.MapPath("~/StaffSystem/UploadImage/") + fileName;


            try
            {
                //创建没有存在的目录
                Directory.CreateDirectory(Page.MapPath("~/StaffSystem/UploadImage/"));
                _file.SaveAs(Img_Path);

            }
            catch
            { }

            if (File.Exists(Img_Path))
            {
                DateTime img_Date = DateTime.Now;
                picture.pic_ID = id;
                picture.pic_date = img_Date;
                if (txtpic_name.Text.Trim() == "")
                {
                    picture.pic_name = fileName;
                }
                else {
                    picture.pic_name = txtpic_name.Text;

                }

                picture.pic_valid = "~/StaffSystem/UploadImage/" + picture.pic_name;
                picture.pic_cate_ID = int.Parse(ddl_add.SelectedValue);


                if (!new BLL.t_picture().Add(picture))
                {
                    return -1;
                }
                return id;
            }
            else
            {

                return -1;
            }


        }
    }
}