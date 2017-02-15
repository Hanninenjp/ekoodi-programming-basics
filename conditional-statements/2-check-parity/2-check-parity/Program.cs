using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_check_parity
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = false;
            do
            {
                Console.WriteLine("Checking the parity of a number");
                Console.Write("Enter a number: ");
                string userValue = Console.ReadLine();

                //Simple conversion without any exception handling
                //See also https://msdn.microsoft.com/en-us/library/bb397679.aspx for a more comprehensive example
                int numberValue = Int32.Parse(userValue);

                if (IsEven(numberValue))
                {
                    //By definition number 0 is even and will fall in this category
                    Console.WriteLine("Number {0} is even.", numberValue);
                }
                else if (IsOdd(numberValue))
                {
                    Console.WriteLine("Number {0} is odd.", numberValue);
                }
                else
                {
                    Console.WriteLine("Strange, number {0} should be either odd or even!", numberValue);
                }

                Console.WriteLine("\n");
                Console.Write("Do again (Y/N): ");
                string again = Console.ReadLine();
                if (again == "y" || again == "Y")
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;
                }
                Console.Clear();
            } while (repeat);
        }
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
        public static bool IsEven(int value)
        {
            return value % 2 == 0;
        }
    }
}
