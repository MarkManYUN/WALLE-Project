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
namespace WalleProject.Web.t_wastesmailcate
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
					int wastecate_id=(Convert.ToInt32(strid));
					ShowInfo(wastecate_id);
				}
			}
		}
		
	private void ShowInfo(int wastecate_id)
	{
		WalleProject.BLL.t_wastesmailcate bll=new WalleProject.BLL.t_wastesmailcate();
		WalleProject.Model.t_wastesmailcate model=bll.GetModel(wastecate_id);
		this.lblwastecate_name.Text=model.wastecate_name;
		this.lblwastecate_id.Text=model.wastecate_id.ToString();
		this.lblwastecate_cid.Text=model.wastecate_cid.ToString();

	}


    }
}
