using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraktion
{
    class Dog : Animal
    {

        public Dog()
        {
            NumberOfLimbs = 4;
            Color = "black";
        }
        public override void Breathe()
        {
            Console.WriteLine("Dog  breathes");
        }

        public override void Eat()
        {
            Console.WriteLine("Dog eats");
        }

        public override void Rest()
        {
            Console.WriteLine("Dog takes a nap");
        }
    }
}
