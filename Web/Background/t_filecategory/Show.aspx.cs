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
namespace WalleProject.Web.t_filecategory
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
					int filec_ID=(Convert.ToInt32(strid));
					ShowInfo(filec_ID);
				}
			}
		}
		
	private void ShowInfo(int filec_ID)
	{
		WalleProject.BLL.t_filecategory bll=new WalleProject.BLL.t_filecategory();
		WalleProject.Model.t_filecategory model=bll.GetModel(filec_ID);
		this.lblfilec_ID.Text=model.filec_ID.ToString();
		this.lblfilec_name.Text=model.filec_name;
		this.lblfilec_path.Text=model.filec_path;
		this.lblfile_ext.Text=model.file_ext;

	}


    }
}
