using System;
using System.Collections.Generic;
using ApplicationClasses.Models;

namespace ApplicationClasses.Interfaces
{
    /// <summary>
    /// Ovo je generalno sucelje za rukovanje jednim od objekata koje imamo, mislim da mozemo
    /// biti sigurni da ce se ove metode koristiti u svima.
    /// Nisam pisao posebne komentare za ostala sucelja koja ovo nasljeduju jer je vise manje jasno cemu sluze
    /// i zasto postoje.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : Model
    {
        T Get(Guid id);
        void Add(T item);
        bool Remove(Guid id, Guid userId);
        List<T> GetFiltered(Func<T, bool> filterFunction);
    }
}
