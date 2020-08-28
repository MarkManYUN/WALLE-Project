using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace WalleProject.Web.Code
{

    /// <summary>
    /// subMenu 的摘要说明
    /// </summary>
    public static class SubMenu
    {

        /// <summary>
        /// 返回子菜单bulletedList控件
        /// </summary>
        /// <param name="classID">数据库只能怪classID的值</param>
        /// <returns></returns>
        public static BulletedList GetSubmenu(int classID)
        {
            BulletedList blist = (BulletedList)HttpContext.Current.Application["T_Menu"];
            BulletedList blist_now = new BulletedList();
            blist_now.DisplayMode = BulletedListDisplayMode.HyperLink;
            int i = 0;
            foreach (ListItem li in blist.Items)
            {
                i++;
                if (li.Attributes["classid"] == classID.ToString())
                {
                    blist_now.Items.Add(li);
                }
            }

            return blist_now;
        }
        /// <summary>
        /// 后台导出菜单
        /// </summary>
        /// <param name="classID">人员身份识别ID</param>
        /// <returns></returns>
        public static BulletedList GetBaseSubmenu()
        {
            BulletedList blist = (BulletedList)HttpContext.Current.Application["basemenu"];
            BulletedList blist_now = new BulletedList();
            blist_now.DisplayMode = BulletedListDisplayMode.HyperLink;
            int i = 0;
            foreach (ListItem li in blist.Items)
            {
                i++;

                blist_now.Items.Add(li);
                //if (li.Attributes["classid"] == classID.ToString())
                //{}
            }

            return blist_now;
        }
        /// <summary>
        /// 重写application前台导航栏的内容
        /// </summary>
        public static void ReWriteApplication()
        {
            ListItem li;
            BulletedList bulllist = new BulletedList();
            bulllist.CssClass = "a";
            System.Data.DataSet ds = new BLL.t_menu().GetAllList();
            DataTable dt = ds.Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                li = new ListItem();
                DataRow dr = dt.Rows[i];
                li.Text = dr["menu_name"].ToString();
                li.Value = dr["menu_path"].ToString();

                li.Attributes.Add("class", "single_title");
                li.Attributes.Add("style", "font-size:1.5em;");
                li.Attributes.Add("classid", dr["menu_Cate_ID"].ToString());
                bulllist.Items.Add(li);
            }
            HttpContext.Current.Application.Lock();
            HttpContext.Current.Application["T_Menu"] = bulllist;
            HttpContext.Current.Application.UnLock();
        }
        /// <summary>
        /// 重写Application后台导航栏的内容
        /// </summary>
        /// <param name="Per"></param>
        public static void ReWriteBaseApplication(string Per)
        {

            ListItem li;
            BulletedList bulllist = new BulletedList();
            System.Data.DataSet ds = new BLL.t_menu().GetAllList();
            DataTable dt = ds.Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                li = new ListItem();
                DataRow dr = dt.Rows[i];
                li.Text = dr["menu_name"].ToString();
                li.Value = dr["menu_path"].ToString();
                li.Attributes.Add("classid", dr["menu_ID"].ToString());
            }
            HttpContext.Current.Application.Lock();
            HttpContext.Current.Application["basemenu"] = bulllist;
            HttpContext.Current.Application.UnLock();
        }
    }

}