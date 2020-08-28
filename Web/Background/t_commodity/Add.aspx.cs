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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtcom_name.Text.Trim().Length==0)
			{
				strErr+="商品名不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtcom_productDate.Text))
			{
				strErr+="生产日期格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcom_number.Text))
			{
				strErr+="商品数量格式错误！\\n";	
			}
			if(this.txtcom_strageID.Text.Trim().Length==0)
			{
				strErr+="货架号不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtcom_alertNumber.Text))
			{
				strErr+="警戒值格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcom_pic_ID.Text))
			{
				strErr+="图片格式错误！\\n";	
			} 
			if(!PageValidate.IsNumber(txtcom_pri_ID.Text))
			{
				strErr+="二级类别格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcom_conversionInt.Text))
			{
				strErr+="积分格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcom_comc_ID.Text))
			{
				strErr+="类别格式错误！\\n";	
			} 
			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
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
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
