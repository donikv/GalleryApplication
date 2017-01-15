using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ApplicationClasses.Interfaces;
using ApplicationClasses.Models;

namespace ApplicationClasses.Repositories
{
    /// <summary>
    /// Ovo koristimo kao osnovnu podlogu za sve repozitorije. Ubacio sam ga jer sam skuzio da sam dosta copy pasteao. Kada se 
    /// modeli pocnu drasticno razlikovati, mozemo overrideati i slicno.
    /// </summary>
    /// <typeparam name="T">Model koji se nalazi u repozitoriju</typeparam>
    public abstract class DefaultSqlRepository<T> : IRepository<T> where T : Model
    {
        protected readonly GalleryDbContext _context;
        protected readonly IDbSet<T> _subContext;



        protected DefaultSqlRepository(GalleryDbContext context, IDbSet<T> subContext)
        {
            _context = context;
            _subContext = subContext;
        }

        protected void UpdateDatabase()
        {
            _context.SaveChanges();
        }

        public void Add(T item)
        {
            if (item == null)
                throw new ArgumentNullException();
            if (_subContext.Count(x => x.Id == item.Id) != 0)
                throw new ArgumentException($"This {item.GetType()} already exists in the database: {item.Id}");
            _subContext.Add(item);
            UpdateDatabase();
        }

        public T Get(Guid id)
        {
            var item = _subContext.FirstOrDefault(x => x.Id == id);
            return item;
        }

        public List<T> GetFiltered(Func<T, bool> filterFunction)
        {
            var returnList = _subContext.Where(filterFunction).OrderByDescending(x => x.Id).ToList();
            return returnList.Count == 0 ? null : returnList;
        }

        public bool Remove(Guid id, Guid userId)
        {
            var album = Get(id);
            if (album == null || !album.Id.Equals(userId))
                return false;
            _subContext.Remove(album);
            UpdateDatabase();
            return true;
        }
    }
}
