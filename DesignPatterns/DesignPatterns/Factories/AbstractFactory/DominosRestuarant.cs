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
    internal class DominosRestuarant : RestaurantAbstractFactory
    {
        public override IPizza MakeChickenPizza()
        {
            IPizza piz = new DominosChickenPizza();
            piz.makePizza();
            return piz;
        }

        public override IPizza MakeMushroomPizza()
        {
            IPizza piz = new DominosMushroomPizza();
            piz.makePizza();
            return piz;
        }

        public override IPizza MakeMuttonPizza()
        {
            IPizza piz = new DominosMuttonPizza();
            piz.makePizza();
            return piz;
        }

        public override IGarlicBread MakeNormalGarlicBread()
        {
            IGarlicBread gb = new DominosNormalGB();
            gb.makeGarlicBread();
            return gb;
        }

        public override IGarlicBread MakeExtraCheeseGarlicBread()
        {
            IGarlicBread gb = new DominosExtraCheeseGB();
            gb.makeGarlicBread();
            return gb;
        }
    }
}
