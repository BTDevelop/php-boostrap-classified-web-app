using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public partial class Kullanici
    {
        public string urlSeoCreater
        {
            get { return Toolkit.URLConverter("-"+KullaniciId); }
        }
    }
}
