using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PizzaLibrary.Models
{
    public class VIPCustomer : Customer
    {
        public int Discount { get; set; }
        
        public VIPCustomer(string name, string mobile, string city, string address, int discount) : base(name, mobile, city, address)
        {
                Discount = discount;
        }
        public override string ToString()
        {
            return $"ID: {Id}\n" +
                   $"Navn: {Name}\n" +
                   $"Mobil: {Mobile}\n" +
                   $"By: {City}\n" +
                   $"Adresse: {Address}\n" +
                   $"VIP Status: True\n" +
                   $"Rabat: {Discount}%\n";
        }
    }
}
