using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_check_sign
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = false;
            do
            {
                Console.WriteLine("Checking the sign of a number");
                Console.Write("Enter a number: ");
                string userValue = Console.ReadLine();

                //Simple conversion without any exception handling
                //See also https://msdn.microsoft.com/en-us/library/bb397679.aspx for a more comprehensive example
                int numberValue = Int32.Parse(userValue);

                if (numberValue < 0)
                {
                    Console.WriteLine("Number {0} is negative.", numberValue);
                }
                else if (numberValue > 0)
                {
                    Console.WriteLine("Number {0} is positive.", numberValue);
                }
                else
                {
                    //It is considered that for our purposes 0 is treated unsigned
                    Console.WriteLine("Number {0} is zero!", numberValue);
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
    }
}
