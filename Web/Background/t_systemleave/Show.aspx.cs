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
namespace WalleProject.Web.t_systemleave
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
					int sl_id=(Convert.ToInt32(strid));
					ShowInfo(sl_id);
				}
			}
		}
		
	private void ShowInfo(int sl_id)
	{
		WalleProject.BLL.t_systemleave bll=new WalleProject.BLL.t_systemleave();
		WalleProject.Model.t_systemleave model=bll.GetModel(sl_id);
		this.lblsl_sort.Text=model.sl_sort.ToString();
		this.lblsl_valid.Text=model.sl_valid;
		this.lblsl_content.Text=model.sl_content;
		this.lblsl_pic_id.Text=model.sl_pic_id.ToString();
		this.lblsl_per_id.Text=model.sl_per_id.ToString();
		this.lblsl_id.Text=model.sl_id.ToString();
		this.lblsl_per_type.Text=model.sl_per_type.ToString();
		this.lblsl_date.Text=model.sl_date.ToString();

	}


    }
}
