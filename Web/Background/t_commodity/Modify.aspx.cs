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
namespace WalleProject.Web.t_commodity
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int com_ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(com_ID);
				}
			}
		}
			
	private void ShowInfo(int com_ID)
	{
		WalleProject.BLL.t_commodity bll=new WalleProject.BLL.t_commodity();
		WalleProject.Model.t_commodity model=bll.GetModel(com_ID);
		this.lblcom_ID.Text=model.com_ID.ToString();
		this.txtcom_name.Text=model.com_name;
		this.txtcom_productDate.Text=model.com_productDate.ToString();
		this.txtcom_number.Text=model.com_number.ToString();
		this.txtcom_strageID.Text=model.com_strageID;
		this.txtcom_alertNumber.Text=model.com_alertNumber.ToString();
		this.txtcom_pic_ID.Text=model.com_pic_ID.ToString();
		this.txtcom_date.Text=model.com_date.ToString();
		this.txtcom_pri_ID.Text=model.com_pri_ID.ToString();
		this.txtcom_conversionInt.Text=model.com_conversionInt.ToString();
		this.txtcom_comc_ID.Text=model.com_comc_ID.ToString();
		this.txtcom_valid.Text=model.com_valid;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtcom_name.Text.Trim().Length==0)
			{
				strErr+="com_name不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtcom_productDate.Text))
			{
				strErr+="com_productDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcom_number.Text))
			{
				strErr+="com_number格式错误！\\n";	
			}
			if(this.txtcom_strageID.Text.Trim().Length==0)
			{
				strErr+="com_strageID不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtcom_alertNumber.Text))
			{
				strErr+="com_alertNumber格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcom_pic_ID.Text))
			{
				strErr+="com_pic_ID格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtcom_date.Text))
			{
				strErr+="com_date格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcom_pri_ID.Text))
			{
				strErr+="com_pri_ID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcom_conversionInt.Text))
			{
				strErr+="com_conversionInt格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcom_comc_ID.Text))
			{
				strErr+="com_comc_ID格式错误！\\n";	
			}
			if(this.txtcom_valid.Text.Trim().Length==0)
			{
				strErr+="com_valid不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int com_ID=int.Parse(this.lblcom_ID.Text);
			string com_name=this.txtcom_name.Text;
			DateTime com_productDate=DateTime.Parse(this.txtcom_productDate.Text);
			int com_number=int.Parse(this.txtcom_number.Text);
			string com_strageID=this.txtcom_strageID.Text;
			int com_alertNumber=int.Parse(this.txtcom_alertNumber.Text);
			int com_pic_ID=int.Parse(this.txtcom_pic_ID.Text);
			DateTime com_date=DateTime.Parse(this.txtcom_date.Text);
			int com_pri_ID=int.Parse(this.txtcom_pri_ID.Text);
			int com_conversionInt=int.Parse(this.txtcom_conversionInt.Text);
			int com_comc_ID=int.Parse(this.txtcom_comc_ID.Text);
			string com_valid=this.txtcom_valid.Text;


			WalleProject.Model.t_commodity model=new WalleProject.Model.t_commodity();
			model.com_ID=com_ID;
			model.com_name=com_name;
			model.com_productDate=com_productDate;
			model.com_number=com_number;
			model.com_strageID=com_strageID;
			model.com_alertNumber=com_alertNumber;
			model.com_pic_ID=com_pic_ID;
			model.com_date=com_date;
			model.com_pri_ID=com_pri_ID;
			model.com_conversionInt=com_conversionInt;
			model.com_comc_ID=com_comc_ID;
			model.com_valid=com_valid;

			WalleProject.BLL.t_commodity bll=new WalleProject.BLL.t_commodity();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
