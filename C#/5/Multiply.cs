using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Multiply
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator. Enter your first digit you want to multiply:");
            int dig1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Great, now enter the second digit:");
            int dig2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nThe numbers you entered multiplied together = ");
            Console.WriteLine(Multiplier(dig1,dig2));
        }

        static long Multiplier(int a, int b)
        {
            return a * b;
        }
    }
}
