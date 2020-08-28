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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace WalleProject.Web.t_integratingrecord
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int int_ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(int_ID);
				}
			}
		}
			
	private void ShowInfo(int int_ID)
	{
		WalleProject.BLL.t_integratingrecord bll=new WalleProject.BLL.t_integratingrecord();
		WalleProject.Model.t_integratingrecord model=bll.GetModel(int_ID);
		this.lblint_ID.Text=model.int_ID.ToString();
		this.txtint_date.Text=model.int_date.ToString();
		this.txtint_integral.Text=model.int_integral.ToString();
		this.txtint_way.Text=model.int_way;
		this.txtint_u_ID.Text=model.int_u_ID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDateTime(txtint_date.Text))
			{
				strErr+="int_date格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtint_integral.Text))
			{
				strErr+="int_integral格式错误！\\n";	
			}
			if(this.txtint_way.Text.Trim().Length==0)
			{
				strErr+="int_way不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtint_u_ID.Text))
			{
				strErr+="int_u_ID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int int_ID=int.Parse(this.lblint_ID.Text);
			DateTime int_date=DateTime.Parse(this.txtint_date.Text);
			int int_integral=int.Parse(this.txtint_integral.Text);
			string int_way=this.txtint_way.Text;
			int int_u_ID=int.Parse(this.txtint_u_ID.Text);


			WalleProject.Model.t_integratingrecord model=new WalleProject.Model.t_integratingrecord();
			model.int_ID=int_ID;
			model.int_date=int_date;
			model.int_integral=int_integral;
			model.int_way=int_way;
			model.int_u_ID=int_u_ID;

			WalleProject.BLL.t_integratingrecord bll=new WalleProject.BLL.t_integratingrecord();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
