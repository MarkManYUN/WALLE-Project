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
namespace WalleProject.Web.t_systeminterchange
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int si_id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(si_id);
				}
			}
		}
			
	private void ShowInfo(int si_id)
	{
		WalleProject.BLL.t_systeminterchange bll=new WalleProject.BLL.t_systeminterchange();
		WalleProject.Model.t_systeminterchange model=bll.GetModel(si_id);
		this.txtsi_sort.Text=model.si_sort.ToString();
		this.txtsi_vaild.Text=model.si_vaild;
		this.txtsi_date.Text=model.si_date.ToString();
		this.txtsi_content.Text=model.si_content;
		this.txtsi_per_type.Text=model.si_per_type;
		this.txtsi_pic_id.Text=model.si_pic_id.ToString();
		this.txtsi_per_id.Text=model.si_per_id.ToString();
		this.txtsi_sl_id.Text=model.si_sl_id.ToString();
		this.lblsi_id.Text=model.si_id.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtsi_sort.Text))
			{
				strErr+="si_sort格式错误！\\n";	
			}
			if(this.txtsi_vaild.Text.Trim().Length==0)
			{
				strErr+="si_vaild不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtsi_date.Text))
			{
				strErr+="si_date格式错误！\\n";	
			}
			if(this.txtsi_content.Text.Trim().Length==0)
			{
				strErr+="si_content不能为空！\\n";	
			}
			if(this.txtsi_per_type.Text.Trim().Length==0)
			{
				strErr+="si_per_type不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtsi_pic_id.Text))
			{
				strErr+="si_pic_id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsi_per_id.Text))
			{
				strErr+="si_per_id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsi_sl_id.Text))
			{
				strErr+="si_sl_id格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int si_sort=int.Parse(this.txtsi_sort.Text);
			string si_vaild=this.txtsi_vaild.Text;
			DateTime si_date=DateTime.Parse(this.txtsi_date.Text);
			string si_content=this.txtsi_content.Text;
			string si_per_type=this.txtsi_per_type.Text;
			int si_pic_id=int.Parse(this.txtsi_pic_id.Text);
			int si_per_id=int.Parse(this.txtsi_per_id.Text);
			int si_sl_id=int.Parse(this.txtsi_sl_id.Text);
			int si_id=int.Parse(this.lblsi_id.Text);


			WalleProject.Model.t_systeminterchange model=new WalleProject.Model.t_systeminterchange();
			model.si_sort=si_sort;
			model.si_vaild=si_vaild;
			model.si_date=si_date;
			model.si_content=si_content;
			model.si_per_type=si_per_type;
			model.si_pic_id=si_pic_id;
			model.si_per_id=si_per_id;
			model.si_sl_id=si_sl_id;
			model.si_id=si_id;

			WalleProject.BLL.t_systeminterchange bll=new WalleProject.BLL.t_systeminterchange();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
