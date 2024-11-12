using PizzaLibrary.Interfaces;
using PizzaLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu.Controllers.Customers
{
    public class ShowCustomerController
    {
        private ICustomerRepository _customerRepo;
        public ShowCustomerController(CustomerRepository customerRepository)
        {
            _customerRepo = customerRepository;
        }

        public void ShowAllCustomers()
        {
            _customerRepo.PrintAllCustomers();
        }
    }
}

