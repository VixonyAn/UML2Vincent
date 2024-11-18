using PizzaLibrary.Models;
using PizzaLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaLibrary.Interfaces
{
    public interface ICustomerRepository
    {
        public int Count { get; }
        List<Customer> GetAll();
        void AddCustomer(Customer customer);
        Customer GetCustomerByMobile(string mobile);
        //Customer GetCustomerById(int id);
        void RemoveCustomer(string mobile);
        void EditCustomer(string name, string address, string mobile, string newMobile, bool chooseClub);
        void PrintAllCustomers();
    }

}
