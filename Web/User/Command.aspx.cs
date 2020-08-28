using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.User
{
    public partial class Command : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Model.t_user user = (Model.t_user)Session["UserInfo"];

                if (user == null)
                {
                    Response.Redirect("UserLogin.aspx");
                }
                userid.Text = user.u_ID.ToString();
                if (Request["cid"] != null)
                {
                    string id = Request["cid"];
                    traid.Text = id;
                    DataSet ds= new BLL.t_orderevaluate().GetList(" oe_per_id= "+user.u_ID+ " and oe_per_type='我' and  oe_tra_id=" + id );
                    if (ds.Tables.Count == 1 && ds.Tables[0].Rows.Count == 0)
                    {
                        MultiView1.ActiveViewIndex = 0;
                    }
                    else {
                        MultiView1.ActiveViewIndex = 2;

                    }
                }
                else
                {

                    Response.Redirect("UserLogin.aspx");
                }
            }
        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            string uid = userid.Text;
            string ugrade = grade.Value;
            if (ugrade.Trim().Equals("0")|| ugrade==null)
            {
                ugrade = "5";
            }
            string content = inputNote.InnerText;
            Model.t_orderevaluate orderevaluate = new Model.t_orderevaluate();
            orderevaluate.oe_per_id = int.Parse(uid); 
            orderevaluate.oe_content = content;
            orderevaluate.oe_date = DateTime.Now;
            orderevaluate.oe_grade =int.Parse( ugrade.ToString());
            orderevaluate.oe_per_type = "我";
            orderevaluate.oe_tra_id = int.Parse(Request["cid"]);
            HttpPostedFile file = fup_com_img.PostedFile;

            if (file != null)
            {
                orderevaluate.oe_pic_id = UploadFile(file);
            }
            else
            {

                orderevaluate.oe_pic_id = 1;
            } 
            orderevaluate.oe_isread = "未读";
            new BLL.t_orderevaluate().Add(orderevaluate);

            MultiView1.ActiveViewIndex = 1;
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
                picture.pic_ID = id;
                picture.pic_date = img_Date;
                picture.pic_name = fileName;
                picture.pic_valid = "../NewsImage/" + fileName;
                picture.pic_cate_ID = 5;


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