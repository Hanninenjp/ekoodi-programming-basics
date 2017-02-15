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
            Console.WriteLine("Calculate factorial N!");
            Console.Write("Enter N: ");
            //Need to add check for the number, has to be positive and > 1 according to the specification
            //However factorial 0! is also defined according to the convention for an empty product
            //Therefore factorial 0! can be also calculated
            //See https://en.wikipedia.org/wiki/Factorial for further details
            string numberInput = Console.ReadLine();
            int numberValue = 0; // Int32.Parse(numberInput);
            //Convert number with some error handling, see https://msdn.microsoft.com/en-us/library/bb397679.aspx
            try
            {
                numberValue = Convert.ToInt32(numberInput);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Input string is not a sequence of digits.");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("The number cannot fit in an Int32.");
            }

            if (numberValue < 0)
            {
                //Error handling for negative numbers
                Console.WriteLine("N must be 0 or a positive integer!", numberValue + 1);
            }
            else
            {
                Console.WriteLine("N={0}", numberValue);
                //Calculate factorial N!
                //Following is not strictly following the right formula for calculating N!, but yields the right result!
                //Cases 0! = 1, and 1! = 1 could be handled as exceptions with an if-statement and the logic could be written differently
                int factorialValue = 1;
                for (int i = 1; i <= numberValue; i++)
                {
                    factorialValue *= i;
                }
                Console.WriteLine("Factorial {0}! equals {1}!", numberValue, factorialValue);
            }

            Console.WriteLine("\n");
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }
    }
}
