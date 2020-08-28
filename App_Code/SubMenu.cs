using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.UI;
using MySql.Data.MySqlClient;


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
    public static BulletedList getSubmenu(int classID)
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
    public static BulletedList getBaseSubmenu()
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
    public static void reWriteApplication()
    {
      
    }
    /// <summary>
    /// 重写Application后台导航栏的内容
    /// </summary>
    /// <param name="Per"></param>
    public static void reWriteBaseApplication(string Per)
    {

        ListItem li;
        BulletedList bulllist = new BulletedList();
      
        HttpContext.Current.Application.Lock();
        HttpContext.Current.Application["basemenu"] = bulllist;
        HttpContext.Current.Application.UnLock();
    }
}