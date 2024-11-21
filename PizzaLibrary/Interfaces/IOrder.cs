using PizzaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Interfaces
{
    public interface IOrder
    {
        int Id { get; }
        bool ToBeDelivered { get; set; }

        void AddToOrder(OrderLine line);
        double CalculateTotal();
        //void SubmitOrder();
        string PrintReciept();
        string ToString();
    }
}
