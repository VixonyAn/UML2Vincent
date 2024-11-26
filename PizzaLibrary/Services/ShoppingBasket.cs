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
        public int Count { get { return _orderLines.Count; } }
        public Customer Customer { get; set; }

        public ShoppingBasket()
        {
            _orderLines = new List<OrderLine>();
        }

        public void AddOrderLine(OrderLine line)
        {
            line.Id = _orderLines.Count;
            _orderLines.Add(line);
        }

        public OrderLine SearchOrderLineById(int id)
        {
            foreach (OrderLine orderLine in _orderLines)
            {
                if (id == orderLine.Id)
                {
                    return orderLine;
                }
            }
            return null; // Ignore this, it's okay
        }

        public void DeleteOrderLine(int id)
        {
            _orderLines.RemoveAt(id);
            for (int i = id; i < _orderLines.Count; i++)
            {
                _orderLines[i].Id = i;
            }
        }

        public List<OrderLine> GetAll()
        {
            return _orderLines;
        }
    }
}
