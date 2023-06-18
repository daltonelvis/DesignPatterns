using DesignPatterns.DesignPatterns.Factories.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Factories.SimpleFactory
{
    internal class PizzaFactory
    {
        public static IPizza MakePizza(string PizzaType)
        {
            switch(PizzaType)
            {
                case "Chicken": 
                    IPizza pchich = new ChickenPizza();
                    pchich.makePizza();
                    return pchich;
                case "Mushroom":
                    IPizza pmush = new MushroomPizza();
                    pmush.makePizza();
                    return pmush;
                case "Mutton":
                    IPizza pmutton = new MuttonPizza();
                    pmutton.makePizza();
                    return pmutton;
                default:
                    return null;
            }
        }
    }
}
