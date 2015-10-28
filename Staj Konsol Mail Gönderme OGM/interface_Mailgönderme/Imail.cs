using System;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Net;

namespace interface_Mailgönderme
{
    interface Imail
    {
        string from { get;set;}
        string to { get;set;}
        string subject { get;set;}
        string body { get;set; }
        bool IsBodyHtml { set;}

        bool send();
    }
    class myMail:Imail
    {
        #region Imail Members

        string _from;
        public string from
        {
            get
            {
                return _from;
            }
            set
            {
                Regex reg = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                if (reg.IsMatch(value))
                    _from = value;
                else
                    throw new Exception("Geçerli bir e-mail adresi girin...");
            }
        }
        string _to;
        public string to
        {
            get
            {
                return _to;
            }
            set
            {
                _to = value;
            }
        }
        string _subject;
        public string subject
        {
            get
            {
                return _subject;
            }
            set
            {
                _subject = value;
            }
        }
        string _body;
        public string body
        {
            get
            {
                return _body;
            }
            set
            {
                _body = value;
            }
        }
        bool _IsBodyHtml;
        public bool IsBodyHtml
        {
            set { _IsBodyHtml=value; }
        }

        public object MessageBox { get; private set; }

        public bool Send(string from, string to, string icerik,string konu ,string username, string password, string smtpServer= "smtp.gmail.com", int smtpPort=587)
        {
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    SmtpClient sc = new SmtpClient();
                    mail.From = new MailAddress("buraktahtacioglu.com@gmail.com");
                    mail.To.Add(new MailAddress(to));
                    mail.IsBodyHtml = true;
                    mail.Subject = "Test Message";
                    mail.Body = "Burak Test";
                    mail.BodyEncoding = System.Text.Encoding.UTF8;
                    mail.SubjectEncoding = System.Text.Encoding.UTF8;
                    NetworkCredential izinler = new NetworkCredential("buraktahtacioglu.com@gmail.com", "Bt3645948+");
                    sc.Host = smtpServer;
                    sc.Port = smtpPort;
                    sc.Credentials = izinler;
                    sc.EnableSsl = true;
                    sc.Send(mail);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return false;
            }
        }

        public bool send()
        {
            MailMessage mail = new MailMessage(_from, _to, _subject, _body);
            mail.IsBodyHtml = _IsBodyHtml;
            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            bool donen = false;
            try
            {
                smtp.Send(mail);
                donen = true;
            }
            catch { ;}
            return donen;
        }

        #endregion
    }
}
