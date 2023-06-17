using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Factories
{
    internal class HotDrinkFactory
    {

        //simple Factory
        public void PrepareHotDrink(string drinktype)
        {
            if (drinktype == "TEA")
            {
                Tea tea = new Tea();
                tea.PrepareDrink();
            }
            if (drinktype == "COFFEE")
            {
                Coffee cof = new Coffee();
                cof.PrepareDrink();
            }
        }
    }
}
