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
namespace WalleProject.Web.t_orderevaluate
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
					int oe_id=(Convert.ToInt32(strid));
					ShowInfo(oe_id);
				}
			}
		}
		
	private void ShowInfo(int oe_id)
	{
		WalleProject.BLL.t_orderevaluate bll=new WalleProject.BLL.t_orderevaluate();
		WalleProject.Model.t_orderevaluate model=bll.GetModel(oe_id);
		this.lbloe_sort.Text=model.oe_sort.ToString();
		this.lbloe_vaild.Text=model.oe_vaild;
		this.lbloe_grade.Text=model.oe_grade.ToString();
		this.lbloe_isread.Text=model.oe_isread;
		this.lbloe_per_type.Text=model.oe_per_type;
		this.lbloe_content.Text=model.oe_content;
		this.lbloe_tra_id.Text=model.oe_tra_id.ToString();
		this.lbloe_per_id.Text=model.oe_per_id.ToString();
		this.lbloe_pic_id.Text=model.oe_pic_id.ToString();
		this.lbloe_id.Text=model.oe_id.ToString();
		this.lbloe_date.Text=model.oe_date.ToString();

	}


    }
}
