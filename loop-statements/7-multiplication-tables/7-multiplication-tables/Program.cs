using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_multiplication_tables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Display multiplication tables");
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine("\n");
                //According to the specification products are only displayed up to N x 9
                //In this example products are displayed up to N x 10 as is commonly done
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }
    }
}
