using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;

namespace UMLRazor.Pages.MenuItems
{
    public class AddMenuItemModel : PageModel
    {
        private IMenuItemRepository _repo;
        public AddMenuItemModel(IMenuItemRepository menuItemRepository) // dependency injection
        {
            _repo = menuItemRepository; // parameter overført
        }

        [BindProperty] // Two way binding
        public MenuItem MenuItem { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            _repo.AddMenuItem(MenuItem);
            return RedirectToPage("ShowMenuItems");
        }
    }
}
