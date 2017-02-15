using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_sort_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array for storing read and converted and finally sorted number values
            int[] numberArray = { 0, 0, 0 };

            bool repeat = false;
            do
            {
                Console.WriteLine("Sorting numbers");

                //Numbers are read one by one, this could be done differently by reading and parsing a string of separated values
                //Read first number
                Console.Write("Enter first number: ");
                string userValue = Console.ReadLine();
                //Simple conversion without any exception handling
                //See also https://msdn.microsoft.com/en-us/library/bb397679.aspx for a more comprehensive example
                int numberValue = Int32.Parse(userValue);
                numberArray[0] = numberValue;

                //Read second number
                Console.Write("Enter second number: ");
                userValue = Console.ReadLine();
                numberValue = Int32.Parse(userValue);
                numberArray[1] = numberValue;

                //Read third number
                Console.Write("Enter third number: ");
                userValue = Console.ReadLine();
                numberValue = Int32.Parse(userValue);
                numberArray[2] = numberValue;

                Console.WriteLine("\n");
                Console.WriteLine("Entered numbers are: ");
                DisplayNumberValues(numberArray);

                SortNumberValues(numberArray);

                Console.WriteLine("\n");
                Console.WriteLine("Sorted numbers are: ");
                DisplayNumberValues(numberArray);

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
        public static void DisplayNumberValues(int[] array)
        {
            for (int i = array.GetLowerBound(0); i <= array.GetUpperBound(0); i++)
            {
                Console.WriteLine("[N={0}] : {1}", i, array[i]);
            }
        }
        public static void SortNumberValues(int[] array)
        {
            //Insertion sort works fine with short arrays
            /*Insertion sort algorithm pseudocode
            function insertionSortR(array A, int n)
                if n>1
                   insertionSortR(A,n-1)
                   x = A[n]
                   j = n-1
                   while j >= 0 and A[j] > x
                       A[j+1] = A[j]
                       j = j-1
                   end while
                   A[j+1] = x
                end if
            end function
            */

            if (array.Length > 1)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    int n = array[i];
                    int j = i - 1;
                    while (j >= 0 && array[j] > n)
                    {
                        array[j + 1] = array[j];
                        j--;
                    }
                    array[j + 1] = n;
                }
            }
        }
    }
}
