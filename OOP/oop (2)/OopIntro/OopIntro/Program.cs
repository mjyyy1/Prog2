using System;

namespace OopIntro
{
    class Program
    {
        static void Main(string[] args)
        {


            

                Pets Elsa = new Pets();

            Elsa._petName = "Elsa";
            Elsa._species = "Dog";
            Elsa._color = "Black and White";
            Person Malte = new Person("Malte",17,Elsa);

            Malte.Name = "Malte";

          

            Malte.ActivatePet();

            Malte.Eat();
            Malte.Sleep();
            

        }
    }
}