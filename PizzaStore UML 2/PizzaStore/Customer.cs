using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Customer
    {
        public static int idCounter = 0;

        public Customer(string name, string address, string email, string phone)
        {
            this.Id = idCounter;
            idCounter++;
            this.Name = name;
            this.Address = address;
            this.Email = email;
            this.Phone = phone;
        }

        public string Name { get ; set; }

        public int Id { get; private set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Address}, {Email}, {Phone}";
        }
    }
}
