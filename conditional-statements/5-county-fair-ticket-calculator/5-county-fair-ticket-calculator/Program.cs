using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_county_fair_ticket_calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            bool repeat = false;
            do
            {
                Console.WriteLine("Calculating county fair ticket price");

                /*
                Perustiedot

                Kysytään asiakkaan tiedot
                Lasketaan alennus
                Ilmoitetaan lipun hinta
                Ehdot: Vain yksi alennus myönnetään. Paitsi, jos on opiskelija sekä Mtk: n jäsen, hän saa molemmat alennukset.

                Normaalihinta 16 e
                Alle 7 v.ilmaiseksi
                65 v.ja yli: 50 % alennus
                7 - 15 v. 50 % alennus
                Mtk jäsen: 15 % alennus
                Varusmies: 50 % alennus
                Opiskelija: 45 % alennus
                */

                //Reading customer age
                Console.Write("Enter customer age: ");
                string userInput = Console.ReadLine();
                int customerAge = Int32.Parse(userInput);

                //Checking student status
                Console.Write("Is customer a student (Y/N)?: ");
                userInput = Console.ReadLine();
                bool statusStudent = false;
                if (userInput == "Y" || userInput == "y")
                {
                    statusStudent = true;
                }

                //Checking conscript status
                Console.Write("Is customer a conscript (Y/N)?: ");
                userInput = Console.ReadLine();
                bool statusConscript = false;
                if (userInput == "Y" || userInput == "y")
                {
                    statusConscript = true;
                }

                //Checking MTK membership status
                Console.Write("Is customer an MTK member (Y/N)?: ");
                userInput = Console.ReadLine();
                bool statusMember = false;
                if (userInput == "Y" || userInput == "y")
                {
                    statusMember = true;
                }

                //Following is just for development time checking
                //Console.WriteLine("Customer age is: {0}", customerAge);
                //Console.WriteLine("Student: {0}", statusStudent);
                //Console.WriteLine("Conscript: {0}", statusConscript);
                //Console.WriteLine("Member: {0}", statusMember);

                double discountPercentage = 0;

                //First apply age based discounts, then apply status based discounts, if ticket price was not already discounted
                if (customerAge < 7)
                {
                    //Free entry, apply 100% discount
                    discountPercentage = 1;
                }
                else if (customerAge >= 7 && customerAge <= 15)
                {
                    //Apply 50% discount
                    discountPercentage = 0.50;
                }
                else if (customerAge >= 65)
                {
                    //Apply 50% discount
                    discountPercentage = 0.50;
                }
                else
                {
                    //No age based discount, apply status based discounts
                    if (statusStudent)
                    {
                        //Check also MTK membership for students
                        if (statusMember)
                        {
                            //Student and MTK member
                            //Apply both 45% student discount and 15% MTK membership discount 
                            discountPercentage = 0.60;
                        }
                        else
                        {
                            //Student, but not MTK member
                            //Check also conscript status and apply 50% discount, if conscript
                            if (statusConscript)
                            {
                                //Apply 50% conscript discount
                                discountPercentage = 0.50;
                            }
                            else
                            {
                                //Apply only 45% student discount
                                discountPercentage = 0.45;
                            }
                        }
                    }
                    else if (statusConscript)
                    {
                        //Apply 50% conscript discount
                        discountPercentage = 0.50;
                    }
                    else if (statusMember)
                    {
                        //Apply 15% MTK member discount
                        discountPercentage = 0.15;
                    }
                }

                //Ticket base price
                double ticketPrice = 16;
                //Format ticket price using a format string, display two decimals, see https://msdn.microsoft.com/en-us/library/s8s7t687.aspx
                Console.WriteLine("Ticket price is: {0:F2} EUR", ticketPrice);
                Console.WriteLine("Discount percentage is: {0}%", discountPercentage * 100);
                ticketPrice -= ticketPrice * discountPercentage;
                //Note, it seems that currency symbol € is not displayed correctly by the console application,
                //therefore currency code is hardcoded and is displayed according to the corresponding ISO 4217 currency code (EUR)
                Console.WriteLine("Discounted ticket price is: {0:F2} EUR", ticketPrice);

                Console.WriteLine("\n");
                Console.Write("Do again (Y/N): ");
                string again = Console.ReadLine();
                if (again == "y" || again == "Y")
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;
                }
                Console.Clear();
            } while (repeat);

        }
    }
}
