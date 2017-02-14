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
            Console.WriteLine("Calculating a sum of numbers 1...N or -1...-N");
            Console.Write("Enter N: ");
            //Might need to add some checks for the number
            string numberInput = Console.ReadLine();
            int numberValue = Int32.Parse(numberInput);

            //Following is just for development time checking
            //Console.WriteLine("User input is: {0}", numberInput);
            //Console.WriteLine("Converted number is: {0}", numberValue);
            //Console.ReadLine();

            string seriesOperation = "";
            int sumValue = 0;

            if (IsPositive(numberValue))
            {
                seriesOperation = "Input:" + numberValue + " (N=" + numberValue + " : ";
                //Sum positive number series 1...N
                for (int i=1; i <= numberValue; i++)
                {
                    sumValue += i;
                    if (i == 1)
                    {
                        seriesOperation += i;
                    }
                    else
                    {
                        seriesOperation += " + " + i;
                    }
                }
                seriesOperation += " = " + sumValue + ")";
            }
            else
            {
                seriesOperation = "Input:" + numberValue + " [N=" + numberValue + " : ";
                //Sum negative number series -1...-N
                for (int i=-1; i >= numberValue; i--)
                {
                    sumValue += i;
                    if (i == -1)
                    {
                        seriesOperation += "(" + i + ")";
                    }
                    else
                    {
                        seriesOperation += " + (" + i + ")";
                    }
                }
                seriesOperation += " = " + sumValue + "]";
            }

            Console.WriteLine(seriesOperation);
            Console.WriteLine("Sum for N={0} equals {1}!", numberValue, sumValue);
            Console.WriteLine("\n");
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }
        public static bool IsPositive (int number)
        {
            return number > 0;
        }
    }
}
