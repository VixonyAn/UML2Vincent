using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Exceptions
{
    public class MenuItemNumberExist : Exception
    {
        //Test at der kastes et objekt af typen MenuItemNumberExist.
        //Overvej hvor skal objektet kastes og hvor skal det samles op(catch).
        //Er der brug for flere catch sektioner?
        //Test til at starte med fra consol applikation.
        //Indbyg det i din menu
        public MenuItemNumberExist()
        {
        }

        public MenuItemNumberExist(string message)
            : base(message)
        {
        }
    }
}
