// See https://aka.ms/new-console-template for more information
using ConsoleMenu.Menu;
using PizzaLibrary.Services;
using PizzaLibrary.Models;

MenuItemRepository mr = new MenuItemRepository();
MenuItem expensivePizza = mr.MostExpensivePizza();
if (expensivePizza != null)
{
    Console.WriteLine($"Den dyreste pizza er\n{expensivePizza}");
}
else
{
    Console.WriteLine("Der findes ikke en dyreste pizza på nuværende tidspunkt");
}

CustomerRepository crep = new CustomerRepository();
List<Customer> members = crep.GetAllMembers();
Console.WriteLine("Her er listen af klub medlemmer");
foreach (Customer c in members)
{
    Console.WriteLine($"{c}");
}

CustomerRepository crepRos = new CustomerRepository();
List<Customer> roskildeCustomers = crepRos.FindRoskildeCustomers();
Console.WriteLine("Her er listen af kunder fra Roskilde");
foreach (Customer c in roskildeCustomers)
{
    Console.WriteLine($"{c}");
}

//UserMenu menu = new UserMenu();
//menu.ShowMenu();