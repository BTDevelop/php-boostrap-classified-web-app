using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kdvUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = false;
            while (kontrol != true)
            {
                Console.WriteLine("Para miktarini giriniz:");
                double paraMiktari = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("KDV HESAPLAMA");
                Console.WriteLine("1-Gazete ve Dergiler");
                Console.WriteLine("2-Kümes Hayvanları ve Balıkları ile bunların etleri");
                Console.WriteLine("3-Süt, süt tozu");
                Console.WriteLine("4-Kitap ve benzeri yayınlar");
                Console.WriteLine("5-Su, Maden suyu");
                Console.WriteLine("6-Yufka");
                Console.WriteLine("7-Kurşun kalem");
                Console.WriteLine("8-Cikis\n");
                Console.Write("Seciminiz:");
                byte secim = Convert.ToByte(Console.ReadLine());
                double vergiOrani = 0.0;
                switch (secim)
                {
                    case 1:
                        Console.WriteLine("1-Toptan-Parekende");
                        Console.WriteLine("2-Posetlenerek satilan");
                        //Console.WriteLine("");
                        Console.WriteLine("Seciminiz:");
                        byte icSecim = Convert.ToByte(Console.ReadLine());
                        switch (icSecim)
                        {
                            case 1:
                                vergiOrani = 0.01;
                                break;
                            case 2:
                                vergiOrani = 0.18;
                                break;
                        }
                        break;
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                        vergiOrani = 0.08;
                        break;
                    case 8:
                        kontrol = true;
                        break;
                    default:
                        Console.WriteLine("Vergilendirme tablosu 8 seçmeden oluşur.");
                        kontrol = false;
                        break;
                }
                if (secim <= 8)
                {
                    Console.WriteLine("");
                    Console.WriteLine((paraMiktari + paraMiktari * vergiOrani) + " TL KDV'li fiyattır.");
                }
            }

            Console.Read();
        }
    }
}
