using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Pizza
    {
        public static int idCounter = 0;
        private double _price;
        public int Id { get; }

        public string Name { get; set; }
        public double Price
        {
            get { return _price; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException($"Price must be a positive number for {this.Name}");
                }
                _price = value;
            }
        }

        public List<string> toppings = new List<string>();
        public int amount { get; set; }
        public Pizza (string name, double price)
        {
            Name = name;
            Price = price;
            Id = idCounter;
            idCounter++;
        }
        public void AddTopping(string topping)
        {
            toppings.Add(topping);
        }

        public void PrintToppings()
        {
            foreach (string topping in toppings)
            {
                Console.Write($" {topping}, ");
            }
        }

        public override string ToString()
        {
            PrintToppings();
            return $"Pizza: name is {Name} and the id is = {Id} and the price is { Price} kr";
        }
    }
}
