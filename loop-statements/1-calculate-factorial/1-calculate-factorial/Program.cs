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

            //Reading and converting user input
            Console.Write("Enter N: ");
            string numberInput = Console.ReadLine();
            int numberValue = 0;

            try
            {
                //Convert number
                //Conversion failures will throw an exception that is handled later, see https://msdn.microsoft.com/en-us/library/bb397679.aspx
                numberValue = Convert.ToInt32(numberInput);
                //Conversion is successful
                //Calculating factorial
                if (numberValue < 0)
                {
                    //Handle negative numbers
                    //According to the specification N has to be > 0 therefore for our purposes factorial for negative numbers is not defined
                    //Factorial 0! however is commonly defined and will be calculated
                    //See https://en.wikipedia.org/wiki/Factorial for further details
                    Console.WriteLine("Factorial {0}! is not defined!", numberValue);
                }
                else
                {
                    Console.WriteLine("N={0}", numberValue);

                    //Calculating factorial N!
                    //Following algorithm is not strictly following the mathematical formula for calculating N!, but yields the right result!
                    //Cases 0! = 1, and 1! = 1 could be alternatively handled as exceptions with an if-statement
                    decimal factorialValue = 1;
                    //Decimal type is used for the factorial result with exception handling for overflow
                    //Double type could be alternatively used and infinity could be handled as a special case
                    //See double https://msdn.microsoft.com/en-us/library/system.double(v=vs.110).aspx
                    try
                    {
                        for (int i = 1; i <= numberValue; i++)
                        {
                            checked
                            {
                                factorialValue *= i;
                            }

                        }
                        //Factorial result is a valid number
                        Console.WriteLine("Factorial {0}! equals {1}.", numberValue, factorialValue);
                    }
                    catch (OverflowException e)
                    {
                        //Factorial result is not a valid number
                        Console.WriteLine("Factorial {0}! result is out of range (1 - {1})!", numberValue, decimal.MaxValue);
                        Console.WriteLine("Try entering a smaller N!");
                    }
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Input is not a valid number!");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Input is out of range (1 - {0})!", int.MaxValue);
            }

            Console.WriteLine("\n");
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }
    }
}
