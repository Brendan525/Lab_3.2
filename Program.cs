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
            int total, average;

            bool redo = true;


            Dictionary<string, double> items = new Dictionary<string, double>();
            items["apple"] = 0.99;
            items["banana"] = 0.59;
            items["cauliflower"] = 1.59;
            items["dragonfruit"] = 2.19;
            items["elderberry"] = 1.79;
            items["figs"] = 2.09;
            items["grapefruit"] = 1.99;
            items["honeydew"] = 3.49;


            ArrayList shoppingCart = new ArrayList();

            ArrayList shoppingPrice = new ArrayList();

            Console.Write("Welcoms to Brendan's Market!");

            Console.WriteLine("\n");

            Console.Write("Item\t\t\t\t\tPrice");

            Console.WriteLine("\n");

            foreach (KeyValuePair<string, double> item in items)
            {
                Console.WriteLine($"{item.Key}\t\t\t\t{item.Value}");
            }

            do
            {
                Console.Write("What item would you like to order? ");

                input = Console.ReadLine();

                //if (input != "apple" | input != "banana" | input != "cauliflower" | input != "dragonfruit" | input != "elderberry" | input != "figs" | input != "grapefruit" | input != "honeydew")
                //{
                //    Console.WriteLine("Sorry, we don't have those. Please try again");
                //    redo = true;
                //}
                if (input == "apple")
                {
                    Console.WriteLine("Adding apple to cart at $0.99");
                    shoppingCart.Add("apple");
                    shoppingPrice.Add(0.99);

                    Console.Write("\n");

                    Console.WriteLine("Would you like to order anything else (y/n)");

                    input2 = Console.ReadLine();

                    Console.Write("\n");

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
                        for (int index = 0; index < shoppingCart.Count; index++)
                        {
                            Console.WriteLine($"{shoppingCart[index]}  {shoppingPrice[index]}");
                        }

                        average = shoppingCart.Count / shoppingPrice.Count;

                        Console.WriteLine($"The average price per item in order was {average}");
                        redo = false;

                    }
                    else if (input == "banana")
                    {
                        Console.WriteLine("Adding banana to cart at $0.59");
                        shoppingCart.Add("banana");
                        shoppingPrice.Add(0.59);

                        Console.Write("\n");

                        Console.WriteLine("Would you like to order anything else (y/n)");

                        input2 = Console.ReadLine();

                        Console.Write("\n");

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
                            for (int index = 0; index < shoppingCart.Count; index++)
                            {
                                Console.WriteLine($"{shoppingCart[index]}  {shoppingPrice[index]}");
                            }

                            average = shoppingCart.Count / shoppingPrice.Count;

                            Console.WriteLine($"The average price per item in order was {average}");
                            redo = false;
                        }
                        else if (input == "cauliflower")
                        {
                            Console.WriteLine("Adding cauliflower to cart at $1.59");
                            shoppingCart.Add("cauliflower");
                            shoppingPrice.Add(1.59);

                            Console.Write("\n");

                            Console.WriteLine("Would you like to order anything else (y/n)");

                            input2 = Console.ReadLine();

                            Console.Write("\n");

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
                                for (int index = 0; index < shoppingCart.Count; index++)
                                {
                                    Console.WriteLine($"{shoppingCart[index]}  {shoppingPrice[index]}");
                                }

                                average = shoppingCart.Count / shoppingPrice.Count;

                                Console.WriteLine($"The average price per item in order was {average}");
                                redo = false;
                            }
                            else if (input == "dragonfruit")
                            {
                                Console.WriteLine("Adding dragonfruit to cart at $2.19");
                                shoppingCart.Add("dragonfruit");
                                shoppingPrice.Add(2.19);

                                Console.Write("\n");

                                Console.WriteLine("Would you like to order anything else (y/n)");

                                input2 = Console.ReadLine();

                                Console.Write("\n");

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
                                    for (int index = 0; index < shoppingCart.Count; index++)
                                    {
                                        Console.WriteLine($"{shoppingCart[index]}  {shoppingPrice[index]}");
                                    }

                                    average = shoppingCart.Count / shoppingPrice.Count;

                                    Console.WriteLine($"The average price per item in order was {average}");
                                    redo = false;
                                }
                                else if (input == "elderberry")
                                {
                                    Console.WriteLine("Adding elderberry to cart at $1.79");
                                    shoppingCart.Add("elderberry");
                                    shoppingPrice.Add(1.79);

                                    Console.Write("\n");

                                    Console.WriteLine("Would you like to order anything else (y/n)");

                                    input2 = Console.ReadLine();

                                    Console.Write("\n");

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
                                        for (int index = 0; index < shoppingCart.Count; index++)
                                        {
                                            Console.WriteLine($"{shoppingCart[index]}  {shoppingPrice[index]}");
                                        }

                                        average = shoppingCart.Count / shoppingPrice.Count;

                                        Console.WriteLine($"The average price per item in order was {average}");
                                        redo = false;
                                    }
                                    else if (input == "figs")
                                    {
                                        Console.WriteLine("Adding figs to cart at $2.09");
                                        shoppingCart.Add("figs");
                                        shoppingPrice.Add(2.09);

                                        Console.Write("\n");

                                        Console.WriteLine("Would you like to order anything else (y/n)");

                                        input2 = Console.ReadLine();

                                        Console.Write("\n");

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
                                            for (int index = 0; index < shoppingCart.Count; index++)
                                            {
                                                Console.WriteLine($"{shoppingCart[index]}  {shoppingPrice[index]}");
                                            }

                                            average = shoppingCart.Count / shoppingPrice.Count;

                                            Console.WriteLine($"The average price per item in order was {average}");
                                            redo = false;
                                        }
                                        else if (input == "grapefruit")
                                        {
                                            Console.WriteLine("Adding grapefruit to cart at $1.99");
                                            shoppingCart.Add("grapefruit");
                                            shoppingPrice.Add(1.99);

                                            Console.Write("\n");

                                            Console.WriteLine("Would you like to order anything else (y/n)");

                                            input2 = Console.ReadLine();

                                            Console.Write("\n");

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
                                                for (int index = 0; index < shoppingCart.Count; index++)
                                                {
                                                    Console.WriteLine($"{shoppingCart[index]}  {shoppingPrice[index]}");
                                                }

                                                average = shoppingCart.Count / shoppingPrice.Count;

                                                Console.WriteLine($"The average price per item in order was {average}");
                                                redo = false;
                                            }
                                            else if (input == "honeydew")
                                            {
                                                Console.WriteLine("Adding honeydew to cart at $3.49");
                                                shoppingCart.Add("honeydew");
                                                shoppingPrice.Add(3.49);

                                                Console.Write("\n");

                                                Console.WriteLine("Would you like to order anything else (y/n)");

                                                input2 = Console.ReadLine();

                                                Console.Write("\n");

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
                                                    for (int index = 0; index < shoppingCart.Count; index++)
                                                    {
                                                        Console.WriteLine($"{shoppingCart[index]}  {shoppingPrice[index]}");
                                                    }

                                                    average = shoppingCart.Count / shoppingPrice.Count;

                                                    Console.WriteLine($"The average price per item in order was {average}");
                                                    redo = false;
                                                }

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            } while (redo);
        }
    }
}
