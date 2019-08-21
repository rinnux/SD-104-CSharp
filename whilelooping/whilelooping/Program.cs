using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whilelooping
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int counter;
            Console.WriteLine("Please enter first number");
            number = Convert.ToInt32(Console.ReadLine());

            for (counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(" " + number + " x " + counter + " = " + number * counter);

            }
            Console.ReadLine();

        }
            

    }
}
