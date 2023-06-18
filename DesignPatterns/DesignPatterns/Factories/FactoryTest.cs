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

            Console.WriteLine("------------Simple Factory design pattern----------------");

            IPizza pizza1 = PizzaFactory.MakePizza("Chicken");
            IPizza pizza2 = PizzaFactory.MakePizza("Mushroom");

        }


        public static void TestFactoryMethod()
        {

            Console.WriteLine("-------------Factory Method pattern--------------------");

            PizzaFactoryMethod chicken = new ChickenPizzaFactory();
            chicken.MakePizza();
            PizzaFactoryMethod mushroom = new MushroomPizzaFactory();
            mushroom.MakePizza();


        }


        public static void TestAbstractFactory()
        {

            Console.WriteLine("-------------------Abstract Factory pattern--------------------");

            PizzaCompanyAbstractFactory Dominos = new DominosPizzaCompany();
            Dominos.MakeMushroomPizza();
            Dominos.MakeChickenPizza();

            PizzaCompanyAbstractFactory PizzaHut = new PizzaHutPizzaCompany();
            PizzaHut.MakeMushroomPizza();
            PizzaHut.MakeChickenPizza();

        }

    }
}
