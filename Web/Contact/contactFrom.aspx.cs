using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WalleProject.Web.Code;

namespace WalleProject.Web.Contact
{
    public partial class contactFrom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            div_AboutsubmenuHolder.Controls.Add(SubMenu.GetSubmenu(3));
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string _name, _phone, _content,_to;
            DateTime _date;
            _name = txt_name.Text;
            _phone = txt_email.Text;
            _to = "958636329@qq.com";
            _content =_name+"</br> "+_to+" </br> 邮件主题:" + txt_subject.Text+ "</br> : " + txt_msg.Text;
            _date = DateTime.Now;

            Model.t_message msg = new Model.t_message();
            msg.mess_date = _date;
            msg.mess_content = _content;
            bool isTrue=new BLL.t_message().Add(msg);

           bool isSend= WalleProject.Common.MailSend.SendEmail(_to,txt_subject.Text,_content);
            /*
            string _from, _to, _subject, _body;
            _from = "18786832384@139.com";
            _to = "958636329@qq.com";
            _subject = _name + "提交的留言【" + _date + "】";
            _body = _content;
          
            MailMessage _mag = new MailMessage(_from, _to, _subject, _body);
            _mag.IsBodyHtml = true;//启用富文本信息
            SmtpClient _client = new SmtpClient("smtp.139.com", 25);//提供主机名称和端口
            _client.DeliveryMethod = SmtpDeliveryMethod.Network;//设置发送方式，network
            _client.Credentials = new NetworkCredential("18786832384@139.com", "tv563300");//为SMTP提供账户凭证：用户名和密码
            _client.Send(_mag);//发送
            */
            if (isSend)
            {
                mv_form.SetActiveView(v_success);

            }
            else {
                mv_form.SetActiveView(v_fail);
            }
           
        }
    }

}