using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.StaffSystem
{
    public partial class CommodityPhotoAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string _nid = (Request["cid"] == null) ? "1" : Request["cid"];

            Image1.ImageUrl = new BLL.t_picture().GetModel(Convert.ToInt32(_nid)).pic_valid;
        }
       

        protected void btn_Save_Click(object sender, EventArgs e)
        {
            Model.t_commodity commodity = new Model.t_commodity();
            commodity.com_name = was_name.Text;
            commodity.com_number = Convert.ToInt32(was_number.Text);
            commodity.com_pri_ID = decimal.Parse(was_price.Text);
            commodity.com_productDate = this.Calendar1.SelectedDate;
            commodity.com_alertNumber =int.Parse( this.com_alertNumber.Text);
            commodity.com_strageID = this.com_strageID.Text;
            commodity.com_date = DateTime.Now; 
            commodity.com_comc_ID = Convert.ToInt32(ddl_super.SelectedValue);
            commodity.com_conversionInt =int.Parse( this.was_price.Text);
            string _nid = (Request["cid"] == null) ? "1" : Request["cid"]; ;
            commodity.com_pic_ID = Convert.ToInt32(_nid);
            commodity.com_valid = was_valid.Text;
            new BLL.t_commodity().Add(commodity);
            Response.Redirect("CommodityView.aspx?menuid=23");

        }

        protected void btn_Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("CommodityPhoto.aspx?menuid=31");
        }
    }
}