using DesignPatterns.DesignPatterns.Factories.AbstractFactory;
using DesignPatterns.DesignPatterns.Factories.Common;
using DesignPatterns.DesignPatterns.Factories.Factory_Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Factories.SimpleFactory
{
    internal class FactoryTest
    {
        public static void TestSimpleFactory()
        {

            Console.WriteLine("Simple Factory design pattern");

            IPizza pizza1 = PizzaFactory.MakePizza("Chicken");
            IPizza pizza2 = PizzaFactory.MakePizza("Mutton");
            IPizza pizza3 = PizzaFactory.MakePizza("Mushroom");

        }


        public static void TestFactoryMethod()
        {

            Console.WriteLine("Factory Method pattern");

            PizzaFactoryMethod DominosPizza = new DominosPizza();
            IPizza pizza1 = DominosPizza.MakePizza("Chicken");
            IPizza pizza2 = DominosPizza.MakePizza("Mutton");
            IPizza pizza3 = DominosPizza.MakePizza("Mushroom");


            PizzaFactoryMethod PizzahutPizza = new PizzaHutPizza();
            IPizza pizza4 = PizzahutPizza.MakePizza("Chicken");
            IPizza pizza5 = PizzahutPizza.MakePizza("Mutton");
            IPizza pizza6 = PizzahutPizza.MakePizza("Mushroom");


        }


        public static void TestAbstractFactory()
        {

            Console.WriteLine("Abstract Factory pattern");

            RestaurantAbstractFactory Dominosrest = new DominosRestuarant();
            IPizza  pizza1 = Dominosrest.MakeMuttonPizza();
            IPizza pizza2 = Dominosrest.MakeMushroomPizza();
            IPizza pizza3 = Dominosrest.MakeChickenPizza();
            IGarlicBread gb1 = Dominosrest.MakeNormalGarlicBread();
            IGarlicBread gb2 = Dominosrest.MakeExtraCheeseGarlicBread();



            RestaurantAbstractFactory PizzaHutrest = new PizzaHutRestuarant();
            IPizza pizza4 = PizzaHutrest.MakeMuttonPizza();
            IPizza pizza5 = PizzaHutrest.MakeMushroomPizza();
            IPizza pizza6 = PizzaHutrest.MakeChickenPizza();
            IGarlicBread gb3 = PizzaHutrest.MakeNormalGarlicBread();
            IGarlicBread gb4 = PizzaHutrest.MakeExtraCheeseGarlicBread();

        }

    }
}
