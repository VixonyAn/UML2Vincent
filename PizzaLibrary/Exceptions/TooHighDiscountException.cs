using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Exceptions
{
    public class TooHighDiscountException : Exception
    {
        //Lav en ny Exception klasse TooHighDiscountException,
        //som kastes, hvis man forsøger, at oprette
        //en VIPCustomer der får for meget rabat.
        public TooHighDiscountException()
        {
        }

        public TooHighDiscountException(string message)
            : base(message)
        {
        }
    }
}
