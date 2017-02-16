using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_coin_flipping_simulation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Flip coin N times!");

            //Reading and converting user input
            Console.Write("Enter N: ");
            string numberInput = Console.ReadLine();
            int numberValue = 0;

            try
            {
                //Convert number
                //Conversion failures will throw an exception that is handled later, see https://msdn.microsoft.com/en-us/library/bb397679.aspx
                numberValue = Convert.ToInt32(numberInput);
                //Conversion is successful
                //Flipping coin
                if (numberValue <= 0)
                {
                    //Handle negative numbers and zero
                    Console.WriteLine("Number of coin flips must be at least one!", numberValue);
                }
                else
                {
                    //Following printout is just for development time checking
                    //Console.WriteLine("N={0}", numberValue);
                    Random rng = new Random();
                    int randomNumber = 0;
                    int resultHeads = 0;
                    int resultTails = 0;
                    int lowerBound = 0;
                    int upperBound = 1;

                    for (int i = 1; i <= numberValue; i++)
                    {
                        //Flip coin and count results
                        randomNumber = rng.Next(lowerBound, upperBound + 1);
                        //Following printout is just for development time checking
                        //Console.WriteLine("Random number is: {0}", randomNumber);
                        if (randomNumber == 0)
                        {
                            //Tails (klaava)
                            resultTails++;
                        }
                        else
                        {
                            //Heads (kruuna)
                            resultHeads++;
                        }
                    }
                    Console.WriteLine("Coin has been flipped {0} times.", numberValue);
                    Console.WriteLine("There has been {0} tails and {1} heads.", resultTails, resultHeads);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Input is not a valid number!");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Input is out of range (1 - {0})!", int.MaxValue);
            }

            Console.WriteLine("\nPress Enter to exit!");
            Console.ReadLine();
        }
    }
}
