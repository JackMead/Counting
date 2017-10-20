using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.CountableItems
{
    class Box<T> : Container<T> where T : ICountable
    {
        public Box(List<T> list)
        {
            listOfItems = list;
        }
    }
}
