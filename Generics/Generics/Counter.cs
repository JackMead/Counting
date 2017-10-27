using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Counter<T> where T : ICountable
    {
        public int Count { get; set; }
        public delegate bool IsWorthCounting(ICountable item);
        public IsWorthCounting shouldCount;

        public Counter()
        {
            Count = 0;
            shouldCount = (item) => true;
        }

        public Counter(IsWorthCounting count)
        {
            Count = 0;
            shouldCount = count;
        }

        public void Add(T item)
        {
            if (shouldCount(item))
            {
                Count += item.Count();

            }
        }
    }
}
