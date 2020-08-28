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
namespace WalleProject.Web.t_file
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
					int file_ID=(Convert.ToInt32(strid));
					ShowInfo(file_ID);
				}
			}
		}
		
	private void ShowInfo(int file_ID)
	{
		WalleProject.BLL.t_file bll=new WalleProject.BLL.t_file();
		WalleProject.Model.t_file model=bll.GetModel(file_ID);
		this.lblfile_ID.Text=model.file_ID.ToString();
		this.lblfile_date.Text=model.file_date.ToString();
		this.lblfile_title.Text=model.file_title;
		this.lblfile_catefory_ID.Text=model.file_catefory_ID.ToString();
		this.lblfile_Name.Text=model.file_Name;
		this.lblfile_valid.Text=model.file_valid;

	}


    }
}
