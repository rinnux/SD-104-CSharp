// This program compare three numbers to find max and min number
// HM Day 2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Day_2_Compare_3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare varialbles
            int firstNumber;
            int secondNumber;
            int thirdNumber;
            int maxNumber;
            int minNumber;
            // promt user to enter three numbers
            Console.WriteLine("This program will compare three number");
            Console.WriteLine("<-------------------------------------->");
            //promt for the first number
            Console.WriteLine("Enter first number :");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            //promt for the second number
            Console.WriteLine("Enter second number :");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            //promt for the third number
            Console.WriteLine("Enter third number :");
            thirdNumber = Convert.ToInt32(Console.ReadLine());

            // compare three numbers to find max number
            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                maxNumber = firstNumber;

            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                maxNumber = secondNumber;
            }
            else
            {
                maxNumber = thirdNumber;
            }

            // compare three numbers to find min number
            if (firstNumber < secondNumber && firstNumber < thirdNumber)
            {
                minNumber = firstNumber;

            }
            else if (secondNumber < firstNumber && secondNumber < thirdNumber)
            {
                minNumber = secondNumber;
            }
            else
            {
                minNumber = thirdNumber;
            }

            //print the results
            Console.WriteLine(" First Number : " + firstNumber + " Second Number : " + secondNumber + " thirdNumber : " + thirdNumber + " MaxNumber is : " + maxNumber);
            Console.WriteLine(" First Number : " + firstNumber + " Second Number : " + secondNumber + " thirdNumber : " + thirdNumber + " MinNumber is : " + minNumber);

            Console.ReadLine();

        }
    }
}
