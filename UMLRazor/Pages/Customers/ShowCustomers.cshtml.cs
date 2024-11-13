using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaLibrary.Interfaces;
using PizzaLibrary.Services;
using PizzaLibrary.Models;

namespace UMLRazor.Pages.Customers
{
    public class ShowCustomersModel : PageModel
    {
        private ICustomerRepository _customerRepo;
       
        public List<Customer> Customers { get; private set; }
        
        public ShowCustomersModel(ICustomerRepository customerRepository)
        {
            _customerRepo = customerRepository;
        }
        public void OnGet()
        {
            Customers = _customerRepo.GetAll();
        }
    }
}
