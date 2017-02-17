using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_palindrome_check
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check if user input is a palindrome!");
            Console.Write("\nEnter a string: ");
            string userInput = Console.ReadLine();

            //Replace method is used to remove spaces from user input
            //Resulting string is also converted to upper case to deal with varying case and capitalization
            //Alternative for using replace could be to use regular expressions
            //Something like this: string forwardString = Regex.Replace(userInput, @"\s+", "");
            //Also requires: using System.Text.RegularExpressions;
            string forwardString = userInput.Replace(" ", String.Empty).ToUpper();

            string backwardString = String.Empty;

            //Iterate through string characters in backward order and build a reverse ordered string
            foreach (char character in forwardString.Reverse())
            {
                backwardString += character;
            }

            //Following are just for development time checking
            //Console.WriteLine(forwardString);
            //Console.WriteLine(backwardString);

            //Test for palindrome
            //Strings have to be equal in both directions to qualify as a palindrome
            if (String.Equals(forwardString, backwardString))
            {
                //Palindrome
                Console.WriteLine("\nUser input {0} is a palindrome.", userInput.ToUpper());
            }
            else
            {
                //Not palindrome
                Console.WriteLine("\nUser input {0} is not a palindrome.", userInput.ToUpper());
            }

            Console.WriteLine("\nPress Enter to exit.");
            Console.ReadLine();
        }
    }
}
