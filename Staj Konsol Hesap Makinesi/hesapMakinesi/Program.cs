using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = false;
            while (kontrol != true)
            {
                Console.WriteLine("HESAP MAKINESI");
                Console.WriteLine("1-Toplama");
                Console.WriteLine("2-Cikarma");
                Console.WriteLine("3-Carpma");
                Console.WriteLine("4-Bölme");
                Console.WriteLine("5-Mod Alma");
                Console.WriteLine("6-Negatif Yapma");
                Console.WriteLine("7-Cikis");

                Console.WriteLine("Seciminiz:");
                int secim = Convert.ToInt32(Console.ReadLine());
                double sayi1, sayi2, sonuc=0;

                switch (secim)
                {
                    case 1:
                        Console.Write("Sayi 1:");
                        sayi1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Sayi 2:");
                        sayi2 = Convert.ToDouble(Console.ReadLine());
                        sonuc = sayi1 + sayi2;
                        break;
                    case 2:
                        Console.Write("Sayi 1:");
                        sayi1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Sayi 2:");
                        sayi2 = Convert.ToDouble(Console.ReadLine());
                        sonuc = sayi1 - sayi2;
                        break;
                    case 3:
                        Console.Write("Sayi 1:");
                        sayi1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Sayi 2:");
                        sayi2 = Convert.ToDouble(Console.ReadLine());
                        sonuc = sayi1 * sayi2;
                        break;
                    case 4:
                        Console.Write("Sayi 1:");
                        sayi1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Sayi 2:");
                        sayi2 = Convert.ToDouble(Console.ReadLine());
                        sonuc = sayi1 / sayi2;
                        break;
                    case 5:
                        Console.Write("Sayi 1(Modu Alinacak Sayi):");
                        sayi1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Sayi 2:");
                        sayi2 = Convert.ToDouble(Console.ReadLine());
                        sonuc = sayi1 - (Math.Floor(sayi1 / sayi2)) * sayi2;
                        break;
                    case 6:

                        Console.Write("Sayi 1:");
                        sayi1 = Convert.ToDouble(Console.ReadLine());
                        if (sayi1 < 0) { sonuc = sayi1 * -1; }
                        else
                        { sonuc = sayi1; }
                        break;

                    case 7:
                        kontrol = true;
                        break;

                    default:
                        Console.WriteLine("Farkli Bir Secim Yapiniz.");
                        kontrol = false;
                        break;


                }
                Console.WriteLine("Sonuc: " + sonuc);
            }
        }
    }
}
