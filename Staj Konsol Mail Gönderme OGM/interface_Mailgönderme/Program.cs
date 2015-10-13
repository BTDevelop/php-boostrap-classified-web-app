using System;
using System.Collections.Generic;
using System.Text;

namespace interface_Mailgönderme
{
    class Program
    {
        static void Main(string[] args)
        {
            myMail mm = new myMail();
            mm.body = "Burak Proje Mail Test ";
            mm.from = "uyelik.turanemrek@gmail.com";
            mm.to = "clubwomanizer588@gmail.com";
            mm.subject = "TEST";
            mm.IsBodyHtml = false;
         
            if (mm.Send(mm.from, mm.to, mm.body, mm.subject, "Gmail Kullanıcı Adın", "Şifren"))
                Console.WriteLine("Gönderim Başarılı...");
            else
                Console.WriteLine("Gönderim Başarısız...");
            Console.ReadLine();
        }
    }
}
