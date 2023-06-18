using DesignPatterns.DesignPatterns.Factories.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Factories.Factory_Method
{
    internal abstract class PizzaFactoryMethod
    {
        public IPizza MakePizza()
        {
            IPizza pizza = createPizza();
            pizza.makePizza();
            return pizza;
        }
        protected abstract IPizza createPizza();
    }
}
