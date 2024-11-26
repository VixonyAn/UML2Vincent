using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;
using PizzaLibrary.Services;

namespace UMLRazor.Pages.MenuItems
{
    public class AddMenuItemModel : PageModel
    {
        private IMenuItemRepository _repo;
        private MenuType _typeRepo;
        [BindProperty] // Two way binding
        public MenuItem MenuItem { get; set; }
        public List<SelectListItem> MenuTypeSelectList { get; set; }
        [BindProperty]
        public MenuType ChosenMenuType { get; set; }

        public AddMenuItemModel(IMenuItemRepository menuItemRepository) // dependency injection
        {
            _repo = menuItemRepository; // parameter overført
            createMenuTypeSelectList();
        }

        private void createMenuTypeSelectList() // small first letter for private methods
        {
            MenuTypeSelectList = new List<SelectListItem>();
            MenuTypeSelectList.Add(new SelectListItem("Select a Menu Type", "-1"));
            foreach (MenuType type in Enum.GetValues(typeof(MenuType)).Cast<MenuType>())
            {
                SelectListItem smt = new SelectListItem(type.ToString(), type.ToString());
                MenuTypeSelectList.Add(smt);
            }
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            MenuItem.TheMenuType = ChosenMenuType;
            _repo.AddMenuItem(MenuItem);
            return RedirectToPage("ShowMenuItems");
        }
    }
}
