using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_sum_even_and_odd_negative
{
    class Program
    {
        static void Main(string[] args)
        {
            bool success = true;
            do
            {
                Console.WriteLine("Calculate partial sums for a series 1...N or -1...-N even and odd numbers");
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
                        //Error handling for zero
                        success = false;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Partial sum for N={0} does not exist!", numberValue);
                        Console.ResetColor();
                    }
                    else if (IsPositive(numberValue))
                    {
                        //Calculate partial sum for positive numbers
                        //Display the operation and results
                        //Initialize display strings for positive odd and even numbers
                        string seriesOperationOdd = "(N=" + numberValue + " : ";
                        string seriesOperationEven = "(N=" + numberValue + " : ";
                        int sumValueOdd = 0;
                        int sumValueEven = 0;
                        for (int i = 1; i <= numberValue; i++)
                        {
                            //There is no error handling for an overflow
                            if (IsOdd(i))
                            {
                                sumValueOdd += i;
                                //Build display string for odd numbers
                                if (i == 1)
                                {
                                    seriesOperationOdd += i;
                                }
                                else
                                {
                                    seriesOperationOdd += "+" + i;
                                }
                            }
                            else
                            {
                                sumValueEven += i;
                                //Build display string for even numbers
                                if (i == 2)
                                {
                                    seriesOperationEven += i;
                                }
                                else
                                {
                                    seriesOperationEven += "+" + i;
                                }
                            }
                        }
                        //Finalize display strings for positive odd and even numbers
                        seriesOperationOdd += "=" + sumValueOdd + ")";
                        seriesOperationEven += "=" + sumValueEven + ")";
                        Console.WriteLine();
                        Console.WriteLine(seriesOperationOdd);
                        Console.WriteLine("Sum for N={0} odd numbers equals {1}!", numberValue, sumValueOdd);
                        Console.WriteLine();
                        Console.WriteLine(seriesOperationEven);
                        Console.WriteLine("Sum for N={0} even numbers equals {1}!", numberValue, sumValueEven);
                        //Done
                        success = true;
                    }
                    else
                    {
                        //Calculate partial sum for negative numbers
                        //Display the operation and results
                        //Initialize display strings for negative odd and even numbers
                        string seriesOperationOdd = "[N=" + numberValue + " : ";
                        string seriesOperationEven = "[N=" + numberValue + " : ";
                        int sumValueOdd = 0;
                        int sumValueEven = 0;
                        for (int i = -1; i >= numberValue; i--)
                        {
                            //There is no error handling for an overflow
                            if (IsOdd(i))
                            {
                                sumValueOdd += i;
                                //Build display string for odd numbers
                                if (i == -1)
                                {
                                    seriesOperationOdd += "(" + i + ")";
                                }
                                else
                                {
                                    seriesOperationOdd += "+" + "(" + i + ")";
                                }
                            }
                            else
                            {
                                sumValueEven += i;
                                //Build display string for even numbers
                                if (i == -2)
                                {
                                    seriesOperationEven += "(" + i + ")";
                                }
                                else
                                {
                                    seriesOperationEven += "+" + "(" + i + ")";
                                }
                            }
                        }
                        //Finalize display strings for negative odd and even numbers
                        seriesOperationOdd += "=" + sumValueOdd + "]";
                        seriesOperationEven += "=" + sumValueEven + "]";
                        Console.WriteLine();
                        Console.WriteLine(seriesOperationOdd);
                        Console.WriteLine("Sum for N={0} odd numbers equals {1}!", numberValue, sumValueOdd);
                        Console.WriteLine();
                        Console.WriteLine(seriesOperationEven);
                        Console.WriteLine("Sum for N={0} even numbers equals {1}!", numberValue, sumValueEven);
                        //Done
                        success = true;
                    }
                    //Similar code in different blocks might be a bit redundant and could potentially be refactored
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
                Console.WriteLine("\nPress Enter to continue!");
                Console.ReadLine();
                Console.Clear();
            } while (!success);
        }
        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
        public static bool IsPositive(int number)
        {
            return number > 0;
        }
    }
}
