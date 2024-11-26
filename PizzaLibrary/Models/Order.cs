using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaLibrary.Interfaces;

namespace PizzaLibrary.Models
{
    public class Order : IOrder
    { // This is the entire reciept
        #region Instance Fields
        private List<OrderLine> _lines;
        private Customer _customer;
        private DateTime _created;
        public static int _counter = 0;
        #endregion

        #region Properties
        //public List<OrderLine> Lines { get; set; }
        public Customer Customer { get; set; }
        public DateTime Created { get; set; }
        public int Id { get; }
        public bool ToBeDelivered { get; set; } // spørg om bool, bruges ikke lige nu
        #endregion

        #region Constructor
        public Order() { }
        public Order(Customer customer)
        {
            _counter++;
            Id = _counter;
            _lines = new List<OrderLine>();
            Customer = customer;
            Created = DateTime.Now; // spørg om placering
        }
        #endregion

        #region Methods
        public void AddToOrder(OrderLine line)
        { // tilføj til order
            _lines.Add(line);
        }
        public double CalculateTotal()
        { // alle items pris lægges sammen
            double total = 0.0;
            foreach (OrderLine line in _lines)
            {
                total += line.SubTotal();
            }
            return total;
        }
        //public void SubmitOrder() {}
        public string PrintReciept()
        {
            string result = ""; // empty string for storage
            foreach (OrderLine line in _lines) // adds each orderline to a list? string?
            {
                result += line.ToString();
            }
            result += CalculateTotal(); // adds the subtotal
            return result;
        }
        public override string ToString() // spørg om denne
        {
            return $"Big Mamma Pizzeria\n" +
                   $"{PrintReciept}\n" +
                   $"{Id} {Created}\n";
        }
        #endregion
    }
}
