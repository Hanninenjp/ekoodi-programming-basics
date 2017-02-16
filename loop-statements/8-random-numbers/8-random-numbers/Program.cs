using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_random_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Display random numbers\n");
            //Create a pseudo-random number generator object, see https://msdn.microsoft.com/en-us/library/system.random(v=vs.110).aspx
            Random rng = new Random();
            for (int i = 1; i <= 4; i++)
            {
                Console.Write("Row {0}: ", i);
                //According to the specification random numbers shall be within range [0-50]
                int lowerBound = 0;
                int upperBound = 50;
                for (int j = 1; j <= 5; j++)
                {
                    //Random.Next lower bound is inclusive of the value, but upper bound is exclusive of the value
                    int randomNumber = rng.Next(lowerBound, upperBound + 1);
                    if (j == 1)
                    {
                        Console.Write("{0}", randomNumber);
                    }
                    else
                    {
                        Console.Write(", {0}", randomNumber);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }
    }
}
