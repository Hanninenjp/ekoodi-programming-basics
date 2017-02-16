using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_number_range
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowerBoundary = 1;
            int upperBoundary = 100;

            Console.WriteLine("Checking if number is within range [{0}-{1}]!", lowerBoundary, upperBoundary);

            //Not strictly according to the specification, because the prompt is also passed to the function
            int numberValue = GetNumericInputWithinRange("Enter a number: ", lowerBoundary, upperBoundary);

            Console.WriteLine("Great, {0} is within the target range [{1}-{2}]!", numberValue, lowerBoundary, upperBoundary);

            Console.WriteLine();
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }
        public static int GetNumericInputWithinRange(string prompt, int lowerBoundary, int upperBoundary)
        {
            int numberValue = 0;
            bool success = true;
            do
            {
                //Prompt user
                Console.Write(prompt);
                //Read user input
                string numberInput = Console.ReadLine();
                //Make conversion and perform exception handling for the user input
                try
                {
                    //Convert number
                    //Conversion failures will throw an exception
                    numberValue = Convert.ToInt32(numberInput);
                    //Conversion is successful, else exception handling is performed
                    if (numberValue >= lowerBoundary && numberValue <= upperBoundary)
                    {
                        //Done
                        success = true;
                    }
                    else
                    {
                        //Not within the range
                        success = false;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Input is not within the target range [{0}-{1}]!", lowerBoundary, upperBoundary);
                        Console.ResetColor();
                    }
                }
                catch (FormatException e)
                {
                    success = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Input is not a valid number!");
                    Console.ResetColor();
                }
                catch (OverflowException e)
                {
                    success = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Input is not within the supported input range [{0} - {1}]!", int.MinValue, int.MaxValue);
                    Console.ResetColor();
                }
            } while (!success);
            return numberValue;
        }
    }
}
