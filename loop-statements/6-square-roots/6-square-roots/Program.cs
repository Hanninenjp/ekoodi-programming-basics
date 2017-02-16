using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_square_roots
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate square roots for numbers 1-10");
            Console.WriteLine("\nNumber\tSquare Root");
            for (int i = 1; i <= 10; i++)
            {
                double sqrtValue = Math.Sqrt(i);
                //Square root value is fixed-point formatted with 2 decimal digits, see https://msdn.microsoft.com/en-us/library/dwhawy9k(v=vs.110).aspx
                Console.WriteLine("{0}\t{1:F2}", i, sqrtValue);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }
    }
}
