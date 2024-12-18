﻿using PizzaLibrary.Services;
using ConsoleMenu.Controllers.Customers;
using ConsoleMenu.Controllers.MenuItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu.Menu
{
    public class UserMenu
    {
        private static string mainMenuChoices = "\t1.Vis Pizzamenu\n\t2.Vis Kunder\n\t3.Opret kunde\n\t4.Opret menu item\n\tQ.Afslut\n\n\tIndtast valg:";

        private CustomerRepository _customerRepository = new CustomerRepository();
        private MenuItemRepository _menuItemRepository = new MenuItemRepository();
        private static string ReadChoice(string choices)
        {
            Console.Clear();
            Console.WriteLine("\x1b[3J");
            Console.Write(choices);
            string choice = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\x1b[3J");
            return choice.ToLower();
        }
        public void ShowMenu()
        {
            string theChoice = ReadChoice(mainMenuChoices);
            while (theChoice != "q") // while the choice is not "q"
            {
                switch (theChoice)
                {
                    case "1":
                        Console.WriteLine("Valg 1");
                        ShowMenuItemController showMenuItemController = new ShowMenuItemController(_menuItemRepository);
                        showMenuItemController.ShowAllMenuItems();
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Valg 2");
                        ShowCustomerController showCustomerController = new ShowCustomerController(_customerRepository);
                        showCustomerController.ShowAllCustomers();
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Valg 3");
                        Console.WriteLine("Indlæs navn:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Indlæs mobil nr:");
                        string mobile = Console.ReadLine();
                        Console.WriteLine("Indlæs by:");
                        string city = Console.ReadLine();
                        Console.WriteLine("Indlæs adresse:");
                        string address = Console.ReadLine();
                        Console.WriteLine("Vil du være clubmember y/n");
                        string clubMemberString = Console.ReadLine().ToLower();
                        bool isClubMember = (clubMemberString[0] == 'y') ? true : false;
                        AddCustomerController addMenuItemController = new AddCustomerController(name, mobile, city, address, isClubMember, _customerRepository);
                        addMenuItemController.AddCustomer();
                        break;
                    case "4":
                        Console.WriteLine("Valg 4");
                        Console.WriteLine("Indlæs navn:");
                        string pizzaName = Console.ReadLine();
                        Console.WriteLine("Indlæs pris:");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Indlæs beskrivelse:");
                        string description = Console.ReadLine();
                        Console.WriteLine("Indlæs menu type:");
                        string menuType = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Angiv et tal fra 1..4 eller q for afslut");
                        break;
                }
                theChoice = ReadChoice(mainMenuChoices);
            }
        }

    }

}
