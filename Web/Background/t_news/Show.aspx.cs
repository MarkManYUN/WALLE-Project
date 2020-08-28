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
namespace WalleProject.Web.t_news
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
					int new_ID=(Convert.ToInt32(strid));
					ShowInfo(new_ID);
				}
			}
		}
		
	private void ShowInfo(int new_ID)
	{
		WalleProject.BLL.t_news bll=new WalleProject.BLL.t_news();
		WalleProject.Model.t_news model=bll.GetModel(new_ID);
		this.lblnew_title.Text=model.new_title;
		this.lblnew_creatDate.Text=model.new_creatDate.ToString();
		this.lblnew_cate_id.Text=model.new_cate_id.ToString();
		this.lblnew_pic_id.Text=model.new_pic_id.ToString();
		this.lblnew_content.Text=model.new_content;
		this.lblnew_valid.Text=model.new_valid;
		this.lblnew_ID.Text=model.new_ID.ToString();

	}


    }
}
