using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;

namespace UMLRazor.Pages.Customers
{
    public class AddCustomerModel : PageModel
    {
        private ICustomerRepository _repo;

        //private IWebHostEnvironment;
        //[BindProperty]
        //public IFormFile Photo { get; set; }
        
        public AddCustomerModel(ICustomerRepository customerRepository) // dependency injection
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
            _repo.AddCustomer(Customer);
            return RedirectToPage("ShowCustomers");
        }
    }
}
