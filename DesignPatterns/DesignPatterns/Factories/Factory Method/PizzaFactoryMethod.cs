using DesignPatterns.DesignPatterns.Factories.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Factories.SimpleFactory
{
    internal abstract class PizzaFactoryMethod
    {
       public IPizza MakePizza(string pizzatype)
        {
            IPizza pizza= createPizza(pizzatype);
            pizza.makePizza();
            return pizza;
        }
        protected abstract IPizza createPizza(string pizzatype);
    }
}
