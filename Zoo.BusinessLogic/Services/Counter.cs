using Zoo.BusinessLogic.Interfaces;
using Zoo.BusinessLogic.Models;

namespace Zoo.BusinessLogic.Services
{
    public class Counter<T> where T : ICountable
    {
        public int Count { get; set; }
        public void Add(T item)
        {
            Count += item.Count;
        }
    }
}
