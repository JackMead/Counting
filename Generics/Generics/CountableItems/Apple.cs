using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.CountableItems
{
    class Apple : ICountable
    {
        public string Colour { get; }
        public static Random rand = new Random();

        public Apple()
        {
            Colour = rand.Next(0, 2) == 1 ? "Red" : "Green";
        }

        public int Count()
        {
            return 1;
        }
    }
}
