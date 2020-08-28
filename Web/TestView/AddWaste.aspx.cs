using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.TestView
{
    public partial class AddWaste : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.t_picture add = new BLL.t_picture();
            Model.t_picture picture;
            for (int i = 1; i <= 1587; i++)
            {
                picture = new Model.t_picture();
                picture.pic_date = DateTime.Now;
                picture.pic_name = "废品图片" + i;
                picture.pic_valid = "../_wasteImage/" + i + ".jpg";
                picture.pic_cate_ID = 4;
                add.Add(picture);
            }

        }
    }
}