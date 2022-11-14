using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class CustomerFile
    {
        private static List<Customer> customers = new List<Customer>();

        public static void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        public static void CreateCustomer(string name, string adress, string email, string phone)
        {
            Customer customer = new Customer(name, adress, email, phone);
            customers.Add(customer);
        }
        public static bool DeleteCustomer(int id)
        {
            foreach (Customer customer in customers)
            {
                if (customer.Id == id)
                {
                    return customers.Remove(customer);
                }
            }
            Console.WriteLine("Customer with that id doesn't exist");
            return false;
        }
        public static void UpdateCustomer(int id, Customer customer)
        {
            foreach (Customer customerUpdate in customers)
            {
                if (customerUpdate.Id == id)
                {
                    customerUpdate.Name = customer.Name;
                    customerUpdate.Address = customer.Address;
                    customerUpdate.Email = customer.Email;
                    customerUpdate.Phone = customer.Phone;
                }
            }
        }

        public static void UpdateCustomer(int id, string name, string address, string email, string phone)
        {
            foreach (Customer customerUpdate in customers)
            {
                if (customerUpdate.Id == id)
                {
                    customerUpdate.Name = name;
                    customerUpdate.Address = address;
                    customerUpdate.Email = email;
                    customerUpdate.Phone = phone;
                }
            }
        }

        public static void PrintCustomerFile()
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer);
            }
        }
    }
}
