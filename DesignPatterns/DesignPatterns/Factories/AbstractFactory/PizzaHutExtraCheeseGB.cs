using DesignPatterns.DesignPatterns.Factories.AbstractFactory;
using DesignPatterns.DesignPatterns.Factories.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Factories.SimpleFactory
{
    internal class PizzaHutExtraCheeseGB: IGarlicBread
    {
        public void makeGarlicBread()
        {
            Console.WriteLine("PizzaHut Extra Cheese Garlic Bread is Ready");
        }

    }
}
