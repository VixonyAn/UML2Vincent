// See https://aka.ms/new-console-template for more information
using PizzaLibrary.Data;
using PizzaLibrary.Models;
using PizzaLibrary.Services;

Customer c1 = new Customer("Luke", "23489074", "Roskilde", "24th Avenue");
////Console.WriteLine(c1.ToString());

Order o1 = new Order(c1);
//OrderLine ol1 = new OrderLine(1, );
//o1.AddToOrder(ol1);

////MenuItemRepository mrep = new MenuItemRepository();
//mrep.RemoveMenuItem(1); // Approved and tested
//mrep.PrintAllMenuItems(); // Approved // cw doesn't work here, use the method directly
/* // Approved print all items >50dkk
List<MenuItem> minPriced = mrep.MinPriceList();
foreach (MenuItem menuItem in minPriced)
{
    Console.WriteLine(menuItem.ToString());
}
*/

////CustomerRepository crep = new CustomerRepository();
////Console.WriteLine(crep.ToString());


/* // Approved customer member list
CustomerRepository crep = new CustomerRepository();
List<Customer> members = crep.GetAllMembers();
foreach (Customer member in members)
{
    Console.WriteLine(member.ToString());
}
*/
