using System;

namespace ApplicationClasses.Models
{
    /// <summary>
    /// Ovu klasu sam morao dodati kako bi DefaultSqlRepository mogao raditi, jedina posljedica 
    /// toga je da ce svaki objekt u sustavu imati drukciji id, bez obzira na tip
    /// (a mislim da je, obzirom da se radi o guidu, tako bilo i prije)
    /// </summary>
    public abstract class Model
    {
        public Guid Id { get; set; }
    }
}
