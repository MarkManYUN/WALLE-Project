using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
namespace WalleProject.Web.t_picture
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int pic_ID=(Convert.ToInt32(strid));
					ShowInfo(pic_ID);
				}
			}
		}
		
	private void ShowInfo(int pic_ID)
	{
		WalleProject.BLL.t_picture bll=new WalleProject.BLL.t_picture();
		WalleProject.Model.t_picture model=bll.GetModel(pic_ID);
		this.lblpic_cate_ID.Text=model.pic_cate_ID.ToString();
		this.lblpic_ID.Text=model.pic_ID.ToString();
		this.lblpic_date.Text=model.pic_date.ToString();
		this.lblpic_name.Text=model.pic_name;
		this.lblpic_valid.Text=model.pic_valid;

	}


    }
}
