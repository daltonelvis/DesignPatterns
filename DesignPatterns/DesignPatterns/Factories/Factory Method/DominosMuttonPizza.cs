﻿using DesignPatterns.DesignPatterns.Factories.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Factories.SimpleFactory
{
    internal class DominosMuttonPizza : IPizza
    {
        public void makePizza()
        {
            Console.WriteLine("Dominos Mutton Pizza Ready");
        }
    }
}
