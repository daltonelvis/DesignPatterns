using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Builder
{
    internal class Computer
    {
        public int Ram { get; set; }
        public string HddSize { get; set; }

        public string keyboard { get; set; }

        public string mouse { get; set; }

        public string touchscreen { get; set; }

        public Computer(int memory, string harddisk)
        {
            Ram = memory;
            HddSize = harddisk;
        }

        public override string ToString()
        {
            return "Ram=" + this.Ram + " HDD=" + this.HddSize + " Keyboard=" + this.keyboard + " Mouse=" + this.mouse + " touchscreen=" + this.touchscreen;
        }



    }
}
