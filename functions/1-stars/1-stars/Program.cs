using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_stars
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lets print some stars!");

            //Function returns number of asterisks to display, prompt is passed to the function
            int starsNumber = GetNumericInput("Enter number of stars: ");

            //Error handling
            if (starsNumber == 0)
            {
                Console.WriteLine("Fine, {0} stars are printed!", starsNumber);
            }
            else if (starsNumber < 0)
            {
                Console.WriteLine("Number {0} is negative and is not allowed!", starsNumber);
            }
            else
            {
                //Display asterisks
                Console.WriteLine();
                for (int i = 0; i < starsNumber; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("*");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
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
