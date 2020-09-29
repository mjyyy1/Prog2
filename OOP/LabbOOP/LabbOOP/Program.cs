using System;
using System.Collections.Generic;

namespace LabbOOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer Name = new Customer("Malte","Erlandsson");

            Console.WriteLine(Name._firstName + " " +  Name._sureName);

            List<string> human = new List<string>();
            List<Customer> Customers = new List<Customer>();

            human.Add("malte");
            human.Add("malte1");
            human.Add("malte2");

            Console.WriteLine();
            foreach (string aPart in human)
            {
                Console.WriteLine(aPart);
            }

            Customers.Add(Console.ReadLine(), Console.ReadLine());
            
        }
    }
}
