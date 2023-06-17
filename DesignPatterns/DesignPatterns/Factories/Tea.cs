using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Factories
{
    internal class Tea : IHotDrink
    {
        public void PrepareDrink()
        {
            Console.WriteLine("Preparing Tea");
        }
    }
}
