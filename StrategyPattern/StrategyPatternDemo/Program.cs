using StrategyPatternDemo.Strategy;
using System;

namespace StrategyPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("(1) Look Around");
                Console.WriteLine("(2) Buy Animal");
                Console.WriteLine("(3) Pet Dog");
                Console.WriteLine("(4) Steal Animal");
                var operation = Console.ReadLine();
                double numberOne;
                double numberTwo;
                ICalculationStrategy strat;

                Console.WriteLine("Enter the first number:");
                numberOne = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the second number:");
                numberTwo = Convert.ToDouble(Console.ReadLine());
                bool reset = false;

                switch (operation)
                {
                    case "1":
                        strat = new AdditionStrategy();
                        break;
                    case "2":
                        strat = new SubtractionStrategy();
                        break;
                    case "3":
                        strat = new MultiplicationStrategy();
                        break;
                    case "4":
                        strat = new DivisionStrategy();
                        break;
                    default:
                        Console.WriteLine("Please select a valid operation");
                        reset = true;
                        strat = new AdditionStrategy();
                        break;
                }

                if (reset)
                {
                    continue;
                }

                var calc = new Calculation(strat);
                calc.CalculationInterface(numberOne, numberTwo);

                Console.WriteLine("Do you wish to continue? 'y'/'n'");
                if(Console.ReadLine().ToLower() != "y")
                {
                    break;
                }
            }
        }
    }
}
