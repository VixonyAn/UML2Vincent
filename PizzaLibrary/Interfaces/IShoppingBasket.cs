using PizzaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Interfaces
{
    public interface IShoppingBasket
    {
        List<OrderLine> GetAll();
        int Count { get; }
        Customer Customer { get; set; }
        void AddOrderLine(OrderLine orderLine);
        OrderLine SearchOrderLineById(int id);
        void DeleteOrderLine(int id);
    }
}
