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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			model.oe_date=oe_date;

			WalleProject.BLL.t_orderevaluate bll=new WalleProject.BLL.t_orderevaluate();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
