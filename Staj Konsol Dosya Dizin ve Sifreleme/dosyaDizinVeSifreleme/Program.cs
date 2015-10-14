using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace dosyaDizinVeSifreleme
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!Directory.Exists(Application.StartupPath + "\\Dosya Dizin İşlemleri"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Dosya Dizin İşlemleri");
            }
            Directory.CreateDirectory(Application.StartupPath + "\\Dosya Dizin İşlemleri" + DateTime.Now.ToShortDateString() + "\\tarihli projem" + "\\alt dosya");

            StreamReader sr = new StreamReader(Application.StartupPath + "\\Dosya Dizin İşlemleri" + DateTime.Now.ToShortDateString() + "\\tarihli projem" + "\\alt dosya" + "\\dosyam.txt");

            string satir = sr.ReadToEnd();
            Console.Write("Orjinal kelime: " + satir);
        }
    }
}
