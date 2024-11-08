﻿using PizzaLibrary.Data;
using PizzaLibrary.Exceptions;
using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        #region Instance Fields
        private Dictionary<string, Customer> _customers; // string is mobile number as key
        #endregion

        #region Properties
        public int Count { get { return _customers.Count; } }
        #endregion

        #region Constructor
        public CustomerRepository()
        {
            //_customers = new Dictionary<string, Customer>();
            _customers = MockData.CustomerData;
        }
        #endregion

        #region Methods
        public void AddCustomer(Customer customer)
        { // Approved
            if (!_customers.ContainsKey(customer.Mobile))
            { // because dictionaries cannot contain duplicates
                _customers.Add(customer.Mobile, customer);
            }
            else
            {
                throw new CustomerMoblieNumberExist();
            }
        }

        public List<Customer> GetAll()
        { // Approved - list all customers
            // simplest and best method
            return _customers.Values.ToList();
            /* this method is okay too
            List<Customer> allCustomers = new List<Customer>(); // local instance
            foreach (Customer customer in _customers.Values)
            {
                allCustomers.Add(customer);
            }
            return allCustomers;
            */
        }

        public Customer? GetCustomerByMobile(string mobile)
        { // Approved
            foreach (Customer customer in _customers.Values)
            {
                if (mobile == customer.Mobile)
                {
                    return customer;
                }
            }
            return null;
        }

        public void PrintAllCustomers()
        { // Approved
            foreach (Customer customer in _customers.Values)
            {
                Console.WriteLine(customer.ToString());
            }
        }

        public void RemoveCustomer(string mobile)
        { // Approved
            _customers.Remove(mobile);
        }

        public List<Customer> GetAllMembers() // just a filterer, not a printer!!
        { // Approved -  list all customers who are club members
            List<Customer> members = new List<Customer>(); // local instance
            foreach (Customer customer in _customers.Values)
            {
                if (customer.ClubMember) // doesn't need a value specified
                { // if true, add to the list
                    members.Add(customer);
                }
            }
            return members;
        }

        public override string ToString() // not needed right now
        { // is this neccesary? what should it do? PrintAll? - ASK
            //TODO one value at a time
            //return $"{customer.}";
            foreach (Customer customer in _customers.Values)
            {
                return customer.ToString();
            }
            return "";
        }
        #endregion
    }
}
