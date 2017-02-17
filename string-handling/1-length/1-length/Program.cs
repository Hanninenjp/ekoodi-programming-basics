using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_length
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate a number of characters in the user input!");
            Console.WriteLine();
            Console.Write("Enter a string: ");
            string userInput = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("There are {0} characters in the user input.", userInput.Length);
            Console.WriteLine();
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
