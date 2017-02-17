using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_vowel_count
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Count vowels in the user input!");
            Console.Write("\nEnter a string: ");
            string userInput = Console.ReadLine();
            string convertedInput = userInput.ToUpper();
            int counterValue = 0;
            foreach (char character in convertedInput)
            {
                //There are eight vowels in Finnish language: A, E, I, O, U, Y, Ä, Ö
                //Addionally Å is included for Swedish language
                if (character.Equals('A') || character.Equals('E') || character.Equals('I') || character.Equals('O') || character.Equals('U') || character.Equals('Y') || character.Equals('Å') || character.Equals('Ä') || character.Equals('Ö'))
                {
                    counterValue++;
                }
            }
            Console.WriteLine("\nUser input {0} has {1} occurences of a vowel!", convertedInput, counterValue);
            Console.WriteLine("\nPress Enter to exit.");
            Console.ReadLine();
        }
    }
}
