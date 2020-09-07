using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Starting in");

            for (int i = 3;i>=0;i--) {

                Console.WriteLine(i);


            }

             Console.WriteLine("How old are u");
             var age = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("What is your name");
             var name = Console.ReadLine();

             Console.WriteLine("are u alive? type yes or no");

             var UAlive = Console.ReadLine();

             



            switch (name)
            {
                case "Niklas":
                    Console.WriteLine("Hello Niklas");
                    break;

                case "Malte":

                    Console.WriteLine("hello Malte");

                    break;
                default:
                    Console.WriteLine("Hello person");
                    break;
            }

            if (age <= 12)
            {
                Console.WriteLine("get off game");
            }
            else {

                Console.WriteLine("u good lets play game");

            }


            while (true)
            {
                if (UAlive.Equals("yes"))
                {
                    Console.WriteLine("hmm... *pulls out gun and shoots you* u sure?");
                    break;
                }
                else if (!UAlive.Equals("yes")){
                    Console.WriteLine("Atleast i dont have to shoot you... Again");
                    break;
                }
                
                    
                

            }



            }




        }
    }

