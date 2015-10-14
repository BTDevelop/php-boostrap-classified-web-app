using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dersKayit
{
    class Program
    {
        static void Main(string[] args)
        {
            ders dr = new ders();
            
            
            char kontrol='e';
            while (kontrol != 'h')
            {
               Console.Write("Ders Girmek Istiyor Musunuz(e/h):");
               kontrol = Convert.ToChar(Console.ReadLine());
               if (kontrol == 'e')
               {
                   Console.Write("Ders Adi:");
                   dr.DersAdi = Console.ReadLine();
                   Console.Write("Ders Kredisi:");
                   dr.DersKredisi = Convert.ToInt32(Console.ReadLine());
                   Console.Write("Ders Hocasi:");
                   dr.DersinHocasi = Console.ReadLine();
                   Console.Write("Ders Mevcudu:");
                   dr.DersiAlanMevcut = Convert.ToInt32(Console.ReadLine());
                   Console.Write("Ders On Sarti:");
                   dr.DersOnSarti = Console.ReadLine();
                   Console.Write("Ders Gunu:");
                   dr.DersGunu = Console.ReadLine();
               }

            }
            dr.ekranaBas(dr.DersAdi,dr.DersKredisi,dr.DersinHocasi,dr.DersiAlanMevcut,dr.DersOnSarti,dr.DersGunu);
        }
    }
}
