using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Builder
{
    internal class BuilderTest
    {

        

        public static void TestBuilderexample()
        {

            Console.WriteLine("------------Builder Design pattern-------------------");

            Console.WriteLine("Create a laptop");
            Computer Laptop = new ComputerBuilder(8, "1TB").AddTouchscreen("Samsung Touch").Build();
            Console.WriteLine("laptop: " + Laptop.ToString());


            Console.WriteLine("Create a Desktop");
            Computer Desktop = new ComputerBuilder(16, "500GB").AddKeyboard("US Keyboard").AddMouse("Gaming Mouse").Build();
            Console.WriteLine("Desktop: " + Desktop.ToString());
        }
    }
}
