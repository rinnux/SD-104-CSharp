// This program display fibonacci series.
// HW2-Fibonacci
//Author : Warin Yoongram

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables 
            int firstValue;
            int secondValue;
            int thirdValue;
            int terms;
            firstValue = 0;
            secondValue = 1;
            // promt to get last position
            Console.WriteLine("Fibonacci Series");
            Console.WriteLine();
            Console.Write("Enter the last position: ");
            terms = Convert.ToInt32(Console.ReadLine());
            // Display fibonacci numbers
            Console.Write(firstValue + "  " + secondValue+" ");
            for (int i = 3; i <= terms; i++)

            {
                thirdValue = firstValue + secondValue;
                Console.Write(thirdValue + " ");
                firstValue = secondValue;
                secondValue = thirdValue;
            }
            Console.ReadLine();
        }
    }
}

/*Fibonacci Series result

Enter the last position: 25
0  1 1 2 3 5 8 13 21 34 55 89 144 233 377 610 987 1597 2584 4181 6765 10946 17711 28657 46368
 * 

*/