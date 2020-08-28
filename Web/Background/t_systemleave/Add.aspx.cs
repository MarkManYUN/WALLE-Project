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
namespace WalleProject.Web.t_systemleave
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtsl_sort.Text))
			{
				strErr+="sl_sort格式错误！\\n";	
			}
			if(this.txtsl_valid.Text.Trim().Length==0)
			{
				strErr+="sl_valid不能为空！\\n";	
			}
			if(this.txtsl_content.Text.Trim().Length==0)
			{
				strErr+="sl_content不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtsl_pic_id.Text))
			{
				strErr+="sl_pic_id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsl_per_id.Text))
			{
				strErr+="sl_per_id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsl_per_type.Text))
			{
				strErr+="sl_per_type格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtsl_date.Text))
			{
				strErr+="sl_date格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int sl_sort=int.Parse(this.txtsl_sort.Text);
			string sl_valid=this.txtsl_valid.Text;
			string sl_content=this.txtsl_content.Text;
			int sl_pic_id=int.Parse(this.txtsl_pic_id.Text);
			int sl_per_id=int.Parse(this.txtsl_per_id.Text);
			int sl_per_type=int.Parse(this.txtsl_per_type.Text);
			DateTime sl_date=DateTime.Parse(this.txtsl_date.Text);

			WalleProject.Model.t_systemleave model=new WalleProject.Model.t_systemleave();
			model.sl_sort=sl_sort;
			model.sl_valid=sl_valid;
			model.sl_content=sl_content;
			model.sl_pic_id=sl_pic_id;
			model.sl_per_id=sl_per_id;
			model.sl_per_type=sl_per_type;
			model.sl_date=sl_date;

			WalleProject.BLL.t_systemleave bll=new WalleProject.BLL.t_systemleave();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
