// Lab 6 - Leap Year
// Author : Warin Yoongram



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Leap_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                //Declarations
                int nYear;
                bool isDiv4;
                bool isDiv100;
                bool isDiv400;

                //validate year input
                do
                {
                    Console.WriteLine("Please Enter a Year to see if it was or will be a leap year: ");

                } while (!int.TryParse(Console.ReadLine(), out nYear));

                //calculate factors

                isDiv4 = nYear % 4 == 0 ? true : false;
                isDiv100 = nYear % 100 == 0 ? true : false;
                isDiv400 = nYear % 400 == 0 ? true : false;

                //Compound test to see if nYear is a leap year
                if ((isDiv4&& isDiv100&& isDiv400) || (isDiv4 && !isDiv100&& !isDiv400))
                {
                    Console.WriteLine(nYear + " is a leap year.");

                }
                else
                {
                    Console.WriteLine(nYear + " is not a leap year.");
                }

                Console.WriteLine("Would you like to test another year? Type Y for Yes or any other key to quit");
            } while (Console.ReadLine().ToUpper() == "Y");
         }  
    }
}

/*
 * Please Enter a Year to see if it was or will be a leap year:
2000
2000 is a leap year.
Would you like to test another year? Type Y for Yes or any other key to quit
y
Please Enter a Year to see if it was or will be a leap year:
2001
2001 is not a leap year.
Would you like to test another year? Type Y for Yes or any other key to quit

 */