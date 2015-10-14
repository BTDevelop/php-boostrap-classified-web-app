using System;
using System.Windows.Forms;
namespace atmUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullaniciAdi = "Oyuncu";
            string sifre = "q1w2e3r4t5y6u7";

            Console.WriteLine("ATM UYGULAMASI");
            Console.Write("Kullanici Adi: ");
            string kullaniciTmp = Console.ReadLine();
            Console.Write("Sifre:");
            string sifreTmp = Console.ReadLine();
            int test = 0;
            if (kullaniciAdi == kullaniciTmp && sifre == sifreTmp) { Console.WriteLine("Giris Onaylandı."); Application.Exit();/* Ani çıkış */}
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    if (sifre != sifreTmp)
                    {
                        Console.Write("Tekrar Sifre:");
                        sifreTmp = Console.ReadLine();
                        ++test;
                    }
                    else { Console.WriteLine("Giris Onaylandı."); }
                }
                if (test == 2)
                {
                    Console.WriteLine("Hesap bloke oldu.");
                    Console.WriteLine("\nSIFRE DEGISTIME EKRANI");
                    Console.WriteLine("1-Kendi Sifreni Üret");
                    Console.WriteLine("2-Robot Senin İcin Üretsin");
                    Console.WriteLine("Secim: ");
                    int secim = Convert.ToInt32(Console.ReadLine());
                    if (secim == 1)
                    {
                        Console.WriteLine("Yeni Sifreyi Giriniz.");
                        string yeniSifre = Console.ReadLine();
                        Console.WriteLine("Yeni Tekrar Sifreyi Giriniz.");
                        string yeniSifreTmp = Console.ReadLine();
                        if (yeniSifre == yeniSifreTmp)
                        {
                            Console.WriteLine("Sifre basariyla degistirilmistir.");
                            MessageBox.Show("Sifre:" + yeniSifre, "UYARI");

                        }
                        else { Console.WriteLine("Hesap Kullanilamaz."); }
                    }
                    else if (secim == 2)
                    {
                        string key = "bqğsş402jf7üleoa8umı3g6nç5czyiv9p1tkwrdöh";
                        string sifrelenen = "";

                        for (int i = 0; i < sifre.Length; i++)
                        {
                            sifrelenen += key.IndexOf(sifre[i]).ToString();
                        }

                        MessageBox.Show("Üretilen Sifre: " + sifrelenen);

                    }
                }
                else { Console.WriteLine("Hatali Secim"); }
            }
        }
    }
}

