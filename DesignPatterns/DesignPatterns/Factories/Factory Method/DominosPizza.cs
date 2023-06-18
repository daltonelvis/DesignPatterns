using DesignPatterns.DesignPatterns.Factories.Common;
using DesignPatterns.DesignPatterns.Factories.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Factories.Factory_Method
{
    internal class DominosPizza : PizzaFactoryMethod
    {
        protected override IPizza createPizza(string pizzatype)
        {
            switch (pizzatype)
            {
                case "Chicken":
                    return new DominosChickenPizza();
                case "Mushroom":
                    return new DominosMushroomPizza();
                case "Mutton":
                    return new DominosMuttonPizza();
                default:
                    return null;
            }
        }
    }
}
