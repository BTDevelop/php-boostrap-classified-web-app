using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace DAL
{
    public class Toolkit
    {

        public static string StripHtmlTags(string metin)
        {
            if (metin == null) return null;

            char[] array = new char[metin.Length];
            int arrayIndex = 0;
            bool inside = false;

            for (int i = 0; i < metin.Length; i++)
            {
                char let = metin[i];
                if (let == '<')
                {
                    inside = true;
                    continue;
                }
                if (let == '>')
                {
                    inside = false;
                    continue;
                }
                if (!inside)
                {
                    array[arrayIndex] = let;
                    arrayIndex++;
                }
            }
            return new string(array, 0, arrayIndex);
        }

        public static string URLConverter(string _income)
        {
            string _conurl = _income.ToLower();
            _conurl = _conurl.Replace("ç", "c");
            _conurl = _conurl.Replace("ı", "i");
            _conurl = _conurl.Replace("ğ", "g");
            _conurl = _conurl.Replace("ö", "o");
            _conurl = _conurl.Replace("ü", "u");
            _conurl = _conurl.Replace("ş", "s");
            _conurl = _conurl.Replace("'", "-");
            _conurl = _conurl.Replace(" ", "-");
            _conurl = _conurl.Replace("#", "sharp");
            return _conurl;

        }

        public static void MailGonder(string toadress, string body, string text)
        {
            if (String.IsNullOrEmpty(toadress))
            {
                return;
            }

            try
            {
                MailMessage _mail = new MailMessage();
                _mail.To.Add(toadress);
                _mail.From = new MailAddress("buraktahtacioglu.com@gmail.com");
                _mail.Subject = text;

                _mail.Body = body;
                _mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Credentials = new System.Net.NetworkCredential("buraktahtacioglu.com@gmail.com", "Bt3645948+");
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Send(_mail);

            }
            catch (Exception)
            {
                throw;

            }
        }

     
    }


}
