using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace averageMethod
{
    class Program
    {

        static int CalculateAverage(int Val1, int Val2)
        {
            int result;
            result = (Val1 + Val2) / 2;
            return result;
        }


        static void Main(string[] args)
        {
            int number1, number2;
            int averNumber;

            Console.WriteLine("Enter your number to calculate average");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your number to calculate average");
            number2 = Convert.ToInt32(Console.ReadLine());

            averNumber = CalculateAverage(number1, number2);
            Console.WriteLine(" The average number is : " + averNumber);

            if (averNumber > 25)
            {
                Console.WriteLine("The number is too high");
            }
            else
            {
                Console.WriteLine("The number is too low");
            }

            Console.ReadLine();
        }

    }
}
