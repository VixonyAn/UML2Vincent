using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu.Controllers.MenuItems
{
    public class AddMenuItemController
    {
        IMenuItemRepository _menuItemRepository;
        public MenuItem MenuItem { get; set; }

        public AddMenuItemController(string pizzaName, double price, string description, MenuType menuType, IMenuItemRepository menuItemRepository)
        {
            MenuItem = new MenuItem(pizzaName, price, description, menuType);
            _menuItemRepository = menuItemRepository;
        }

        public void AddMenuItem()
        {
            _menuItemRepository.AddMenuItem(MenuItem);
        }
    }
}
