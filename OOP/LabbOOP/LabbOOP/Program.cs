using System;
using System.Collections.Generic;

namespace LabbOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> Customers = new List<Customer>();//skapar en lista som man sedan kan fylla på som man vill
            bool custom = true;
            var x = 0;
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
                            NewCustomer(Customers);
                            break;
                        }
                    case 2:
                        {
                            DisplayCustomers(Customers);
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

        
        
        static List<Customer> NewCustomer(List <Customer> Customers)
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

    }
}
