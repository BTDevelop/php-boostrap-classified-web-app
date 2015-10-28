using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public partial class Yorum
    {
        public string YorumYapan
        {
            get { return Kullanici.Ad + " " + Kullanici.Soyad; }
        }

        public int YorumYapanId
        {
            get { return Kullanici.KullaniciId; }
        }

    }
}
