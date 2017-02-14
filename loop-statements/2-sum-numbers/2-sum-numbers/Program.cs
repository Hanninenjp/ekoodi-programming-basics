using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_sum_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculating a partial sum for a series as a sum of numbers 1...N");
            Console.Write("Enter N: ");
            //Need to add check for the number, has to be positive and > 1 according to the specification
            string numberInput = Console.ReadLine();
            int numberValue = Int32.Parse(numberInput);

            //Following is just for development time checking
            //Console.WriteLine("User input is: {0}", numberInput);
            //Console.WriteLine("Converted number is: {0}", numberValue);
            //Console.ReadLine();

            int sumValue = 1;
            for (int i = 1; i <= numberValue; i++)
            {
                sumValue += i;
            }
            Console.WriteLine("Sum for N={0} equals {1}!", numberValue, sumValue);
            Console.WriteLine("\n");
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }
    }
}
