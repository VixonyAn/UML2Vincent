using PizzaLibrary.Interfaces;
using PizzaLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu.Controllers.MenuItems
{
    public class ShowMenuItemController
    {
        private IMenuItemRepository _menuItemRepo;
        public ShowMenuItemController(MenuItemRepository menuRepository)
        {
            _menuItemRepo = menuRepository;
        }

        public void ShowAllMenuItems()
        {
            _menuItemRepo.PrintAllMenuItems();
        }
    }
}
