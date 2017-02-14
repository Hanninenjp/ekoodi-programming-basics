using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_sum_even_and_odd_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculating sums of 1...N even and odd numbers");
            Console.Write("Enter N: ");
            //Might need to add check for the number, see other exercises
            string numberInput = Console.ReadLine();
            int numberValue = Int32.Parse(numberInput);

            //Following is just for development time checking
            //Console.WriteLine("User input is: {0}", numberInput);
            //Console.WriteLine("Converted number is: {0}", numberValue);
            //Console.ReadLine();

            //string seriesOperationOdd = "";
            //string seriesOperationEven = "";

            //string seriesOperation = "Input:" + numberValue + " (N=" + numberValue + " : ";

            int sumValueOdd = 0;
            int sumValueEven = 0;

            //int sumValue = 0;

            //Value 0 is ignored by the following, will not affect the result
            for (int i = 1; i <= numberValue; i++)
            {
                if (IsOdd(i))
                {
                    sumValueOdd += i;
                }
                else
                {
                    sumValueEven += i;
                }

                //Handling for series operation strings is needed

            }
            //seriesOperation += " = " + sumValue + ")";
            //Console.WriteLine(seriesOperation);

            Console.WriteLine("Sum for N={0} odd numbers equals {1}!", numberValue, sumValueOdd);
            Console.WriteLine("Sum for N={0} even numbers equals {1}!", numberValue, sumValueEven);
            Console.WriteLine("\n");
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }
        public static bool IsOdd (int number)
        {
            return number % 2 != 0;
        }
    }
}
