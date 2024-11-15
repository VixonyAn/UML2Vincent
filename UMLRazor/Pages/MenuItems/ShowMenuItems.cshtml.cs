using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;

namespace UMLRazor.Pages.MenuItems
{
    public class ShowMenuItemsModel : PageModel
    {
        private IMenuItemRepository _menuItemRepo;

        public List<MenuItem> MenuItems { get; private set; }

        public ShowMenuItemsModel(IMenuItemRepository menuItemRepository)
        {
            _menuItemRepo = menuItemRepository;
        }
        public void OnGet()
        {
            MenuItems = _menuItemRepo.GetAll();
        }
    }
}
