using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Factories
{
    internal class FactoryTest
    {
        public static void TestSimpleFactory()
        {

            Console.WriteLine("Factory Design pattern");

            Console.WriteLine("Simple Factory");

            HotDrinkFactory Teadrink = new HotDrinkFactory();
            Teadrink.PrepareHotDrink("TEA");


            HotDrinkFactory coffeeDrink = new HotDrinkFactory();
            coffeeDrink.PrepareHotDrink("COFFEE");

        }
    }
}
