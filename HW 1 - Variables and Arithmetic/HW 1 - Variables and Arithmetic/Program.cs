using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1___Variables_and_Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare varialbles
            double firstNumber;
            double secondNumber;
            double dblResult;

            //Prompt for first number and second number
            Console.WriteLine("This program asks for two intergers. Display their sum,product, difference and quotient ");
            Console.WriteLine("<-------------------------------------------------------------------------------------->");
            Console.WriteLine("");
            //Prompt for first number
            Console.WriteLine("Enter the first number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            //Prompt for second number
            Console.WriteLine("Enter the second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            //Calculation
            dblResult = firstNumber + secondNumber;

            Console.WriteLine("The sum of two numbers is : " + dblResult);
            dblResult = firstNumber - secondNumber;
            Console.WriteLine("The difference of two numbers is : " + dblResult);
            dblResult = firstNumber * secondNumber;
            Console.WriteLine("The product of two numbers is : " + dblResult);
            if (secondNumber != 0)
            {
                dblResult = firstNumber / secondNumber;
                Console.WriteLine("The quoteint of two number is : " + dblResult);
            }
            else
            {
                Console.WriteLine("Division by zoro is not allowed");
            }
            /*
            try
            {
                dblResult = firstNumber / secondNumber;
                Console.WriteLine("The quoteint of two number is :" + dblResult);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division of {0} by zero.", firstNumber);
            }
            */
            Console.ReadLine();


        }
    }
}
