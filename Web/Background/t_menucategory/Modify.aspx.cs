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
namespace WalleProject.Web.t_menucategory
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int menuc_ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(menuc_ID);
				}
			}
		}
			
	private void ShowInfo(int menuc_ID)
	{
		WalleProject.BLL.t_menucategory bll=new WalleProject.BLL.t_menucategory();
		WalleProject.Model.t_menucategory model=bll.GetModel(menuc_ID);
		this.lblmenuc_ID.Text=model.menuc_ID.ToString();
		this.txtmenuc_name.Text=model.menuc_name;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtmenuc_name.Text.Trim().Length==0)
			{
				strErr+="menuc_name不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int menuc_ID=int.Parse(this.lblmenuc_ID.Text);
			string menuc_name=this.txtmenuc_name.Text;


			WalleProject.Model.t_menucategory model=new WalleProject.Model.t_menucategory();
			model.menuc_ID=menuc_ID;
			model.menuc_name=menuc_name;

			WalleProject.BLL.t_menucategory bll=new WalleProject.BLL.t_menucategory();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
