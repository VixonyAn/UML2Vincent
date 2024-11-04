using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Exceptions
{
    public class CustomerMoblieNumberExist : Exception
    {
        //Hvis der tilføjes en  Customer til CustomerRepository,
        //som har et nummer, som allerede eksisterer skal der
        //kastes en exception af typen CustomerMoblieNumberExist.
        public CustomerMoblieNumberExist()
        {
        }

        public CustomerMoblieNumberExist(string message)
            : base(message)
        {
        }
    }
}
