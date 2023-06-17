using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Builder
{
    internal class ComputerBuilder
    {

        Computer systemb;
        public ComputerBuilder(int ram, string harddisk)
        {
            systemb = new Computer(ram, harddisk);
        }
        //above ram and CPU is common in both laptop and desktop.
        //below are option example desktop can have keyboard and mouse but laptop can have touch screen
        public ComputerBuilder AddKeyboard(string keyboard)
        {
            systemb.keyboard = keyboard;
            return this;
        }

        public ComputerBuilder AddMouse(string mouse)
        {
            systemb.mouse = mouse;
            return this;
        }

        public ComputerBuilder AddTouchscreen(string touchscreen)
        {
            systemb.touchscreen = touchscreen;
            return this;
        }

        public Computer Build()
        {
            return systemb;
        }
    }

}
