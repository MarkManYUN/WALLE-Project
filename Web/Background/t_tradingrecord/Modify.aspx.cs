﻿using System;
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
namespace WalleProject.Web.t_tradingrecord
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int tra_ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(tra_ID);
				}
			}
		}
			
	private void ShowInfo(int tra_ID)
	{
		WalleProject.BLL.t_tradingrecord bll=new WalleProject.BLL.t_tradingrecord();
		WalleProject.Model.t_tradingrecord model=bll.GetModel(tra_ID);
		this.txttra_U_ID.Text=model.tra_U_ID.ToString();
		this.txttra_transactionAmount.Text=model.tra_transactionAmount.ToString();
		this.txttra_transactionDate.Text=model.tra_transactionDate.ToString();
		this.txttra_accomplish.Text=model.tra_accomplish;
		this.txttra_staff_id.Text=model.tra_staff_id.ToString();
		this.txtsta_comwas_id.Text=model.sta_comwas_id.ToString();
		this.txttra_number.Text=model.tra_number.ToString();
		this.lbltra_ID.Text=model.tra_ID.ToString();
		this.txttra_addressID.Text=model.tra_addressID.ToString();
		this.txttra_type.Text=model.tra_type;
		this.txttra_vaild.Text=model.tra_vaild;
		this.txttra_sort.Text=model.tra_sort.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txttra_U_ID.Text))
			{
				strErr+="tra_U_ID格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txttra_transactionAmount.Text))
			{
				strErr+="tra_transactionAmount格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txttra_transactionDate.Text))
			{
				strErr+="tra_transactionDate格式错误！\\n";	
			}
			if(this.txttra_accomplish.Text.Trim().Length==0)
			{
				strErr+="tra_accomplish不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txttra_staff_id.Text))
			{
				strErr+="tra_staff_id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsta_comwas_id.Text))
			{
				strErr+="sta_comwas_id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txttra_number.Text))
			{
				strErr+="tra_number格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txttra_addressID.Text))
			{
				strErr+="tra_addressID格式错误！\\n";	
			}
			if(this.txttra_type.Text.Trim().Length==0)
			{
				strErr+="tra_type不能为空！\\n";	
			}
			if(this.txttra_vaild.Text.Trim().Length==0)
			{
				strErr+="tra_vaild不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txttra_sort.Text))
			{
				strErr+="tra_sort格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int tra_U_ID=int.Parse(this.txttra_U_ID.Text);
			decimal tra_transactionAmount=decimal.Parse(this.txttra_transactionAmount.Text);
			DateTime tra_transactionDate=DateTime.Parse(this.txttra_transactionDate.Text);
			string tra_accomplish=this.txttra_accomplish.Text;
			int tra_staff_id=int.Parse(this.txttra_staff_id.Text);
			int sta_comwas_id=int.Parse(this.txtsta_comwas_id.Text);
			int tra_number=int.Parse(this.txttra_number.Text);
			int tra_ID=int.Parse(this.lbltra_ID.Text);
			int tra_addressID=int.Parse(this.txttra_addressID.Text);
			string tra_type=this.txttra_type.Text;
			string tra_vaild=this.txttra_vaild.Text;
			int tra_sort=int.Parse(this.txttra_sort.Text);


			WalleProject.Model.t_tradingrecord model=new WalleProject.Model.t_tradingrecord();
			model.tra_U_ID=tra_U_ID;
			model.tra_transactionAmount=tra_transactionAmount;
			model.tra_transactionDate=tra_transactionDate;
			model.tra_accomplish=tra_accomplish;
			model.tra_staff_id=tra_staff_id;
			model.sta_comwas_id=sta_comwas_id;
			model.tra_number=tra_number;
			model.tra_ID=tra_ID;
			model.tra_addressID=tra_addressID;
			model.tra_type=tra_type;
			model.tra_vaild=tra_vaild;
			model.tra_sort=tra_sort;

			WalleProject.BLL.t_tradingrecord bll=new WalleProject.BLL.t_tradingrecord();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
