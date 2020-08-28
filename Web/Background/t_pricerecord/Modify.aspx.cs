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
namespace WalleProject.Web.t_pricerecord
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int pri_ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(pri_ID);
				}
			}
		}
			
	private void ShowInfo(int pri_ID)
	{
		WalleProject.BLL.t_pricerecord bll=new WalleProject.BLL.t_pricerecord();
		WalleProject.Model.t_pricerecord model=bll.GetModel(pri_ID);
		this.txtpri_date.Text=model.pri_date.ToString();
		this.txtpri_price.Text=model.pri_price.ToString();
		this.txtpri_com_ID.Text=model.pri_com_ID.ToString();
		this.lblpri_ID.Text=model.pri_ID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDateTime(txtpri_date.Text))
			{
				strErr+="pri_date格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtpri_price.Text))
			{
				strErr+="pri_price格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtpri_com_ID.Text))
			{
				strErr+="pri_com_ID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			DateTime pri_date=DateTime.Parse(this.txtpri_date.Text);
			decimal pri_price=decimal.Parse(this.txtpri_price.Text);
			int pri_com_ID=int.Parse(this.txtpri_com_ID.Text);
			int pri_ID=int.Parse(this.lblpri_ID.Text);


			WalleProject.Model.t_pricerecord model=new WalleProject.Model.t_pricerecord();
			model.pri_date=pri_date;
			model.pri_price=pri_price;
			model.pri_com_ID=pri_com_ID;
			model.pri_ID=pri_ID;

			WalleProject.BLL.t_pricerecord bll=new WalleProject.BLL.t_pricerecord();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
