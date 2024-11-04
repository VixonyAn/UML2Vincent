using PizzaLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Models
{
    public class Customer : ICustomer
    {
        #region Instance Fields
        private int _id;
        public static int _counter = 0;
        #endregion

        #region Properties
        public string Address { get; set; }
        public bool ClubMember { get; set; }
        public int Id { get { return _id; } }
        public string Mobile { get; set; }
        public string Name { get; set; }
        #endregion

        #region Constructor
        public Customer(string name, string mobile, string address)
        {
            _counter++;
            _id = _counter;
            Name = name;
            Mobile = mobile;
            Address = address;
            ClubMember = false;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"ID: {Id}\n" +
                   $"Navn: {Name}\n" +
                   $"Mobil: {Mobile}\n" +
                   $"Adresse: {Address}\n" +
                   $"Medlem Status: {ClubMember}\n";
        }
        #endregion
    }
}
