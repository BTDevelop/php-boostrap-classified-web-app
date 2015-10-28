using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class KategoriBLL
    {
        BlogDataContext db = new BlogDataContext();
        /// <summary>
        /// Kategori Listele
        /// </summary>
        /// <returns></returns>

        public IEnumerable<Kategori> Listele(ref string _gelen)
        {
            string gelen = _gelen;
            var listem = db.Kategoris.Where(x => x.KategoriAd.Contains(gelen)).OrderBy(q => q.KategoriAd).ToList();
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
        /// Kategori Ekle
        /// </summary>
        /// <param name="_Ad"></param>
        public void Ekle(string _Ad)
        {
            Kategori ktg = new Kategori();
            ktg.KategoriAd = _Ad;
            db.Kategoris.InsertOnSubmit(ktg);
            db.SubmitChanges();

        }
        /// <summary>
        /// Kategori Silme
        /// </summary>
        /// <param name="_Id"></param>
        public void Sil(int _Id)
        {
            var kategoriAra = db.Kategoris.Where(q => q.KategoriId == _Id).FirstOrDefault();

            if (kategoriAra != null)
            {
                db.Kategoris.DeleteOnSubmit(kategoriAra);
                db.SubmitChanges();
            }


        }
        /// <summary>
        /// Kategori Günceller
        /// </summary>
        /// <param name="_kategoriId"></param>
        /// <param name="_yeniKategori"></param>
        public void Guncelle(int _kategoriId, string _yeniKategori)
        {
            var _kategorimiz = db.Kategoris.Where(q => q.KategoriId == _kategoriId).FirstOrDefault();

            if (_kategorimiz != null)
            {
                _kategorimiz.KategoriAd = _yeniKategori;
                db.SubmitChanges();
            }
        }
        /// <summary>
        /// Bul
        /// </summary>
        /// <param name="_kategoriId"></param>
        /// <returns></returns>
        public Kategori Bul(int _kategoriId)
        {
            return db.Kategoris.Where(q => q.KategoriId == _kategoriId).FirstOrDefault();

        }
        /// <summary>
        /// Listele boş
        /// </summary>
        /// <param name="_gelen"></param>
        /// <returns></returns>
        public IEnumerable<Kategori> Listele()
        {

            return db.Kategoris.OrderBy(q => q.KategoriAd).ToList();

        }

    }
}


