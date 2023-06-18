using DesignPatterns.DesignPatterns.Factories.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Factories.AbstractFactory
{
    internal abstract class RestaurantAbstractFactory
    {
        public abstract IGarlicBread MakeNormalGarlicBread();
        public abstract IGarlicBread MakeExtraCheeseGarlicBread();

        public abstract IPizza MakeChickenPizza();
        public abstract IPizza MakeMuttonPizza();
        public abstract IPizza MakeMushroomPizza();

    }
}
