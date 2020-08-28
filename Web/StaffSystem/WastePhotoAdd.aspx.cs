using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.StaffSystem
{
    public partial class WastePhotoAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           string imgInt= (Request["wid"] == null) ? "1" : Request["wid"];
           
            Image1.ImageUrl = new BLL.t_picture().GetModel(Convert.ToInt32(imgInt)).pic_valid;
        }
        //第二个DDL,数据绑定完成后,要求第三个DDL重新进行数据绑定
        protected void load_d(object sender, EventArgs e)
        {
            ddl_d.DataBind();
        }


        //最后一个DDL,如果内容为空,则不显示
        protected void checkitems(object s, EventArgs e)
        {
            if (ddl_d.Items.Count == 0) { ddl_d.Style["display"] = "none"; } else { ddl_d.Style.Remove("display"); }
        }

        protected void btn_Save_Click(object sender, EventArgs e)
        {
            Model.t_waste waste = new Model.t_waste();
            waste.was_name = was_name.Text;
            waste.was_number = Convert.ToInt32(was_number.Text);
            waste.was_price = decimal.Parse(was_price.Text);
            waste.was_recoverable = int.Parse(ddl_c.SelectedValue);
            waste.was_cate_ID = Convert.ToInt32(ddl_d.SelectedValue);
            string _nid = (Request["wid"] == null) ? "1" : Request["wid"];
            waste.was_pic_ID = Convert.ToInt32(_nid);
            waste.was_valid = was_valid.Text;
            new BLL.t_waste().Add(waste);
            Response.Redirect("WasteView.aspx");

        }

        protected void btn_Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("WastePhoto.aspx");
        }
    }
}