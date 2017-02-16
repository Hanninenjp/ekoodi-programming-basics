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
            string matchResult = "";

            for (int i = 1; i <= matchesNumber; i++)
            {
                //Generate random results for matches, within range [0-99]
                int lowerBound = 0;
                int upperBound = 100;
                int randomNumber = rng.Next(lowerBound, upperBound);
                //Home win, 40% chance, within range [0-39]
                if (randomNumber < 40)
                {
                    matchResult = "1";
                }
                //Draw, 20% chance, within range [40-59]
                else if (randomNumber >= 40 && randomNumber < 60)
                {
                    matchResult = "X";
                }
                //Away win, 40% chance, within range [60-99]
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
