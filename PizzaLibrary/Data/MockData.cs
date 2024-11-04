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
            { "12121212", new Customer("Mikkel", "12121212", "Street 123") },
            { "13131313", new Customer("Charlotte", "13131313", "Avenue 321") },
            { "14141414", new Customer("Carina", "14141414", "High Street 234") },
            { "15151515", new Customer("Muhammed", "15151515", "North Street 345") }
            };

        private static List<MenuItem> _menuItemData =
            new List<MenuItem>()
            {
            new MenuItem("Margherita", 85, "Tomat, ost", MenuType.PIZZECLASSSICHE),
            new MenuItem("Vesuvio", 95, "Tomat, ost & skinke", MenuType.PIZZECLASSSICHE),
            new MenuItem("Capricciosa", 98, "Tomat, ost, skinke & champignon", MenuType.PIZZECLASSSICHE),
            new MenuItem("Calzone", 98, "Indbagt pizza med tomat, ost, skinke & champignon", MenuType.PIZZECLASSSICHE),
            new MenuItem("Quattro Stagioni", 98, "Tomat, ost, skinke, champignon, rejer & paprika", MenuType.PIZZECLASSSICHE),
            new MenuItem("Marinara", 97, "Tomat, ost, rejer, muslinger & hvidløg", MenuType.PIZZECLASSSICHE),
            new MenuItem("Vegetariana", 98, "Tomat, ost & grønsager", MenuType.PIZZECLASSSICHE),
            new MenuItem("Italiana", 97, "Tomat, ost, løg & kødsauce", MenuType.PIZZECLASSSICHE)
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
            { "12121212", new Customer("Mikkel", "12121212", "Street 123") },
            { "13131313", new Customer("Charlotte", "13131313", "Avenue 321") },
            { "14141414", new Customer("Carina", "14141414", "High Street 234") },
            { "15151515", new Customer("Muhammed", "15151515", "North Street 345") }
            };

            _menuItemData =
            new List<MenuItem>()
            {
                //new menuitem("margherita", 85, "tomat, ost", menutype.pizzeclasssiche),
                //new menuitem("vesuvio", 95, "tomat, ost & skinke", menutype.pizzeclasssiche),
                //new menuitem("capricciosa", 98, "tomat, ost, skinke & champignon", menutype.pizzeclasssiche),
                //new menuitem("calzone", 98, "indbagt pizza med tomat, ost, skinke & champignon", menutype.pizzeclasssiche),
                //new menuitem("quattro stagioni", 98, "tomat, ost, skinke, champignon, rejer & paprika", menutype.pizzeclasssiche),
                //new menuitem("marinara", 97, "tomat, ost, rejer, muslinger & hvidløg", menutype.pizzeclasssiche),
                //new menuitem("vegetariana", 98, "tomat, ost & grønsager", menutype.pizzeclasssiche),
                //new menuitem("italiana", 97, "tomat, ost, løg & kødsauce", menutype.pizzeclasssiche)

            };
            #endregion
        }
    }

}