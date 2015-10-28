using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public partial class Makale
    {
        public string Kategorisi
        {
            get { return Kategori.KategoriAd; }
        }

        public string urlSeoCreater
        {

            get { return Toolkit.URLConverter(Kategori.KategoriId + "/" + Baslik + "-" + MakaleId); }
        }

        public int YorumSayisi
        {
            get { return Yorums.Count(); }

        }



        public string MakaleOzet
        {
            get
            {
                if (MakaleYazi.Length > 100)
                {
                    return Toolkit.StripHtmlTags(MakaleYazi).Substring(0, 95);
                }
                else
                {
                    return MakaleYazi;
                }

            }

        }
    }
}
