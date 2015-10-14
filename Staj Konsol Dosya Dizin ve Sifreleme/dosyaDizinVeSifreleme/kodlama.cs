using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dosyaDizinVeSifreleme
{
    interface kodlama
    {
       public string sifreOlustur(string orjinalkelime);
       public string sifreCoz(string sifrelenmisKelime);
    }
}
