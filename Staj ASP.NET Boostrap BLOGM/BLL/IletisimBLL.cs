using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using System.Text;

namespace BLL
{
    public class IletisimBLL
    {
        BlogDataContext db = new BlogDataContext();
        public void Insert(string _Email, string _Ad, string _Soyad, DateTime _Tarih, string _Mesaj)
        {
            Iletisim ilt = new Iletisim();
            ilt.Eposta = _Email;
            ilt.Ad = _Ad;
            ilt.Soyad = _Soyad;
            ilt.Tarih = _Tarih;
            ilt.Icerik = _Mesaj;
            db.Iletisims.InsertOnSubmit(ilt);
            db.SubmitChanges();

        }
        public IEnumerable<Iletisim> List()
        {
            return db.Iletisims.ToList();
        }
    }
}
