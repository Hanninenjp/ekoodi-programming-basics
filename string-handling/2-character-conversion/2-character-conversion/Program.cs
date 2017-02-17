using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_character_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convert characters in the user input!");
            Console.Write("\nEnter a string: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("\nUser input: {0}", userInput);
            //Replace both upper case 'E' and lower case 'e' with '@'
            string convertedInput = userInput.Replace("e", "@").Replace("E", "@");
            Console.WriteLine("Converted input: {0}", convertedInput);
            Console.WriteLine("\nPress Enter to exit.");
            Console.ReadLine();
        }
    }
}
