using System.Collections.Generic;

namespace Podcast.Business_logic_layer
{
    public abstract class Entities<T>
    {
        public virtual List<T> List { get; set; }
        public virtual void AddToList(T obj)
        {
            List.Add(obj);
        }

        public virtual List<T> GetList()
        {
            return List;
        }
    }
}
