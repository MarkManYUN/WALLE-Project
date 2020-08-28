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
namespace WalleProject.Web.t_integratingrecord
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
					int int_ID=(Convert.ToInt32(strid));
					ShowInfo(int_ID);
				}
			}
		}
		
	private void ShowInfo(int int_ID)
	{
		WalleProject.BLL.t_integratingrecord bll=new WalleProject.BLL.t_integratingrecord();
		WalleProject.Model.t_integratingrecord model=bll.GetModel(int_ID);
		this.lblint_ID.Text=model.int_ID.ToString();
		this.lblint_date.Text=model.int_date.ToString();
		this.lblint_integral.Text=model.int_integral.ToString();
		this.lblint_way.Text=model.int_way;
		this.lblint_u_ID.Text=model.int_u_ID.ToString();

	}


    }
}
