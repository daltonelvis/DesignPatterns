using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Factories
{
    internal class Coffee : IHotDrink
    {
        public void PrepareDrink()
        {
            Console.WriteLine("Preparing Coffee");
        }
    }
}
