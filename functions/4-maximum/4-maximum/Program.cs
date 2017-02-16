using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 10 numbers.");

            //Specification is not entirely clear about the division of functionality between the caller and the function
            //The function is anyway implied to be loaded with different types of tasks that might be better divided to different functions
            //It is stated that the function shall return the maximum input value, this is done
            //However, if also the index of the maximum input value should be printed by the caller, this is not enough
            //Now, these tasks are taken care of by the function itself
            int numberValue = GetTenPositiveIntegersAndFindTheMaximumAndPrintoutThings();
            
            //Following is just for development time testing of the return value
            //Console.WriteLine("Great, {0} is such a fine number!", numberValue);

            Console.WriteLine();
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }
        public static int GetTenPositiveIntegersAndFindTheMaximumAndPrintoutThings()
        {
            int numberValue = 0;
            int maximumValue = 0;
            int maximumValueIndex = 0;
            int inputsCollected = 0;
            int[] inputsCollectedArray = new int[10] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            bool done = false;
            while (!done)
            {
                //Prompt user
                Console.Write("Enter number {0}: ", inputsCollected + 1);
                //Read user input
                string numberInput = Console.ReadLine();
                //Make conversion and perform exception handling for the user input
                try
                {
                    //Convert number
                    //Conversion failures will throw an exception
                    numberValue = Convert.ToInt32(numberInput);
                    //Conversion is successful, else exception handling is performed

                    if (numberValue < 0)
                    {
                        //Error handling and try again
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Input is not valid, enter a positive value!");
                        Console.ResetColor();
                    }
                    else if (numberValue == 0)
                    {
                        //Error handling and try again
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Input is not valid, enter a positive value!");
                        Console.ResetColor();
                    }
                    else
                    {
                        //Success
                        //Store the collected input value
                        inputsCollectedArray[inputsCollected] = numberValue;

                        //Find the maximum input value
                        //Multiple same input values are ignored and the first occurence is treated as the maximum for our purposes
                        if (numberValue > maximumValue)
                        {
                            maximumValue = numberValue;
                            maximumValueIndex = inputsCollected + 1;
                        }
                        
                        //Done with this input
                        inputsCollected++;

                        if (inputsCollected == 10)
                        {
                            //Done with all the inputs
                            done = true;
                        }
                    }
                }
                catch (FormatException e)
                {
                    //Error handling and try again
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Input is not a valid number!");
                    Console.ResetColor();
                }
                catch (OverflowException e)
                {
                    //Error handling and try again
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Input is not within the supported input range [{0} - {1}]!", int.MinValue, int.MaxValue);
                    Console.ResetColor();
                }
            }

            //Printout the numbers and the index and value of the maximum value
            Console.WriteLine("Following numbers were entered:");
            foreach (int number in inputsCollectedArray)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
            Console.WriteLine("The {0}. number entered is the maximum {1}.", maximumValueIndex, maximumValue);

            return maximumValue;
        }
    }
}
