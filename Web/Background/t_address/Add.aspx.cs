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
namespace WalleProject.Web.t_address
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtadd_u_ID.Text))
			{
				strErr+="用户编号格式错误！\\n";	
			}
			if(this.txtadd_contactName.Text.Trim().Length==0)
			{
				strErr+="联系人不能为空！\\n";	
			}
			if(this.txtadd_contactPhone.Text.Trim().Length==0)
			{
				strErr+="联系电话不能为空！\\n";	
			}   
			if(this.txtadd_address.Text.Trim().Length==0)
			{
				strErr+="地址不能为空！\\n";	
			}
			if(this.txtadd_counties.Text.Trim().Length==0)
			{
				strErr+="县区不能为空！\\n";	
			}
			if(this.txtadd_city.Text.Trim().Length==0)
			{
				strErr+="市不能为空！\\n";	
			}
			if(this.txtadd_province.Text.Trim().Length==0)
			{
				strErr+="省不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int add_u_ID=int.Parse(this.txtadd_u_ID.Text);
			string add_contactName=this.txtadd_contactName.Text;
			string add_contactPhone=this.txtadd_contactPhone.Text;
			DateTime add_date=DateTime.Parse(this.txtadd_date.Text);
			int add_postcode=int.Parse(this.txtadd_postcode.Text);
			string add_default=this.txtadd_default.Text;
			string add_address=this.txtadd_address.Text;
			string add_counties=this.txtadd_counties.Text;
			string add_city=this.txtadd_city.Text;
			string add_province=this.txtadd_province.Text;

			WalleProject.Model.t_address model=new WalleProject.Model.t_address();
			model.add_u_ID=add_u_ID;
			model.add_contactName=add_contactName;
			model.add_contactPhone=add_contactPhone;
			model.add_date=add_date;
			model.add_postcode=add_postcode;
			model.add_default=add_default;
			model.add_address=add_address;
			model.add_counties=add_counties;
			model.add_city=add_city;
			model.add_province=add_province;

			WalleProject.BLL.t_address bll=new WalleProject.BLL.t_address();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
