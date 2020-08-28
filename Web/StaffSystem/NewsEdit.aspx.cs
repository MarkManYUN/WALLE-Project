using Maticsoft.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.StaffSystem
{
    public partial class NewsEdit : System.Web.UI.Page
    {
        public string strid = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
                {
                    strid = Request.Params["id"];
                    int new_ID = (Convert.ToInt32(strid));
                    ShowEditInfo(new_ID);
                }
            }
        }
        private void ShowEditInfo(int new_ID)
        {
            WalleProject.BLL.t_news bll = new WalleProject.BLL.t_news();
            WalleProject.Model.t_news model = bll.GetModel(new_ID);
            this.txtEditnew_title.Text = model.new_title; 
            this.txtEditnew_cate_id.Text = model.new_cate_id.ToString();
            this.lb_i_img.SelectedValue= model.new_pic_id.ToString();
            this.content.InnerHtml = Server.HtmlDecode(PageValidate.Decode(model.new_content));
            this.txtEditnew_valid.Text = model.new_valid;
            this.img_i_mo.Src = new BLL.t_picture().GetModel(int.Parse( model.new_pic_id.ToString())).pic_valid;
            this.imgID .Text= model.new_pic_id.ToString();
            Label1.Text = model.new_ID.ToString();
        }

        public void btnEditSave_Click(object sender, EventArgs e)
        {

            string strErr = "";
            if (this.txtEditnew_title.Text.Trim().Length == 0)
            {
                strErr += "新闻不能为空！\\n";
            } 
            if (!PageValidate.IsNumber(txtEditnew_cate_id.SelectedValue))
            {
                strErr += "新闻类别格式错误！\\n";
            } 
            if (this.content.InnerHtml.Trim().Length == 0)
            {
                strErr += "new_content不能为空！\\n";
            }
            if (this.txtEditnew_valid.Text.Trim().Length == 0)
            {
                strErr += "new_valid不能为空！\\n";
            }

            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            string new_title = this.txtEditnew_title.Text; 
            int new_cate_id = int.Parse(this.txtEditnew_cate_id.Text); 
            string new_content = this.content.InnerHtml;
            string new_valid = this.txtEditnew_valid.Text;
            int new_ID = int.Parse( Label1.Text);


            WalleProject.Model.t_news model = new WalleProject.Model.t_news();
            model.new_title = new_title; 
            model.new_cate_id = new_cate_id;

            HttpPostedFile file = fup_com_img.PostedFile;
            if (file != null)
            {
                model.new_pic_id = UploadFile(file);
            }
            else
            {
                if (!PageValidate.IsNumber(lb_i_img.SelectedValue))
                {
                    strErr += "图片没有选择！\\n";
                    MessageBox.Show(this, strErr);
                    return;
                }
                int new_pic_id = int.Parse(this.lb_i_img.SelectedValue) == -1 ? 1 : int.Parse(this.lb_i_img.SelectedValue);
            }
            model.new_content = new_content;
            model.new_valid = new_valid;
            model.new_ID = new_ID;

            WalleProject.BLL.t_news bll = new WalleProject.BLL.t_news();
            bll.Update(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "NewsManage.aspx");

        }


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewsManage.aspx");
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
            string Img_Path = Page.MapPath("../NewsImage/") + fileName;


            try
            {
                //创建没有存在的目录
                Directory.CreateDirectory(Page.MapPath("../NewsImage/"));
                _file.SaveAs(Img_Path);

            }
            catch
            { }

            if (File.Exists(Img_Path))
            {
                DateTime img_Date = DateTime.Now;
                picture.pic_ID =int.Parse( this.imgID.Text);
                picture.pic_date = img_Date;
                picture.pic_name = fileName;
                picture.pic_valid = "../NewsImage/" + fileName;
                picture.pic_cate_ID = 1;


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