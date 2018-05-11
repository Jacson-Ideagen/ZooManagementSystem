using System.Collections.Generic;
using System.Linq;
using Zoo.BusinessLogic.Interfaces;

namespace Zoo.BusinessLogic.Models
{
    public class cart<T> : ICountable
    {
        public cart(List<box<T>> _load = null)
        {
            load = new List<box<T>>();

            if (_load != null)
            {
                load = _load.ToList();
            }
        }

        public List<box<T>> load { get; set; }

        public int Count
        {
            get
            {
                var _count = 0;
                foreach(var bx in load)
                {
                    _count += bx.Count;
                }
                return _count;
            }
        }
    }
}
