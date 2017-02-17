using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_character_count
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count specific characters in the user input!");
            Console.Write("\nEnter a string: ");
            string userInput = Console.ReadLine();
            string convertedInput = userInput.ToUpper();
            int counterValue = 0;
            foreach (char character in convertedInput)
            {
                if (character.Equals('L'))
                {
                    counterValue++;
                }
            }
            Console.WriteLine("\nUser input {0} has {1} occurences of character L!", convertedInput, counterValue);
            Console.WriteLine("\nPress Enter to exit.");
            Console.ReadLine();
        }
    }
}
