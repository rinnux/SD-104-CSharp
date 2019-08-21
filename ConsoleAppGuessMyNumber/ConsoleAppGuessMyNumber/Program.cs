//C# Lab 4 - Guess My Number
//Author: Warin Yoongram
///
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool strTryAgain = true;
          

            do
            {
                Random rand = new Random();
                int hidden;
                int guessNumber;
                int counter = 1;

                while (true)
                {
                    hidden = rand.Next(100);

                    try
                    {
                        // Console.WriteLine(hidden);
                        Console.WriteLine("Please Guess number between 0-100 : ");
                        guessNumber = Convert.ToInt32(Console.ReadLine());




                        if (guessNumber > hidden)
                        {
                            Console.WriteLine("Your number is too hight, try again");
                            ++counter;
                            continue;
                        }
                        else if (guessNumber < hidden)
                        {
                            Console.WriteLine("Your number is too low,try again");
                            ++counter;
                            continue;
                        }

                        else
                        {
                            Console.WriteLine("Congratulations. You guessed the number!");
                            Console.WriteLine("Do you want to try again[Y/N]?");
                            string answer = Console.ReadLine();
                            if (answer.ToUpper() != "Y")
                            {
                                strTryAgain = false;
                            }
                            break;
                        }
                    }
                    catch(FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    // ask user for a number
                    // keep guessing until they guess the number

                }
              
            } while (strTryAgain);
        }
    }
}

/*
 * Please Guess number between 0-100 :
54
Your number is too hight, try again
Please Guess number between 0-100 :
87
Your number is too hight, try again
Please Guess number between 0-100 :
5
Your number is too low,try again
Please Guess number between 0-100 :
25
Your number is too hight, try again
Please Guess number between 0-100 :
4
Your number is too low,try again
Please Guess number between 0-100 :
8
Your number is too low,try again
Please Guess number between 0-100 :
9
Your number is too low,try again
Please Guess number between 0-100 :
3
Your number is too low,try again
Please Guess number between 0-100 :
85
Your number is too hight, try again
Please Guess number between 0-100 :
74
Your number is too hight, try again
Please Guess number between 0-100 :

 * 
 */
