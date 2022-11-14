using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class PizzaMenu
    {
        private static Dictionary<int, Pizza> pizzas = new Dictionary<int, Pizza>();
        private static List<string> toppings = new List<string>();


        #region PizzaMenu
        public static void CreatePizza(string name, double prize)
        {
            try
            {
                Pizza pizza = new Pizza(name, prize);
                pizzas.Add(pizza.Id, pizza);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static Pizza GetPizza(int id)
        {
            if (pizzas.ContainsKey(id))
            {
                return pizzas[id];
            }
            else
            {
                Console.WriteLine("Pizza does not exist");
                return null;
            }
        }

        public static void AddPizza(Pizza pizza)
        {
            if (!pizzas.ContainsKey(pizza.Id))
            {
                pizzas.Add(pizza.Id, pizza);
            }
            else
            {
                Console.WriteLine("Pizza already exist");
            }
        }

        public static bool DeletePizza(int id)
        {
            if (!pizzas.ContainsKey(id))
            {
                throw new ArgumentNullException ($"Pizza with id = {id} does not exist");
            }
            return pizzas.Remove(id);
        }

        public static void UpdatePizza(int id, Pizza pizza)
        {
            if (!pizzas.ContainsKey(id))
            {
                throw new ArgumentNullException($"No pizza with id: {id} exists");
            }
            pizzas[id].Name = pizza.Name;
            pizzas[id].Price = pizza.Price;
        }

        public static void PrintMenu()
        {
            Console.WriteLine("Pizza Menu");

            foreach (var item in pizzas)
            {
                Console.WriteLine(item.Value);
            }
        }

        public static Pizza SearchPizza(int id)
        {
            if (pizzas.ContainsKey(id))
            {
                return pizzas[id];
            }
            else
            {
                Console.WriteLine("Pizza doesn't exist");
                return null;
            }
        }
        #endregion

        #region toppings
        public static void AddTopping(string topping)
        {
            toppings.Add(topping);
        }

        public static List<string> GetToppings()
        {
            return toppings;
        }

        public static void PrintToppings()
        {
            foreach (string topping in toppings)
            {
                Console.WriteLine(topping);
            }
        }
        #endregion
    }
}
