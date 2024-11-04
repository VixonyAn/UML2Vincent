// See https://aka.ms/new-console-template for more information
using ConsoleMenu.Menu;
using PizzaLibrary.Services;
using PizzaLibrary.Models;

MenuItemRepository mr = new MenuItemRepository();
MenuItem expensivePizza = mr.MostExpensivePizza();
Console.WriteLine($"Den dyreste pizza er\n{expensivePizza}");

UserMenu menu = new UserMenu();
menu.ShowMenu();