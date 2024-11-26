using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;

namespace PizzaLibrary.Services
{
    public class ShoppingBasket : IShoppingBasket
    {
        private List<OrderLine> _orderLines;
        public Customer Customer { get; set; }

        public ShoppingBasket()
        {
            _orderLines = new List<OrderLine>();
        }

        public void AddOrderLine(OrderLine orderLine)
        {
            _orderLines.Add(orderLine);
        }

        public List<OrderLine> GetAll()
        {
            return _orderLines;
        }
    }
}
