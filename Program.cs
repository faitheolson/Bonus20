using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_20ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> MenuItems = new Dictionary<string, double>();
            MenuItems.Add("PIZZA",5.00);
            MenuItems.Add("GRAPEFRUIT",.89);
            MenuItems.Add("SODA",.79);
            MenuItems.Add("SALAD", 3.00);
            MenuItems.Add("BREAD", 2.50);
            MenuItems.Add("MILK", 1.50);
            MenuItems.Add("EGGS", 1.59);
            MenuItems.Add("GROUND COFFEE", 7.00);

            Console.WriteLine("Welcome to the Grand Circus Market!");
            
            ArrayList ItemsOrdered = new ArrayList();
            ArrayList PricesOrdered = new ArrayList();
            bool KeepAdding = true;
            double ItemPrice = 0;
            double ShoppingCartTotal = 0;
            int ShoppingCartNumberOfItems = 0;

            while (KeepAdding == true)
            {
                DisplayMenu(MenuItems);
                Console.WriteLine("What item would you like to order?");
                string InputToSearchFor = Console.ReadLine().ToUpper();
                //SearchForItem(InputToSearchFor);

                while (!MenuItems.TryGetValue(InputToSearchFor, out ItemPrice))
                {
                    Console.WriteLine("Sorry that item does not exist. Please enter item:");
                    InputToSearchFor = Console.ReadLine().ToUpper();

                }
                Console.WriteLine($"{InputToSearchFor} added at {ItemPrice}.");
                ItemsOrdered.Add(InputToSearchFor);
                PricesOrdered.Add(ItemPrice);
                ShoppingCartNumberOfItems++;
                ShoppingCartTotal += ItemPrice;
                Console.WriteLine("Would you like to add another item?");
                string Input = Console.ReadLine().ToUpper();
                if (Input != "Y")
                {
                    Console.Clear();
                    Console.WriteLine("Thanks for your order!");
                    Console.WriteLine("Here's what you got!");
                    for (int i = 0; i < ItemsOrdered.Count; i++)
                    {
                        Console.WriteLine($"{ItemsOrdered[i]} {PricesOrdered[i]}");
                    }
                    Console.WriteLine($"Your order total is {ShoppingCartTotal}.");
                    Console.WriteLine($"The average price per item in your order was {ShoppingCartTotal/ItemsOrdered.Count}.");
                    KeepAdding = false;
                }
                else
                {
                   Console.Clear();
                }
               
            }

            //string[] ItemsOrdered = new string[ShoppingCartNumberOfItems];
            //double[] PricesForOrderedItems = new double[ShoppingCartNumberOfItems];

        }
        //public static double SearchForItem(string InputToSearchFor)
        //{

        //}

        public static void DisplayMenu(Dictionary<string, double> MenuItems)
        {
            string StarBreak = new string('^', 20);
            Console.WriteLine(StarBreak);

            foreach (KeyValuePair<string, double> Item in MenuItems)
            {
                Console.WriteLine($"{Item.Key} {Item.Value}");
            }
            Console.WriteLine(StarBreak);
        }
    }
    //method for average price of items ordered
    //method to find the highest priced item
    //method to find the lowest priced item
}
