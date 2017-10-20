using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.CountableItems
{
    class Apple : ICountable
    {
        public int Count()
        {
            return 1;
        }
    }
}
