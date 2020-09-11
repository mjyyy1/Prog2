using System;
using System.Linq;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 5, 4, 3 };
            Console.WriteLine(Add(nums));

            string[] words = { "Yikes", "Hello", "Oof", "Yes", "No" };
            RevWords(words);

            
            Console.WriteLine("Largest " + BigSmol(nums).Item1 + " Smallest " +  BigSmol(nums).Item2);

        }

        static int Add(int[] nums)
        {
            
            return nums.Sum();
        }

        static void RevWords(string[] words)
        {
            var j = words.Length - 1;
            for (int i = 0; i < words.Length; i++)
            {


                Console.WriteLine(words[j]);

                j--;

            }
        }
    
        static (int,int) BigSmol(int[] nums)//tuples används i dethär sammanhanget för att returna två tal
        {




            return (nums.Max(), nums.Min());
            

        }

    }
}
