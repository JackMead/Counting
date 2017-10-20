using System;

namespace Generics.CountableItems
{
    class BagOfApples : ICountable
    {
        public int Count()
        {
            return new Random().Next(30, 50);
        }
    }
}
