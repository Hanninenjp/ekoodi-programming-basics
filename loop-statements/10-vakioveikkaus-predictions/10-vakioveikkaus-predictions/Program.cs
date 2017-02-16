using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_vakioveikkaus_predictions
{
    class Program
    {
        static void Main(string[] args)
        {
            int matchesNumber = 13;

            Console.WriteLine("Predicting a random {0} match line for Vakioveikkaus!", matchesNumber);

            Random rng = new Random();
            int randomNumber = 0;
            int lowerBound = 0;
            int upperBound = 100;
            string matchResult = "";

            for (int i = 1; i <= matchesNumber; i++)
            {
                //Generate random results for matches
                randomNumber = rng.Next(lowerBound, upperBound);
                //Home win, 40% chance
                if (randomNumber < 40)
                {
                    matchResult = "1";
                }
                //Draw, 20% chance
                else if (randomNumber >= 40 && randomNumber < 59)
                {
                    matchResult = "X";
                }
                //Away win, 40% chance
                else
                {
                    matchResult = "2";
                }

                Console.WriteLine("{0}: {1}", i, matchResult);
            }

            Console.WriteLine("\nPress Enter to exit!");
            Console.ReadLine();
        }
    }
}
