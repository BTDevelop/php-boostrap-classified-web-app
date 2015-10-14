using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kurHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] kurlarim = { 3.0988M, 2.7537M };
            string[] birimlerim = { "euro", "dolar" };
            Program obje = new Program();

            Console.Write("Param miktarını giriniz(bosluk bırakarak): ");
            string para = Console.ReadLine();

            Console.WriteLine("Cevrilecek kur birimi:\n1-Euro\n2-Amerikan Dolari");
            byte kurBirimi = Convert.ToByte(Console.ReadLine());

            string[] eleman = para.Split(' ');
            decimal paraMiktari = Convert.ToDecimal(eleman[0]);


            decimal sonuc = obje.kurHesapla(paraMiktari, eleman[1], kurlarim[kurBirimi - 1]);
            Console.WriteLine(paraMiktari + " " + eleman[1] + " " + sonuc+" "+birimlerim[kurBirimi-1]);

        }


        public decimal kurHesapla(decimal miktar = 0, string birim1 = "", decimal birim2 = 0)
        {
            decimal kurSonuc = miktar / birim2;
            return kurSonuc;

        }
    }
}
