using Maticsoft.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.StaffSystem
{
    public partial class SalaryAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
            {
                int sta_ID = (Convert.ToInt32(Request.Params["id"]));

                ShowInfo(sta_ID);
            }
        }
        WalleProject.BLL.t_staffsalary bll = new WalleProject.BLL.t_staffsalary();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sal_ID"></param>
        private void ShowInfo(int sta_ID)
        {
            DataSet ds = bll.GetList("sal_sta_id=" + sta_ID + " and sal_date=(SELECT MAX(t_staffsalary.sal_date) from t_staffsalary where sal_sta_id="+sta_ID+")");
            WalleProject.Model.t_staffsalary model = new Model.t_staffsalary();
            if (ds.Tables[0].Rows.Count != 0)
            {

                foreach (DataTable table in ds.Tables)
                {
                    model = bll.GetModel(int.Parse(table.Rows[0]["sal_ID"].ToString()));
                }

            }

            this.lblsal_staff.Text = sta_ID.ToString();
            if (model != null && model.sal_year == DateTime.Now.Year && model.sal_month == DateTime.Now.Month)
            {

                this.lblsal_ID.Text = model.sal_ID.ToString();
                this.txtsal_bonusM.Text = model.sal_bonusM.ToString();
                this.txtsal_describe.Value = model.sal_describe;
                this.txtsal_deductM.Text = model.sal_deductM.ToString();
                this.txtsal_totalM.Text = model.sal_totalM.ToString();
                this.txtsal_incrementM.Text = model.sal_incrementM.ToString();
                this.txtSal_leaveDay.Text = model.Sal_leaveDay.ToString();
                this.txtSal_absenteeismDay.Text = model.Sal_absenteeismDay.ToString();

            }
            else
            {
                this.lblsal_ID.Text = new BLL.t_staffsalary().GetMaxId().ToString();
                this.txtsal_bonusM.Text = "0.0";
                this.txtsal_describe.Value = " ";
                this.txtsal_deductM.Text = "0.0";
                this.txtsal_totalM.Text = new BLL.t_staff().GetModel(sta_ID).sta_salary.ToString();
                this.txtsal_incrementM.Text = "0.0";
                this.txtSal_leaveDay.Text = "0";
                this.txtSal_absenteeismDay.Text = "0";

            }

        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            WalleProject.BLL.t_staffsalary bll = new WalleProject.BLL.t_staffsalary();
            WalleProject.Model.t_staffsalary model =
                new WalleProject.BLL.t_staffsalary().GetModel(int.Parse(lblsal_ID.Text));

            string strErr = "";
            if (!PageValidate.IsNumber(txtSal_absenteeismDay.Text))
            {
                strErr += "旷工天数格式错误！\\n";
            }
            
            if (!PageValidate.IsNumber(txtSal_leaveDay.Text))
            {
                strErr += "请假天数格式错误！\\n";
            }

            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }



            int Sal_absenteeismDay = int.Parse(this.txtSal_absenteeismDay.Text);
            int sal_ID = int.Parse(this.lblsal_ID.Text);
            decimal sal_bonusM = decimal.Parse(this.txtsal_bonusM.Text);
            decimal sal_deductM = decimal.Parse(this.txtsal_deductM.Text);
            decimal sal_total = decimal.Parse(this.txtsal_totalM.Text);
            decimal sal_incrementM = decimal.Parse(this.txtsal_incrementM.Text);
            int Sal_leaveDay = int.Parse(this.txtSal_leaveDay.Text);
            int sta_id = int.Parse(lblsal_staff.Text);
            string sal_describe = "  奖金:" + sal_bonusM + "扣除:" + sal_deductM + "  基本工资增长：" + sal_incrementM + "  请假天数：" + Sal_leaveDay + "  旷工天数：" + Sal_absenteeismDay;

            Model.t_staff staff = new BLL.t_staff().GetModel(sta_id);
            Model.t_salarytaxrate salarytaxrate = new BLL.t_salarytaxrate().GetModel(new BLL.t_salarytaxrate().GetMaxId() - 1);

            model = new WalleProject.Model.t_staffsalary();
            model.Sal_absenteeismDay = Sal_absenteeismDay;
            model.sal_ID = sal_ID;
            model.sal_bonusM = sal_bonusM;
            model.sal_describe = sal_describe;
            model.sal_deductM = sal_deductM;
            model.sal_totalM = decimal.Parse(staff.sta_salary.ToString());
            model.sal_incrementM = sal_incrementM;
            model.Sal_leaveDay = Sal_leaveDay;
            model.sal_date = DateTime.Now;
            model.sal_year = DateTime.Now.Year;
            model.sal_month = DateTime.Now.Month;
            model.sal_sta_id = sta_id;
            staff.sta_id = sta_id;
            decimal staffSal = decimal.Parse(staff.sta_salary.ToString());
            //计算这个月所有工资
            //奖金+其他扣除+工资基本增长+旷工罚金+请假扣除+旷工扣除
            decimal totalSalary =  model.sal_bonusM - model.sal_deductM + 
                model.sal_incrementM - model.Sal_leaveDay * 50 - model.Sal_absenteeismDay * 100;
            staffSal += totalSalary;
            // 除开个人所得税的其他（养老保险，社会保险，住房公积金等）
            decimal taxLast = staffSal * (salarytaxrate.Sta_supplement
                + salarytaxrate.Str_aged + salarytaxrate.Str_housing + salarytaxrate.Str_medical
               + salarytaxrate.Str_unemployment);
            //个人所得税
            model.sal_totalM = staffSal+totalSalary + ((staffSal- salarytaxrate.Sta_threshold) * salarytaxrate.Sta_individualTax) - taxLast;

            if (model != null && model.sal_year == DateTime.Now.Year && model.sal_month == DateTime.Now.Month)
            {
                bll.Add(model);
                Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "SalaryAdd.aspx");
            }
            else
            {
                model.sal_describe += "  操作：修改";

                bll.Add(model);
                Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "SalaryAdd.aspx");

            }
        }


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("SalaryManage.aspx");
        }
    }
}