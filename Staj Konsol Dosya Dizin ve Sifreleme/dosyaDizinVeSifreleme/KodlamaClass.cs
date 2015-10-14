using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dosyaDizinVeSifreleme
{
    class KodlamaClass : kodlama
    {
        public string sifreOlustur(string[] orjinal)
        {

            for (int i = 0; i < orjinal.Length; i++)
            {
                orjinal[i] = "1";
                if (i % 2 == 0)
                {
                    orjinal[i] = "0";
                }
            }


            return "0";
        }

        public string sifreCoz(string sifrelenmis) { return "0"; }
    }
}
