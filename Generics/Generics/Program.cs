using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
            //HERE WE ONLY COUNT RED APPLES
            var redAppleCounter = new Counter<Apple>((apple) => ((Apple) apple).Colour == "Red" ? true : false);
            redAppleCounter.Add(new Apple());
            redAppleCounter.Add(new Apple());
            redAppleCounter.Add(new Apple());
            Console.WriteLine("We had {0} red apples in that bunch", redAppleCounter.Count);



            var cartCounter = new Counter<Cart<ICountable>>();
            cartCounter.Add(cart);
            Console.WriteLine("Our cart has a total count of : "+cartCounter.Count);

            var boxCounter = new Counter<Box<ICountable>>();
            boxCounter.Add(smallBox);
            boxCounter.Add(massiveBox);
            Console.WriteLine("Our box counter found there were a total of "+boxCounter.Count+" items in the small and massive boxes combined");

            var listOfBagsOfApples = new List<ICountable> {new BagOfApples(), new BagOfApples(), new BagOfApples()};
            var boxOfBagsOfApples = new Box<ICountable>(listOfBagsOfApples);
            Console.WriteLine("A box full of bags of apples has {0} items in!",boxOfBagsOfApples.Count());

            
        }
    }
}
