using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LabbOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Customer> Customers = new List<Customer>();//skapar en lista som man sedan kan fylla på som man vill (för och efternamn)
            List<Item> Items = new List<Item>();//samma som över fast för saker
         
            bool custom = true;
            var x = 0;

            Items.Add(new Item("milk"));
            Items.Add(new Item("apple"));
            Items.Add(new Item("´Chips"));
            

            while (custom)
            {

                Console.WriteLine('\n' + "Action");
                Console.WriteLine("1 - New Customer");
                Console.WriteLine("2 - Show Customers");
                Console.WriteLine("3 - stop");

                while (true)
                {
                    try
                    {
                        x = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {

                        Console.WriteLine('\n' + "a number please");
                    }
                    break;
                }
                
                

                switch (x)
                {

                    case 1:
                        {
                            NewCustomer(Customers,Items);
                            break;
                        }
                    case 2:
                        {
                            DisplayCustomers(Customers);
                            AddItemsOrNo(Customers,x,Items);
                            
                            break;
                        }
                    case 3:
                        {
                            custom = false;
                            break;
                        }
                    default:
                        break;
                }

            }
            
        }

        
        
        static List<Customer> NewCustomer(List <Customer> Customers, List<Item> Items)
        //metod som skapar en ny Customer
        {
            Console.WriteLine('\n' + "Type first name and surename" + '\n');
            Customers.Add(new Customer(Console.ReadLine(), Console.ReadLine()));
            return Customers;
        }


       
        static void DisplayCustomers(List<Customer> Customers)
        //metod som skriver ut alla customers
        {
            foreach (Customer item in Customers)
            {
                Console.WriteLine(item._firstName + " " + item._sureName);

            }
        }

        static void AddItemsOrNo(List<Customer> Customers, int x, List<Item> Items)
        {
            bool itms = true;
            while (itms)
            {


                Console.WriteLine("1 - Add item");
                Console.WriteLine("2 - Remove item");
                Console.WriteLine("3 - Leave");
                while (true)
                {
                    try
                    {
                        x = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {

                        Console.WriteLine('\n' + "a number please");
                    }
                    break;
                }

                switch (x)
                {
                    case 1:
                        {
                            Console.WriteLine("hi");
                            ItemsTo(Customers,Items,x);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("hiya");
                            ItemsFrom(Customers,Items);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("hey");
                            itms = false;
                            break;
                        }

                    default:
                        break;
                }

            }
        }

        static void ItemsTo(List<Customer> Customers, List<Item> Items,int x)
        {
            bool itms = true;
            while (itms)
            {


                Console.WriteLine("1 - Milk");
                Console.WriteLine("2 - Apple");
                Console.WriteLine("3 - Chips");
                while (true)
                {
                    try
                    {
                        x = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {

                        Console.WriteLine('\n' + "a number please");
                    }
                    break;
                }

                switch (x)
                {
                    case 1:
                        {

                            Console.WriteLine(Items[0]._item);
                            break;
                        }
                    case 2:
                        {

                            Console.WriteLine(Items[1]._item);
                            break;
                        }
                    case 3:
                        {

                            Console.WriteLine(Items[2]._item);
                            break;
                        }

                    default:
                        break;
                }

            }
        }

        static void ItemsFrom(List<Customer> Customers, List<Item> Items)
        {

        }

    }
}
