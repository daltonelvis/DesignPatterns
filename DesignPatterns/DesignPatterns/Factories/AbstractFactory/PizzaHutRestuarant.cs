using DesignPatterns.DesignPatterns.Factories.Common;
using DesignPatterns.DesignPatterns.Factories.Factory_Method;
using DesignPatterns.DesignPatterns.Factories.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Factories.AbstractFactory
{
    internal class PizzaHutRestuarant : RestaurantAbstractFactory
    {
        public override IPizza MakeChickenPizza()
        {

            IPizza piz = new PizzaHutChickenPizza();
            piz.makePizza();
            return piz;
        }

        public override IPizza MakeMushroomPizza()
        {

            IPizza piz = new PizzaHutMushroomPizza();
            piz.makePizza();
            return piz;
        }

        public override IPizza MakeMuttonPizza()
        {

            IPizza piz = new PizzaHutMuttonPizza();
            piz.makePizza();
            return piz;
        }

        public override IGarlicBread MakeNormalGarlicBread()
        {

            IGarlicBread gb = new PizzaHutNormalGB();
            gb.makeGarlicBread();
            return gb;
        }

        public override IGarlicBread MakeExtraCheeseGarlicBread()
        {
            IGarlicBread gb = new PizzaHutExtraCheeseGB();
            gb.makeGarlicBread();
            return gb;
        }
    }
}
