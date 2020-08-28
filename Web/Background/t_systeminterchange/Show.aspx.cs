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
namespace WalleProject.Web.t_systeminterchange
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
					int si_id=(Convert.ToInt32(strid));
					ShowInfo(si_id);
				}
			}
		}
		
	private void ShowInfo(int si_id)
	{
		WalleProject.BLL.t_systeminterchange bll=new WalleProject.BLL.t_systeminterchange();
		WalleProject.Model.t_systeminterchange model=bll.GetModel(si_id);
		this.lblsi_sort.Text=model.si_sort.ToString();
		this.lblsi_vaild.Text=model.si_vaild;
		this.lblsi_date.Text=model.si_date.ToString();
		this.lblsi_content.Text=model.si_content;
		this.lblsi_per_type.Text=model.si_per_type;
		this.lblsi_pic_id.Text=model.si_pic_id.ToString();
		this.lblsi_per_id.Text=model.si_per_id.ToString();
		this.lblsi_sl_id.Text=model.si_sl_id.ToString();
		this.lblsi_id.Text=model.si_id.ToString();

	}


    }
}
