using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WalleProject.Web.Code;

namespace WalleProject.Web.StaffSystem
{
    public partial class DownLoad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        #region Web 窗体设计器生成的代码
        override protected void OnInit(EventArgs e)
        {
            //
            // CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
            //
            InitializeComponent();
            base.OnInit(e);
        }

        /// <summary>
        /// 设计器支持所需的方法 - 不要使用代码编辑器修改
        /// 此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_addSession.Click += new EventHandler(this.btn_addSession_Click);

        }
        #endregion
        //文件下载代码: 未登录用户被禁止下载
        protected void fdownload(object sender, CommandEventArgs e)
        {
   
                Code.SuperFile superFile = new SuperFile(int.Parse(e.CommandArgument.ToString()));
                superFile.fileDownload();
           
        }

        protected void btn_addSession_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (((HttpPostedFile[])Session["postedFiles"])[i] == null)
                {
                    ((HttpPostedFile[])Session["postedFiles"])[i] = fup1.PostedFile;
                    break;
                }
            }

            Response.Redirect(Request.RawUrl);
        }
        
    }
}