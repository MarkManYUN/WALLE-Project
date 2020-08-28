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
namespace WalleProject.Web.t_orderevaluate
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int oe_id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(oe_id);
				}
			}
		}
			
	private void ShowInfo(int oe_id)
	{
		WalleProject.BLL.t_orderevaluate bll=new WalleProject.BLL.t_orderevaluate();
		WalleProject.Model.t_orderevaluate model=bll.GetModel(oe_id);
		this.txtoe_sort.Text=model.oe_sort.ToString();
		this.txtoe_vaild.Text=model.oe_vaild;
		this.txtoe_grade.Text=model.oe_grade.ToString();
		this.txtoe_isread.Text=model.oe_isread;
		this.txtoe_per_type.Text=model.oe_per_type;
		this.txtoe_content.Text=model.oe_content;
		this.txtoe_tra_id.Text=model.oe_tra_id.ToString();
		this.txtoe_per_id.Text=model.oe_per_id.ToString();
		this.txtoe_pic_id.Text=model.oe_pic_id.ToString();
		this.lbloe_id.Text=model.oe_id.ToString();
		this.txtoe_date.Text=model.oe_date.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtoe_sort.Text))
			{
				strErr+="oe_sort格式错误！\\n";	
			}
			if(this.txtoe_vaild.Text.Trim().Length==0)
			{
				strErr+="oe_vaild不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtoe_grade.Text))
			{
				strErr+="oe_grade格式错误！\\n";	
			}
			if(this.txtoe_isread.Text.Trim().Length==0)
			{
				strErr+="oe_isread不能为空！\\n";	
			}
			if(this.txtoe_per_type.Text.Trim().Length==0)
			{
				strErr+="oe_per_type不能为空！\\n";	
			}
			if(this.txtoe_content.Text.Trim().Length==0)
			{
				strErr+="oe_content不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtoe_tra_id.Text))
			{
				strErr+="oe_tra_id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtoe_per_id.Text))
			{
				strErr+="oe_per_id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtoe_pic_id.Text))
			{
				strErr+="oe_pic_id格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtoe_date.Text))
			{
				strErr+="oe_date格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int oe_sort=int.Parse(this.txtoe_sort.Text);
			string oe_vaild=this.txtoe_vaild.Text;
			int oe_grade=int.Parse(this.txtoe_grade.Text);
			string oe_isread=this.txtoe_isread.Text;
			string oe_per_type=this.txtoe_per_type.Text;
			string oe_content=this.txtoe_content.Text;
			int oe_tra_id=int.Parse(this.txtoe_tra_id.Text);
			int oe_per_id=int.Parse(this.txtoe_per_id.Text);
			int oe_pic_id=int.Parse(this.txtoe_pic_id.Text);
			int oe_id=int.Parse(this.lbloe_id.Text);
			DateTime oe_date=DateTime.Parse(this.txtoe_date.Text);


			WalleProject.Model.t_orderevaluate model=new WalleProject.Model.t_orderevaluate();
			model.oe_sort=oe_sort;
			model.oe_vaild=oe_vaild;
			model.oe_grade=oe_grade;
			model.oe_isread=oe_isread;
			model.oe_per_type=oe_per_type;
			model.oe_content=oe_content;
			model.oe_tra_id=oe_tra_id;
			model.oe_per_id=oe_per_id;
			model.oe_pic_id=oe_pic_id;
			model.oe_id=oe_id;
			model.oe_date=oe_date;

			WalleProject.BLL.t_orderevaluate bll=new WalleProject.BLL.t_orderevaluate();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
