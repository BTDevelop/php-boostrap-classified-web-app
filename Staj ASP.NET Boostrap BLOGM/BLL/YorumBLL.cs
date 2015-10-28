using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class YorumBLL : GenelSablon
    {
        BlogDataContext db = new BlogDataContext();
        public void Delete(int _kategoriId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_income"></param>
        /// <returns></returns>
        public IEnumerable<Yorum> List(int _income)
        {
            return db.Yorums.Where(x => x.MakaleId == _income&&x.KullaniciId!=null).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_income"></param>
        public void Insert(params object[] _income)
        {
            Yorum _yorum = new Yorum();
            _yorum.YorumText = (string)_income[0];
            _yorum.MakaleId = (int)_income[1];
            _yorum.KullaniciId = (int)_income[2];
            _yorum.Tarih = DateTime.Now;
            db.Yorums.InsertOnSubmit(_yorum);
            db.SubmitChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Kategori> List()
        {
            throw new NotImplementedException();
        }

        public void Search(string _keyValue)
        {
            throw new NotImplementedException();
        }

        public Kategori Select(int _objectId)
        {
            throw new NotImplementedException();
        }

        public void Update(params object[] _income)
        {
            throw new NotImplementedException();
        }
    }
}
