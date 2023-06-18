using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Factories.AbstractFactory
{
    internal class DominosNormalGB : IGarlicBread
    {
        public void makeGarlicBread()
        {
            Console.WriteLine("Dominos Normal Garlic Bread is Ready");
        }

    }
}

