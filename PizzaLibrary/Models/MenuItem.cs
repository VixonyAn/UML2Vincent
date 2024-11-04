using PizzaLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Models
{
    public class MenuItem : IMenuItem
    {
        #region Instance Fields
        private int _no;
        private static int _counter = 0;
        #endregion

        #region Properties
        public string Description { get; set; }
        public string Name { get; set; }
        public int No { get { return _no; } }
        public double Price { get; set; }
        public MenuType TheMenuType { get; set; }
        #endregion

        #region Constructor
        public MenuItem(string name, double price, string description, MenuType menuType)
        {
            _counter++;
            _no = _counter;
            Name = name;
            Price = price;
            Description = description;
            TheMenuType = menuType;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"ID: {No}\n" +
                   $"Navn: {Name}\n" +
                   $"Pris: {Price}\n" +
                   $"Beskrivelse: {Description}\n" +
                   $"Menu Type: {TheMenuType}\n";
        }
        #endregion
    }
}
