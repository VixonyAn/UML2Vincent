using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;

namespace UMLRazor.Pages.Customers
{
    public class EditCustomerModel : PageModel
    {
        private ICustomerRepository _repo;

        [BindProperty] // Two way binding
        public Customer Customer { get; set; }

        [BindProperty] public string Name { get; set; }
        [BindProperty] public string Address { get; set; }
        [BindProperty] public string Mobile { get; set; }
        [BindProperty] public string newMobile { get; set; }
        [BindProperty] public bool ClubMember { get; set; }

        public EditCustomerModel(ICustomerRepository customerRepository) // dependency injection
        {
            this._repo = customerRepository; // parameter overført
        }

        public IActionResult OnGet(string editMobile)
        {
            Customer = _repo.GetCustomerByMobile(editMobile);
            return Page();
        }

        public IActionResult OnPost(string mobile, bool chooseClub)
        {
            _repo.EditCustomer(Name, Address, Mobile, newMobile, chooseClub);
            return RedirectToPage("ShowCustomers");
        }
    }
}
