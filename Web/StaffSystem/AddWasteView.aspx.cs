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
    public partial class AddWasteView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpPostedFile file = fup_com_img.PostedFile;
            int imgId = UploadFile(file);
            if (imgId >= 0)
            { 
                string name = txt_i_name.Text;
                string c1 = ddl_c.SelectedValue;
                string c2 = ddl_d.SelectedValue;
                string price = iprice.Text;
                string vaild = chk_e_enable.Text;
                Model.t_waste waste = new Model.t_waste();
                waste.was_name = txt_i_name.Text;
                waste.was_pic_ID = imgId;
                waste.was_price = decimal.Parse(price);
                waste.was_cate_ID =Convert.ToInt32( c2);
                waste.was_recoverable =Convert.ToInt32( c1);
                waste.was_valid = vaild;
                 
                new BLL.t_waste().Add(waste);
            }

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
            string Img_Path = Page.MapPath("~/StaffSystem/CommodityImage/") + fileName;


            try
            {
                //创建没有存在的目录
                Directory.CreateDirectory(Page.MapPath("~/StaffSystem/CommodityImage/"));
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
                picture.pic_valid = "~/StaffSystem/CommodityImage/" + fileName;
                picture.pic_cate_ID = 4;


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