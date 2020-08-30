using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean AmIAlive;

            Console.WriteLine("Hello Niklas");

            Console.WriteLine("How old are u");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your name");
            String name = Console.ReadLine();

            Console.WriteLine("are u alive? type yes or no");

            String UAlive = Console.ReadLine();

            if (UAlive.Equals("yes")) {
                AmIAlive = true;
            }
            else
            {
                AmIAlive = false;
            }

            Console.WriteLine("you are " + age + " years old" + '\n' + "your name is " + name);

            if (AmIAlive = true) {
                Console.WriteLine("you are alive");
            }
            else {
                Console.WriteLine("you are not alive");
            }



        }
    }
}
