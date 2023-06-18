using DesignPatterns.DesignPatterns.Factories.Common;
using DesignPatterns.DesignPatterns.Factories.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Factories.Factory_Method
{
    internal class MushroomPizzaFactory : PizzaFactoryMethod
    {
        protected override IPizza createPizza()
        {
            IPizza pizza = new MushroomPizza();
            return pizza;
        }
    }
}
