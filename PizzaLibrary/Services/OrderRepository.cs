using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaLibrary.Models;
using PizzaLibrary.Interfaces;

namespace PizzaLibrary.Services
{
    public class OrderRepository : IOrderRepository
    {
        private List<Order> _orderList;

        public int Count { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order GetOrderById(int id)
        {
            throw new NotImplementedException();
        }

        public void PrintAllOrders()
        {
            throw new NotImplementedException();
        }

        public void RemoveOrder(int id)
        {
            throw new NotImplementedException();
        }
    }
}
