﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WalleProject.Web.Code;

namespace WalleProject.Web.News
{
    public partial class newsDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            div_submenuHolder.Controls.Add(SubMenu.GetSubmenu(1));

            //获取新闻
            string _nid = (Request["nid"] == null) ? "1" : Request["nid"];
            NewsReader.newsID = int.Parse(_nid);
        }
    }
}