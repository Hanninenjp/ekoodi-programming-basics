using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_calculate_factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Could be Calculating a factorial N!, Enter N:
            Console.WriteLine("Calculating a factorial");
            Console.Write("Enter a number: ");
            //Need to add check for the number, has to be positive and > 1 according to the specification
            //However factorial 0! is also defined according to the convention for an empty product
            //Therefore factorial 0! can be also calculated
            //See https://en.wikipedia.org/wiki/Factorial for further details
            string numberInput = Console.ReadLine();
            int numberValue = Int32.Parse(numberInput);

            //Following is just for development time checking
            //Console.WriteLine("User input is: {0}", numberInput);
            //Console.WriteLine("Converted number is: {0}", numberValue);
            //Console.ReadLine();

            //Following is not strictly following the right formula for calculating N, but should yield the right result!
            //Cases 0! = 1, and 1! = 1 could be handled as exceptions with an if-statement and the logic could be written differently
            //Rewrite this!
            int factorialValue = 1;
            for (int i = 1; i <= numberValue; i++)
            {
                factorialValue *= i;
            }
            Console.WriteLine("Factorial {0}! equals {1}!", numberValue, factorialValue);
            Console.WriteLine("\n");
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }
    }
}
