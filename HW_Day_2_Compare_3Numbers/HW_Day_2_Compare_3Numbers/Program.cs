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

            int firstNumber, secondNumber, thirdNumber, maxNumber, minNumber;
            Console.WriteLine("This program will compare three number");
            Console.WriteLine("<-------------------------------------->");
            Console.WriteLine("Enter first number :");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number :");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number :");
            thirdNumber = Convert.ToInt32(Console.ReadLine());

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


            Console.WriteLine(" First Number : " + firstNumber + " Second Number : " + secondNumber + " thirdNumber : " + thirdNumber + " MaxNumber is : " + maxNumber);
            Console.WriteLine(" First Number : " + firstNumber + " Second Number : " + secondNumber + " thirdNumber : " + thirdNumber + " MinNumber is : " + minNumber);

            Console.ReadLine();

        }
    }
}
