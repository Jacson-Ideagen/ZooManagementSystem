using System.Collections.Generic;
using Zoo.BusinessLogic.Interfaces;

namespace Zoo.BusinessLogic.Models
{
    public class box<T> : ICountable
    {
        public box(List<T> _items = null)
        {
            items = new List<T>();

            if (_items != null)
            {
                items = _items;
            }
        }

        public List<T> items;
        public int Count
        {
            get
            {
                return items.Count;
            }
        }
    }
}
