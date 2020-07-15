using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Lab_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input, input2;
            double totalPrice = 0;
            double averagePrice;

            bool redo = true;


            Dictionary<string, double> items = new Dictionary<string, double>(); // Collections of keys and values
            items["apple"] =                        0.99;
            items["banana"] =                            0.59;
            items["cauliflower"] = 1.59;
            items["dragonfruit"] = 2.19;
            items["elderberry"] = 1.79;
            items["figs"] = 2.09;
            items["grapefruit"] = 1.99;
            items["honeydew"] = 3.49;


            ArrayList shoppingCart = new ArrayList(); // Empty Array List called shoppingCart 

            ArrayList shoppingPrice = new ArrayList(); // Empty Array List called shopping price

            Console.Write("Welcome to Brendan's Market!");

            Console.WriteLine("\n");

            Console.Write("Item\t\t\t\t\t\tPrice");

            Console.WriteLine("\n");

            foreach (KeyValuePair<string, double> item in items)
            {
                Console.WriteLine($"{item.Key,-15}\t\t\t\t{item.Value,13}"); // Prints the item and the value from the collection dictionary. Key is the item and value is the number
            }

            do
            {
                Console.Write("\n");

                Console.Write("What item would you like to order? ");

                input = Console.ReadLine();

               
                if (items.ContainsKey(input)) // Looks for a key in the items dictionary from the users input
                {
                    Console.WriteLine($"Adding {input} to cart at {items[input]}");
                    shoppingCart.Add(input); // Adds the users input to the shoppingCart arraylist
                    shoppingPrice.Add(items[input]); // Adds the users input to the shoppingPrice arraylist

                    Console.Write("\n");

                    Console.WriteLine("Would you like to order anything else (y/n)");

                    input2 = Console.ReadLine();

                    if (input2 == "y")
                    {
                        redo = true;
                    }
                    else if (input2 == "n")
                    {
                        Console.WriteLine("Thanks for your order!");
                        Console.Write("\n");
                        Console.WriteLine("Here's what you got:");
                        Console.Write("\n");
                        for (int index = 0; index < shoppingCart.Count; index++) // Loops through each item in the shoppingCart arraylist
                        {
                            Console.WriteLine($"{shoppingCart[index],-15}  {shoppingPrice[index],5}"); 
                            totalPrice += (double)shoppingPrice[index];
                        }

                        averagePrice = totalPrice / shoppingCart.Count;

                        Console.WriteLine($"The average price per item in order was {Math.Round(averagePrice,2)}");
                        redo = false;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, we don't have those. Please try again");
                    redo = true;
                }
               
            } while (redo);
        } 
    }
}
