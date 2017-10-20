using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.CountableItems
{
    abstract class Container<T> : ICountable where T:ICountable
    {
        protected List<T> listOfItems;

        protected Container()
        {
            listOfItems= new List<T>();
        }

        public int Count()
        {
            return listOfItems.Sum(countable => countable.Count());
        }
    }
}
