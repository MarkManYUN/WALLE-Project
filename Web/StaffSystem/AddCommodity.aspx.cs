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
    public partial class AddCommodity : System.Web.UI.Page
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
                string number = txt_i_number.Text;
                string strageId = txt_i_strageID.Text;
                string name = txt_i_name.Text;
                string alertNumber = txt_i_alertNumber.Text;
                string comc = ddl_i_se.SelectedValue;
                string price = txt_i_price.Text;
                string valid = txt_i_valid.Text;
                Model.t_commodity commodity = new Model.t_commodity();
                commodity.com_name = txt_i_name.Text;
                commodity.com_pic_ID = imgId;
                commodity.com_pri_ID = decimal.Parse(price);
                commodity.com_strageID = strageId;
                commodity.com_valid = valid;
                commodity.com_number = int.Parse(number);
                commodity.com_date = DateTime.Now;
                commodity.com_productDate = DateTime.Parse(txt_com_productDate.Text);
                commodity.com_conversionInt = int.Parse(price);
                commodity.com_comc_ID = int.Parse(comc);
                commodity.com_alertNumber = int.Parse(alertNumber);
                new BLL.t_commodity().Add(commodity);
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
             string Img_Path = Page.MapPath( "~/StaffSystem/CommodityImage/") + fileName;
             

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
                picture.pic_cate_ID = 3;


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