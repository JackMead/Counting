using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.CountableItems
{
    class Cart<T> : Container<Box<T>> where T:ICountable
    {
        public Cart(List<Box<T>> list)
        {
            listOfItems = list;
        }
    }
}
