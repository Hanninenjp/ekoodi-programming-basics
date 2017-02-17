using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_minimum
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Find a minimum of set of two numbers!");

            int firstNumber = GetNumericInput("Enter the first number: ");
            int secondNumber = GetNumericInput("Enter the second number: ");

            //Equality is not handled as a special case
            int minNumber = GetMinValue(firstNumber, secondNumber);

            Console.WriteLine("Minimum of {{{0},{1}}} is {2}).", firstNumber, secondNumber, minNumber);
            Console.WriteLine();
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }
        public static int GetMinValue(int firstValue, int secondValue)
        {
            return Math.Min(firstValue, secondValue);
        }
        public static int GetNumericInput(string prompt)
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
                    //Done
                    success = true;
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
