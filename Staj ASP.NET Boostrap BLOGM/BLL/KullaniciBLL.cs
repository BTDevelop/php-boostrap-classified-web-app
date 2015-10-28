using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using DAL;


namespace BLL
{

    public class KullaniciBLL : GenelSablon
    {

        BlogDataContext db = new BlogDataContext();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_kategoriId"></param>
        public void Delete(int _kategoriId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Silme işlemi
        /// </summary>
        /// <param name="_Id"></param>
        public void Sil(int _Id)
        {
            var _kullaniciAra = db.Kullanicis.Where(q => q.KullaniciId == _Id).FirstOrDefault();

            if (_kullaniciAra != null)
            {
                _kullaniciAra.Deleted = true;
                db.SubmitChanges();
            }
        }

        /// <summary>
        /// Listeleme Arama
        /// </summary>
        /// <param name="_income"></param>
        /// <returns></returns>
        public IEnumerable<Kullanici> Listed(ref string _income)
        {
            string gelen = _income;
            var listem = db.Kullanicis.Where(x => x.EPosta.Contains(gelen) && x.Rol != true).OrderBy(q => q.EPosta).ToList();
            if (listem.Count == 0)
            {
                _income = "Listede kategori bulunamadı";
            }
            else
            {
                _income = "Listede " + listem.Count + " kategori bulundu";
            }

            return listem;
        }

        /// <summary>
        /// Listeleme
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Kullanici> Listed(string _income)
        {
            if (_income == "1")
            {
                return db.Kullanicis.Where(x => x.Rol == false && x.Deleted == false).ToList();
            }
            else
            {
                return db.Kullanicis.Where(x => x.Rol == null).ToList();
            }
        }
        public Kullanici Search(int _kullaniciId)
        {
            return db.Kullanicis.Where(q => q.KullaniciId == _kullaniciId).FirstOrDefault();

        }

        /// <summary>
        /// Listeleme Boş
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Kullanici> Listed()
        {
            return db.Kullanicis.Where(x => x.Rol == false && x.Deleted == false).ToList();
        }
        /// <summary>
        /// Şifre Değişimi
        /// </summary>
        /// <param name="_ıd"></param>
        /// <param name="_password"></param>
        public void PasswordChange(int _Id, string _password)
        {
            var _kontrol = db.Kullanicis.Where(q => q.KullaniciId == _Id).FirstOrDefault();
            if (_kontrol != null)
            {
                _kontrol.Sifre = _password;
                db.SubmitChanges();
            }

        }
        /// <summary>
        /// Arama
        /// </summary>
        /// <param name="_keyValue"></param>
        public void Search(string _keyValue)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Seçim
        /// </summary>
        /// <param name="_objectId"></param>
        /// <returns></returns>
        public Kategori Select(int _objectId)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Kullanıcı Aktifleştirme veya Dondurma
        /// </summary>
        /// <param name="_Id"></param>
        /// <param name="_income"></param>
        public void UserDeactive(int _Id, bool _income)
        {
            if (_income == true)
            {
                var _kontrol = db.Kullanicis.Where(q => q.KullaniciId == _Id).FirstOrDefault();
                if (_kontrol != null)
                {
                    _kontrol.Rol = false;
                    db.SubmitChanges();

                }
            }
            else
            {
                var _kontrol = db.Kullanicis.Where(q => q.KullaniciId == _Id).FirstOrDefault();
                if (_kontrol != null)
                {
                    _kontrol.Rol = null;
                    db.SubmitChanges();

                }
            }
        }



        /// <summary>
        /// Kullanıcı Güncelleme
        /// </summary>
        /// <param name="_Id"></param>
        /// <param name="_name"></param>
        /// <param name="_surname"></param>
        public void UserUpdate(int _Id, string _name, string _surname)
        {
            var _kontrol = db.Kullanicis.Where(q => q.KullaniciId == _Id).FirstOrDefault();
            if (_kontrol != null)
            {
                _kontrol.Ad = _name;
                _kontrol.Soyad = _surname;
                db.SubmitChanges();
            }
        }
        /// <summary>
        /// Giriş Yapma Kontrolü
        /// </summary>
        /// <param name="_kullaniciAdi"></param>
        /// <returns></returns>
        public bool GirisYapsinMi(string _kullaniciAdi)
        {
            var _kontrol = db.Kullanicis.FirstOrDefault(q => q.EPosta == _kullaniciAdi);
            if (_kontrol != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Giriş Yapma Kontrolü
        /// </summary>
        /// <param name="_kullaniciAdi"></param>
        /// <param name="_sifre"></param>
        /// <returns></returns>
        public bool GirisYapsinMi(string _kullaniciAdi, string _sifre)
        {
            var _kontrol = db.Kullanicis.FirstOrDefault(q => q.EPosta == _kullaniciAdi && q.Sifre == _sifre && q.Rol == true);
            if (_kontrol != null)
            {

                HttpContext.Current.Session["Yetkili"] = _kontrol;
                HttpContext.Current.Session["YetkiliAd"] = _kontrol.Ad;

                return false;
            }
            else
            {
                return true;
            }

        }
        /// <summary>
        /// Uye Kullanıcı Giriş Kontrolü
        /// </summary>
        /// <param name="_kullaniciAdi"></param>
        /// <param name="_sifre"></param>
        /// <returns></returns>
        public bool UyeGirisYapsinMi(string _kullaniciAdi, string _sifre)
        {
            var _kontrol = db.Kullanicis.FirstOrDefault(q => q.EPosta == _kullaniciAdi && q.Sifre == _sifre);
            if (_kontrol != null)
            {

                HttpContext.Current.Session["Uye"] = _kontrol;
                HttpContext.Current.Session["UyeAd"] = _kontrol.Ad;

                return false;
            }
            else
            {
                return true;
            }

        }
        /// <summary>
        /// Güncelleme
        /// </summary>
        /// <param name="_income"></param>
        public void Update(params object[] _income)
        {
            var _kullanicim = db.Kullanicis.Where(q => q.KullaniciId == (int)_income[0]).FirstOrDefault();

            if (_kullanicim != null)
            {
                _kullanicim.SonTarayici = (string)_income[1];
                _kullanicim.SonIP = (string)_income[2];
                _kullanicim.SonGirisTarihi = DateTime.Now;
                db.SubmitChanges();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_income"></param>
        public void Insert(params object[] _income)
        {
            Kullanici _kullanici = new Kullanici();
            _kullanici.Ad = (string)_income[0];
            _kullanici.Soyad = (string)_income[1];
            _kullanici.EPosta = (string)_income[2];
            _kullanici.Sifre = (string)_income[3];
            _kullanici.SonGirisTarihi = DateTime.Now;
            _kullanici.GUID = (string)_income[4];
            db.Kullanicis.InsertOnSubmit(_kullanici);
            db.SubmitChanges();
        }


        IEnumerable<Kategori> GenelSablon.List()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_GUID"></param>
        /// <returns></returns>
        public bool MemberActivation(string _GUID)
        {
            var _user = db.Kullanicis.Where(q => q.GUID == _GUID).FirstOrDefault();
            if (_user != null && _user.Rol == null)
            {
                _user.Rol = false;
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
