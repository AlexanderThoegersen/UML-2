using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore
{
    internal class Store
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public static void Start()
        {
            #region UML1
            //Customer customer1 = new Customer("Sarah");
            //Pizza pizza1 = new Pizza("pizza1", 50);
            //Order order1 = new Order(pizza1, customer1);
            //Console.WriteLine(order1);

            //Customer customer2 = new Customer("John");
            //Pizza pizza2 = new Pizza("pizza1", 100);
            //Order order2 = new Order(pizza2, customer2);
            //Console.WriteLine(order2);

            //Customer customer3 = new Customer("Heho");
            //Pizza pizza3 = new Pizza("pizza3", 80);
            //Order order3 = new Order(pizza3, customer3);
            //Console.WriteLine(order3);
            #endregion

            /* Hver region har en opgave, for at teste opgaven skal alle regions være udkommenteret undtagen
            den som der skal testes*/

            #region customerFile
            Console.WriteLine("Create Customers");
            CustomerFile.CreateCustomer("Navn1", "adress1", "email1", "phone1");
            CustomerFile.CreateCustomer("Navn2", "adress2", "email2", "phone2");
            CustomerFile.CreateCustomer("Navn3", "adress3", "email3", "phone3");
            CustomerFile.PrintCustomerFile();

            Console.WriteLine();
            Console.WriteLine("Delete Customer by id, test id=2");
            CustomerFile.DeleteCustomer(2);
            CustomerFile.PrintCustomerFile();

            Console.WriteLine();
            Console.WriteLine("UpdateCustomer by id with new customer, test id = 1");
            Customer customer1 = new Customer("navnUpdate", "adresseUpdate", "emailUpdate", "phoneUpdate");
            CustomerFile.UpdateCustomer(1, customer1);
            CustomerFile.PrintCustomerFile();
            #endregion

            #region OrderSystem
            //#region PizzaMenu
            //Console.WriteLine("PizzaMenu");
            //Console.WriteLine("Create pizzas");

            //PizzaMenu.CreatePizza("pizza1", 200);
            //PizzaMenu.CreatePizza("pizza2", 100);
            //PizzaMenu.CreatePizza("pizza3", 400);
            //PizzaMenu.CreatePizza("pizza4", -400);
            //PizzaMenu.PrintMenu();
            //Console.WriteLine();

            //Console.WriteLine("Delete pizza");
            //try
            //{
            //    PizzaMenu.DeletePizza(31);
            //}
            //catch (ArgumentNullException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //    PizzaMenu.DeletePizza(0);
            //}
            //catch (ArgumentNullException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //PizzaMenu.PrintMenu();
            //Console.WriteLine();

            //Console.WriteLine("Update pizza");
            //Pizza pizza1 = new Pizza("pizzaUpdate", 50);
            //try
            //{
            //    PizzaMenu.UpdatePizza(2, pizza1);
            //}
            //catch (ArgumentNullException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //PizzaMenu.PrintMenu();
            //Console.WriteLine();

            //Console.WriteLine("Pizza search by id");
            //Console.WriteLine(PizzaMenu.SearchPizza(1));
            //#endregion

            //#region order
            //Console.WriteLine();
            //Console.WriteLine("OrderSystem");
            //Console.WriteLine("Creater pizzas and orders");
            //Customer customer1 = new Customer("navn1", "adress1", "email1", "phone1");
            //CustomerFile.AddCustomer(customer1);

            //Order order1 = new Order(customer1);


            //Console.WriteLine();
            //Console.WriteLine("Add pizzas to order");
            //order1.AddPizza(PizzaMenu.GetPizza(1));
            //order1.AddPizza(PizzaMenu.GetPizza(2));
            //Pizza pizza2 = new Pizza("pizza4", 55.3);
            //order1.AddPizza(pizza2);
            //order1.PrintOrder();

            //Console.WriteLine();
            //Console.WriteLine("Delete pizza by id");
            //order1.DeletePizza(3);
            //order1.PrintOrder();

            //Console.WriteLine();
            //Console.WriteLine("Update pizza by id");
            //Pizza pizza5 = new Pizza("pizza5", 75);
            //order1.UpdatePizza(1, pizza5);
            //order1.PrintOrder();

            //Console.WriteLine();
            //Console.WriteLine("CalculatePrice");
            //Console.WriteLine(order1.CalculateTotalPrice());
            //#endregion
            #endregion

            // IKke færdigt
            #region interface system
            //PizzaMenu.CreatePizza("pizza1", 200);
            //PizzaMenu.CreatePizza("pizza2", 100);
            //PizzaMenu.CreatePizza("pizza3", 400);
            //PizzaMenu.CreatePizza("pizza4", 70);
            //PizzaMenu.CreatePizza("pizza5", 90);
            //PizzaMenu.CreatePizza("pizza6", 53.2);
            //PizzaMenu.CreatePizza("pizza7", 110);
            //PrintMenuInformation();
            //Console.WriteLine();
            //Console.WriteLine("Your topping choices are");
            //PizzaMenu.AddTopping("topping1");
            //PizzaMenu.AddTopping("topping2");
            //PizzaMenu.AddTopping("topping3");
            //PizzaMenu.PrintToppings();

            //Customer customer1 = new Customer("Kaja");
            //Order order1 = new Order(customer1);
            //MenuInterface(order1);

            //void PrintMenuInformation()
            //{
            //    PizzaMenu.PrintMenu();
            //    Console.WriteLine();

            //    Console.WriteLine("Please choose one or more pizzas to add to your order");
            //    Console.WriteLine("To delete a pizza from your order write Delete)");
            //    Console.WriteLine("To Update a pizza from your order write Update");
            //    Console.WriteLine("to search for a pizza write Search");
            //    Console.WriteLine("to add a pizza to your order write pizzaId");
            //}

            //void MenuInterface(Order order)
            //{
            //    string choice = Console.ReadLine();

            //    if (choice.Contains("Delete".ToLower()))
            //    {
            //        DeleteOrderItem(order);
            //    }
            //    else if (choice.Contains("Update".ToLower()))
            //    {
            //        UpdateOrderItem(order);
            //    }
            //    else if (choice.Contains("Search".ToLower()))
            //    {
            //        SearchPizzaInMenu(order);
            //    }
            //    else
            //    {
            //        AddMenuItemToOrder(choice, order);
            //    }
            //}

            //void DeleteOrderItem(Order order)
            //{
            //    Console.WriteLine("choose what to delete");
            //    order.PrintOrder();
            //    int deleteId = Convert.ToInt16(Console.ReadLine());
            //    order.DeletePizza(deleteId);
            //    Console.WriteLine($"{PizzaMenu.GetPizza(deleteId)} was deleted");
            //    order.PrintOrder();
            //    order.CalculateTotalPrice();
            //    PrintMenuInformation();
            //    MenuInterface(order);
            //}

            //void UpdateOrderItem(Order order)
            //{
            //    Console.WriteLine("Chooce what to update");
            //    order.PrintOrder();
            //    int oldId = Convert.ToInt16(Console.ReadLine());
            //    Console.WriteLine($"you chose to update pizza {oldId}");
            //    int newId = Convert.ToInt16(Console.ReadLine());
            //    Console.WriteLine($"you changed {oldId} to {newId}");
            //    order.UpdatePizza(oldId, PizzaMenu.GetPizza(newId));
            //    order.PrintOrder();
            //    order.CalculateTotalPrice();
            //    PrintMenuInformation();
            //    MenuInterface(order);
            //}

            //void SearchPizzaInMenu(Order order)
            //{
            //    Console.WriteLine("choose what to search for");
            //    int searchId = Convert.ToInt16(Console.ReadLine());
            //    Console.WriteLine(PizzaMenu.GetPizza(searchId));
            //    PrintMenuInformation();
            //    MenuInterface(order);
            //}

            //void AddMenuItemToOrder(string line, Order order)
            //{
            //    int choice;
            //    choice = Convert.ToInt16(line);

            //    if (PizzaMenu.pizzaMenu.ContainsKey(choice))
            //    {
            //        Console.WriteLine($"You added {PizzaMenu.GetPizza(choice)} to your order");
            //        Console.WriteLine("you choose correct");
            //        Console.WriteLine();
            //        Console.WriteLine("Added Pizza to order");
            //        order.AddPizza(PizzaMenu.GetPizza(choice));

            //        AddTopping(order, choice);

            //        order1.PrintOrder();
            //        Console.WriteLine($"Your current total price is {order1.CalculateTotalPrice()} kr");
            //        MenuInterface(order);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Your pizza was not added, please choose a valid pizza");
            //        MenuInterface(order);
            //    }

            //}

            //void AddTopping(Order order, int choice)
            //{
            //    Console.WriteLine("do you want toppings");
            //    string toppingChoice = ""; 
            //    toppingChoice = Console.ReadLine();
            //    Console.WriteLine($"you wrote {toppingChoice}");
            //    if (toppingChoice == "yes")
            //    {
            //        PizzaMenu.PrintToppings();
            //        toppingChoice = Console.ReadLine();
            //        foreach (string item in PizzaMenu.toppings)
            //        {
            //            if(item == toppingChoice)
            //            {
            //                PizzaMenu.GetPizza(choice).AddTopping(toppingChoice);
            //                AddTopping(order, choice);
            //                break;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Invalid topping choice");
            //                AddTopping(order, choice);
            //                break;
            //            }
            //        }
            //    }
            //}
            #endregion
        }
    }
}
