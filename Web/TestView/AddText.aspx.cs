using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.TestView
{
    public partial class AddText : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonAdd_Click(object sender, EventArgs e)
        {
            Model.t_wastesmailcate wastecategory;
            string content = txt_content.Text.Trim();
            string[] conArr = ContentToArray(content);
            int n = Convert.ToInt32(DropDownList1.SelectedValue);
            for (int i = 0; i < conArr.Length; i++)
            {
               wastecategory= new Model.t_wastesmailcate();
                wastecategory.wastecate_cid = n;
                wastecategory.wastecate_name = conArr[i];

                new BLL.t_wastesmailcate().Add(wastecategory);
            }

            txt_content.Text = "";


        }
        private string[] ContentToArray(string content)
        {
            return content.Split(' ');
        }
    }
}