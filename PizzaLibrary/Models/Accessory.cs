using PizzaLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PizzaLibrary.Models
{
    public class Accessory : IAccessory
    {
        private int _id;
        public static int _counter = 0;
        private string _name;
        private double _price;

        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public double Price { get { return _price; } set { _price = value; } }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
