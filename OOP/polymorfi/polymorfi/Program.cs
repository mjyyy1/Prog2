using System;
using System.Collections.Generic;

namespace polymorfi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> cart = new List<Product>();

            Milk milk = new Milk();
            milk.fatContent = 1;
            milk.ProductNumber = 123;
            milk.stockStatus = 10;

            cart.Add(milk);

            Nocco nocco = new Nocco();

            nocco.Flavor = "Cola";
            nocco.ProductNumber = 234;
            nocco.stockStatus = 16;

            cart.Add(nocco);

            Coffee coffee = new Coffee();

            coffee.Roastyness = "Roasty";
            coffee.ProductNumber = 345;
            coffee.stockStatus = 0;

            cart.Add(coffee);

            foreach (var Product in cart)
            {
                if (Product.GetType() == typeof(Milk))
                {
                    Console.WriteLine(((Milk)Product).fatContent);
                }
               else if (Product.GetType() == typeof(Nocco))
                {
                    Console.WriteLine(((Nocco)Product).Flavor);
                }
                else if (Product.GetType() == typeof(Coffee))
                {
                    Console.WriteLine(((Coffee)Product).Roastyness);
                }
            }
        }
    }
}
