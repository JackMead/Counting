using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics.CountableItems;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var aFewApples = new List<ICountable> {new Apple(), new Apple(), new Apple()};
            var lotsOfApples = new List<ICountable> { };
            var anAwfulLotOfApples = new List<ICountable> { };
            for (int i = 0; i < 20; i++)
            {
                if (i < 10)
                {
                    lotsOfApples.Add(new Apple());
                }
                anAwfulLotOfApples.Add(new Apple());
            }
            var massiveBox = new Box<ICountable>(anAwfulLotOfApples);
            var largeBox = new Box<ICountable>(lotsOfApples);
            var smallBox = new Box<ICountable>(aFewApples);
            var allBoxes = new List<Box<ICountable>>
            {
                smallBox,
                largeBox,
                massiveBox
            };

            var cart = new Cart<ICountable>(allBoxes);

            var appleCounter = new Counter<Apple>();
            appleCounter.Add(new Apple());
            Console.WriteLine("A single apple has a count of " + appleCounter.Count);

            var cartCounter = new Counter<Cart<ICountable>>();
            cartCounter.Add(cart);
            Console.WriteLine("Our cart has a total count of : "+cartCounter.Count);

            var boxCounter = new Counter<Box<ICountable>>();
            boxCounter.Add(smallBox);
            boxCounter.Add(massiveBox);
            Console.WriteLine("Our box counter found there were a total of "+boxCounter.Count+" items in the small and massive boxes combined");
        }
    }
}
