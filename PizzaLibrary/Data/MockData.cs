﻿using PizzaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Data
{
    public static class MockData
    {
        #region Instance fields
        private static Dictionary<string, Customer> _customerData =
            new Dictionary<string, Customer>()
            {
            { "12121212", new Customer("Mikkel", "12121212", "Roskilde", "Street 123") },
            { "13131313", new Customer("Charlotte", "13131313", "Roskilde", "Avenue 321") },
            { "14141414", new Customer("Carina", "14141414", "Roskilde", "High Street 234") },
            { "15151515", new Customer("Muhammed", "15151515", "Ringsted", "North Street 345") }
            };

        private static List<MenuItem> _menuItemData =
            new List<MenuItem>()
            {
            new MenuItem("Margherita", 85, "Tomat, ost", MenuType.PIZZECLASSICHE),
            new MenuItem("Vesuvio", 95, "Tomat, ost & skinke", MenuType.PIZZECLASSICHE),
            new MenuItem("Capricciosa", 98, "Tomat, ost, skinke & champignon", MenuType.PIZZECLASSICHE),
            new MenuItem("Calzone", 98, "Indbagt pizza med tomat, ost, skinke & champignon", MenuType.PIZZECLASSICHE),
            new MenuItem("Quattro Stagioni", 98, "Tomat, ost, skinke, champignon, rejer & paprika", MenuType.PIZZECLASSICHE),
            new MenuItem("Marinara", 97, "Tomat, ost, rejer, muslinger & hvidløg", MenuType.PIZZECLASSICHE),
            new MenuItem("Vegetariana", 98, "Tomat, ost & grønsager", MenuType.PIZZECLASSICHE),
            new MenuItem("Italiana", 97, "Tomat, ost, løg & kødsauce", MenuType.PIZZECLASSICHE)
            };
        #endregion

        #region Properties
        public static Dictionary<string, Customer> CustomerData
        {
            get { return _customerData; }
        }

        public static List<MenuItem> MenuItemData
        {
            get { return _menuItemData; }
        }
        #endregion

        #region Methods
        public static void Reset()
        {
            _customerData = new Dictionary<string, Customer>()
            {
            { "12121212", new Customer("Mikkel", "12121212", "Roskilde", "Street 123") },
            { "13131313", new Customer("Charlotte", "13131313", "Roskilde", "Avenue 321") },
            { "14141414", new Customer("Carina", "14141414", "Roskilde", "High Street 234") },
            { "15151515", new Customer("Muhammed", "15151515", "Ringsted", "North Street 345") }
            };

            _menuItemData =
            new List<MenuItem>()
            {
                //new menuitem("margherita", 85, "tomat, ost", menutype.pizzeclassiche),
                //new menuitem("vesuvio", 95, "tomat, ost & skinke", menutype.pizzeclassiche),
                //new menuitem("capricciosa", 98, "tomat, ost, skinke & champignon", menutype.pizzeclassiche),
                //new menuitem("calzone", 98, "indbagt pizza med tomat, ost, skinke & champignon", menutype.pizzeclassiche),
                //new menuitem("quattro stagioni", 98, "tomat, ost, skinke, champignon, rejer & paprika", menutype.pizzeclassiche),
                //new menuitem("marinara", 97, "tomat, ost, rejer, muslinger & hvidløg", menutype.pizzeclassiche),
                //new menuitem("vegetariana", 98, "tomat, ost & grønsager", menutype.pizzeclassiche),
                //new menuitem("italiana", 97, "tomat, ost, løg & kødsauce", menutype.pizzeclassiche)

            };
            #endregion
        }
    }

}
