using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_dice_throwing_simulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int rollsNumber = 1000;

            Console.WriteLine("Rolling dice {0} times!", rollsNumber);

            Random rng = new Random();
            int randomNumber = 0;
            int resultSixes = 0;
            int lowerBound = 1;
            int upperBound = 6;

            for (int i = 1; i <= rollsNumber ; i++)
            {
                //Roll dice and count sixes
                randomNumber = rng.Next(lowerBound, upperBound + 1);
                Console.WriteLine("{0}: {1}", i, randomNumber);
                if (randomNumber == 6)
                {
                    //Six was rolled
                    resultSixes++;
                }
            }
            //Console.WriteLine("Dice has been rolled {0} times.", rollsNumber);
            Console.WriteLine("Six has been rolled {0} times.", resultSixes);

            Console.WriteLine("\nPress Enter to exit!");
            Console.ReadLine();
        }
    }
}
