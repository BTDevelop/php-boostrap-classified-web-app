using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

/// <summary>
/// this inreface CRUD (create,read,update,delete) 
/// </summary>
namespace BLL
{
    public interface GenelSablon
    {

        // BlogDataContext db = new BlogDataContext();

        /// <summary>
        /// 
        /// </summary>
        void Insert(params object[] _income);

        /// <summary>
        ///  Rets a spesific object
        /// </summary>
        Kategori Select(int _objectId);
        /// <summary>
        /// rets list of object
        /// </summary>
        /// <returns></returns>
        IEnumerable<Kategori> List();

        /// <summary>
        /// Searching a spesific object inside object
        /// rets the list of object
        /// </summary>
        /// <param name="_keyValue"></param>
        /// <returns></returns>
        void Search(string _keyValue);

        /// <summary>
        /// rets and update this spesific object
        /// </summary>
        /// <param name="_kategoriId"></param>
        void Update(params object[] _income);

        /// <summary>
        /// gets and deletes th espesific object
        /// </summary>
        /// <param name="_kategoriId"></param>
        void Delete(int _kategoriId);
    }
}
