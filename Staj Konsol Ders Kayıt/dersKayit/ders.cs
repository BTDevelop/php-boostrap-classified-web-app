using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dersKayit
{
   class ders
    {
      
        string dersAdi;
        int dersKredisi;
        string dersinHocasi;
        string dersinGunu;
        int dersiAlanMevcut;
        string dersOnSarti;
 
        public int DersKredisi { get; set; }
        public string DersAdi { get; set; }
        public string DersinHocasi { get; set; }
        public int DersiAlanMevcut { get; set; }
        public string DersOnSarti { get; set; }
        public string DersGunu { get; set; }

        public void ekranaBas(string ad,int kredi,string hoca,int mevcut,string sart,string gun)
        {
            Console.WriteLine("Dersin Adi: {0,8}", ad);
            Console.WriteLine("Dersin Kredisi: {0,8}", kredi);
            Console.WriteLine("Dersin Hocasi: {0,8}", hoca);
            Console.WriteLine("Dersin Mevcudu: {0,8}", mevcut);
            Console.WriteLine("Dersin On Sarti: {0,8}", sart);
            Console.WriteLine("Dersin Gunu: {0,8}", gun);
        }


    }
}
