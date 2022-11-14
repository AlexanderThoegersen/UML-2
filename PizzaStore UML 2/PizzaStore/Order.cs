using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore
{
    internal class Order
    {
        private static int idCounter = 0;
        private const int shipping = 40;
        private const double tax = .25;
        private Dictionary<int, Pizza> pizzas = new Dictionary<int, Pizza>();

        public int Id { get; set; }
        public Customer Customer { get; set; }
        public Order (Customer customer)
        {
            Customer = customer;
            Id = idCounter;
            idCounter++;
        }

        #region pizza
        public void AddPizza(Pizza pizza)
        {
            pizzas.Add(pizza.Id, pizza);
        }
        
        public bool DeletePizza(int id)
        {
            if (pizzas.ContainsKey(id))
                return pizzas.Remove(id);
            else
                return false;
        }

        public void UpdatePizza(int id, Pizza pizza)
        {
            pizzas[id] = pizza;
        }
        #endregion

        #region toppings
        public void AddTopping(Pizza pizza, string topping)
        {
            foreach (string item in PizzaMenu.GetToppings())
            {
                if (topping == item)
                    pizza.toppings.Add(topping);
                else
                    Console.WriteLine($"please pick valid topping {topping} is not valid");
            }
        }
        #endregion

        #region order
        public void PrintOrder()
        {
            Console.WriteLine("OrderInformation");
            foreach (var item in pizzas)
            {
                Console.WriteLine($"{item.Value}");
            }
        }

        public double CalculateTotalPrice()
        {
            double total = 0;
            foreach (var item in pizzas)
            {
                total += item.Value.Price * (1 + tax);
            }
            return total + shipping;
        }
        #endregion
    }
}
