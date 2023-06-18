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
    internal class DominosPizzaCompany : PizzaCompanyAbstractFactory
    {
        public override IPizza MakeChickenPizza()
        {
            IPizza pizza = new DominosChickenPizza();
            pizza.makePizza();
            return pizza;
        }

        public override IPizza MakeMushroomPizza()
        {
            IPizza pizza = new DominosMushroomPizza();
            pizza.makePizza();
            return pizza;
        }
    }
}
