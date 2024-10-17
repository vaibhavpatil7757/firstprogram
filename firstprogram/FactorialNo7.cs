using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstprogram
{
    internal class FactorialNo7
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            long factorial = 1;

            
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Factorial of {number} is {factorial}");
        }
    }
}
