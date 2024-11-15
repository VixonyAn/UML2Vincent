using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;

namespace UMLRazor.Pages.Customers
{
    public class EditCustomerModel : PageModel
    {
        private ICustomerRepository _repo;
        public EditCustomerModel(ICustomerRepository customerRepository) // dependency injection
        {
            _repo = customerRepository; // parameter overført
        }

        [BindProperty] // Two way binding
        public Customer Customer { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            _repo.EditCustomer(Customer);
            return RedirectToPage("ShowCustomers");
        }
    }
}
