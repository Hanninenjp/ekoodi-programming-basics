using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_sum_numbers_negative
{
    class Program
    {
        static void Main(string[] args)
        {


            bool success = true;
            do
            {
                Console.WriteLine("Calculate partial sum for a series 1...N or -1...-N");
                Console.Write("Enter N: ");
                string numberInput = Console.ReadLine();
                int numberValue = 0;
                try
                {
                    //Convert number
                    //Conversion failures will throw an exception
                    numberValue = Convert.ToInt32(numberInput);
                    //Conversion is successful, else exception handling is performed
                    if (numberValue == 0)
                    {
                        //Error handling for negative numbers
                        success = false;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Partial sum for N={0} does not exist!", numberValue);
                        Console.ResetColor();
                    }
                    else if (IsPositive(numberValue))
                    {
                        //Calculate partial sum for positive numbers
                        //Display the operation and results
                        string seriesOperation = "Input:" + numberValue + " (N=" + numberValue + " : ";
                        int sumValue = 0;
                        for (int i = 1; i <= numberValue; i++)
                        {
                            //There is no error handling for an overflow
                            sumValue += i;
                            if (i == 1)
                            {
                                seriesOperation += i;
                            }
                            else
                            {
                                seriesOperation += "+" + i;
                            }
                        }
                        seriesOperation += "=" + sumValue + ")";
                        Console.WriteLine(seriesOperation);
                        Console.WriteLine("Sum for N={0} equals {1}!", numberValue, sumValue);
                        //Done
                        success = true;
                    }
                    else
                    {
                        //Calculate partial sum for negative numbers
                        //Display the operation and results
                        string seriesOperation = "Input:" + numberValue + " [N=" + numberValue + " : ";
                        int sumValue = 0;
                        for (int i = -1; i >= numberValue; i--)
                        {
                            //There is no error handling for an overflow
                            sumValue += i;
                            if (i == -1)
                            {
                                seriesOperation += "(" + i + ")";
                            }
                            else
                            {
                                seriesOperation += "+" + "(" + i + ")";
                            }
                        }
                        seriesOperation += "=" + sumValue + "]";
                        Console.WriteLine(seriesOperation);
                        Console.WriteLine("Sum for N={0} equals {1}!", numberValue, sumValue);
                        //Done
                        success = true;
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
                    Console.WriteLine("Input is out of range (1 - {0})!", int.MaxValue);
                    Console.ResetColor();
                }
                Console.WriteLine("\nPress Enter to continue!");
                Console.ReadLine();
                Console.Clear();
            } while (!success);
        }
        public static bool IsPositive (int number)
        {
            return number > 0;
        }
    }
}
