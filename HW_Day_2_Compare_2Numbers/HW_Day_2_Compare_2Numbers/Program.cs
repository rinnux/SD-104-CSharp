//This program compare two number for find the larger number
//Home Work Day 2
// Warin Yoongram
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Day_2_Compare_2Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstNumber, secondNumber;
            Console.WriteLine("This Program compare two number and display the largest number");
            Console.WriteLine("<----------------------------------------------------------->");
            Console.WriteLine("Enter first number :");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("First number is larger than Second number");
            }
            else if (firstNumber == secondNumber)
            {
                Console.WriteLine("Both numbers are equal");
            }
            else
            {
                Console.WriteLine("Second Number is larger");
            }
   
            Console.ReadLine();
        }
    }
}
