using Maticsoft.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalleProject.Web.MyControl
{
    public partial class NewsReader : System.Web.UI.UserControl
    {
        private int _newID;
        public int newsID
        {
            get { return _newID; }
            set { _newID = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Model.t_news news = new BLL.t_news().GetNewsModel(newsID);
            newsDateTime.InnerText = "发布时间： "+ news.new_creatDate.ToString();
            newsContent.InnerHtml = Server.HtmlDecode(PageValidate.Decode(news.new_content));
            newsImgs.ImageUrl = news.picture.pic_valid;
            newsTitle.InnerHtml = news.new_title+ "<small >  ["+news.newscategory.newc_name+"]</small>";
            
        }
    }
}