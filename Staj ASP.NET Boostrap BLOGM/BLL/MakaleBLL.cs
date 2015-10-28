using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using DAL;
namespace BLL
{
   public class MakaleBLL
    {
        /// <summary>
        /// Contextim
        /// </summary>
        BlogDataContext db = new BlogDataContext();

        /// <summary>
        /// /
        /// </summary>
        /// <param name="_gelen"></param>
        /// <returns></returns>
        public IEnumerable<Makale> Listele(ref string _gelen)
        {
            string gelen = _gelen;
            var listem = db.Makales.Where(x => x.Baslik.Contains(gelen)).OrderBy(q => q.Baslik).ToList();
            if (listem.Count == 0)
            {
                _gelen = "Listede kategori bulunamadı";
            }
            else
            {
                _gelen = "Listede " + listem.Count + " kategori bulundu";
            }

            return listem;

        }

        /// <summary>
        /// Arama işlemi linq expression ile
        /// join yapılarak arama yapıldı
        /// </summary>
        /// <param name="aranan"></param>
        /// <returns></returns>     

        public IEnumerable<Makale> Arama(string _gelen) {

            var ara = (from makale in db.Makales
                      join kullanici in db.Kullanicis on makale.KullaniciId equals kullanici.KullaniciId
                      join kategori in db.Kategoris on makale.KategoriId equals kategori.KategoriId
                      where (kullanici.Ad + " " + kullanici.Soyad).Contains(_gelen) || makale.MakaleYazi.Contains(_gelen) || kategori.KategoriAd.Contains(_gelen)
                      orderby makale.MakaleId descending
                      select makale).ToList();
            return ara;

        
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_income"></param>
        /// <returns></returns>
        public IEnumerable<Makale> Listele(int _income)
        {

            var listem = db.Makales.Where(x => x.KategoriId==_income&&x.HaberMi==false).ToList();
        

            return listem;

        }
        public IEnumerable<Makale> Listele()
        {

            var listem = db.Makales.ToList();


            return listem;

        }

        /// <summary>
        /// Makale Listeleme
        /// </summary>
        /// <param name="_gelen"></param>
        /// <returns></returns>
        public IEnumerable<Makale> Listele(bool _income)
        {
            if (_income)
            {
                return db.Makales.Where(x => x.HaberMi == false).ToList();
            }
            else
            {
                return db.Makales.Where(x => x.HaberMi == true).ToList();
            }
           

        }
       /// <summary>
       /// Ekleme yapar
       /// </summary>
       /// <param name="_Ad"></param>
        public void Ekle(string _Baslik,int _KategoriId,bool _HaberMi,string _MakaleYazi,string _Gorsel)
        {
            Makale mkl = new Makale();
            mkl.KategoriId = _KategoriId;
            mkl.Baslik = _Baslik;
            mkl.KullaniciId=1;
            mkl.MakaleYazi = _MakaleYazi;
            mkl.HaberMi = _HaberMi;
            mkl.Gorsel = _Gorsel;
            mkl.Tarih = DateTime.Today;
            db.Makales.InsertOnSubmit(mkl);
            db.SubmitChanges();

        }


        /// <summary>
        /// Kategori Silme
        /// </summary>
        /// <param name="_Id"></param>
        public void Sil(int _Id)
        {
            var makaleAra = db.Makales.Where(q => q.MakaleId == _Id).FirstOrDefault();

            if (makaleAra != null)
            {
                db.Makales.DeleteOnSubmit(makaleAra);
                db.SubmitChanges();
            }


        }


       /// <summary>
       /// 
       /// </summary>
       /// <param name="_kategoriId"></param>
       /// <returns></returns>
        public Makale Bul(int _makaleId)
        {
            return db.Makales.Where(q => q.MakaleId == _makaleId).FirstOrDefault();

        }

       /// <summary>
       /// Guncelle 
       /// </summary>
       /// <param name="_kategoriId"></param>
       /// <param name="_yeniKategori"></param>
        public void Guncelle(int _makaleId, string _yeniBaslik,int _yeniKategoriId,bool _yeniHaberMi,string _yeniMakaleYazi,string _yeniGorsel)
        {
            var _makalemiz = db.Makales.Where(q => q.MakaleId == _makaleId).FirstOrDefault();

            if (_makalemiz != null)
            {
                _makalemiz.Baslik = _yeniBaslik;
                _makalemiz.KategoriId = _yeniKategoriId;
                _makalemiz.HaberMi = _yeniHaberMi;
                _makalemiz.MakaleYazi = _yeniMakaleYazi;
                _makalemiz.Gorsel = _yeniGorsel;
                db.SubmitChanges();
            }
        }


    }
}
