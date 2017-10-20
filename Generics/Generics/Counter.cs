using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Counter<T> where T:ICountable
    {
        public int Count { get; set; }

        public Counter()
        {
            Count = 0;
        }

        public void Add(T item)
        {
            Count += item.Count();
        }
    }
}
