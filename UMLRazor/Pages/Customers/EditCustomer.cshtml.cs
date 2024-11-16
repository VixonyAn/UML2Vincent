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

        public EditCustomerModel(ICustomerRepository customerRepository) // dependency injection
        {
            _repo = customerRepository; // parameter overført
        }

        public void OnGet(string editMobile)
        {
            Customer = _repo.GetCustomerByMobile(editMobile);
        }

        public IActionResult OnPost(Customer customer)
        {
            _repo.EditCustomer(customer);
            return RedirectToPage("ShowCustomers");
        }
    }
}
