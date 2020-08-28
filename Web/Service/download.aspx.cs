using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WalleProject.Web.Code;

namespace WalleProject.Web.Service
{
    public partial class download : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            div_AboutsubmenuHolder.Controls.Add(SubMenu.GetSubmenu(2));

        }
        //文件下载代码: 未登录用户被禁止下载
        protected void fdownload(object sender, CommandEventArgs e)
        { Boolean _isLogin;
            if (Session["UserInfo"] != null)
            {
                _isLogin = true;
            }
            else
            {
               _isLogin = false;
            }
            if (!_isLogin)
            {
                string js = "alert('登录后再下载');location.href='../Default.aspx';";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "", js, true);

            }
            else
            {
                Code.SuperFile superFile = new SuperFile(int.Parse(e.CommandArgument.ToString()));
                superFile.fileDownload();
            }
        }
    }
}