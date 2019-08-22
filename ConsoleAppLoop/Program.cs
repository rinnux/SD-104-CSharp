using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int integerSum = 0;
            while (i != 5)
            {
                Console.WriteLine("Please enter Integer {0} now.", (i + 1));
                string rawInput = Console.ReadLine();
                int integerInput;
                if (!int.TryParse(rawInput, out integerInput))
                {
                    Console.WriteLine("This is not a valid integer. Please enter a valid integer now:");
                    continue;
                }
                integerSum += integerInput;
                i++;
               
            }

            Console.WriteLine("The sum of all number is " + integerSum);
            Console.ReadLine();
        }
    }
}
