


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGCD
{
    class Program
    {
        static int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            if (a == 0)
                return b;
            else
                return a;
        }

        static void Main(string[] args)
        {
            int N1;
            int N2;
            int result;

            string tryMore;

            do
            {


                
                    Console.WriteLine(" Please enter first number : ");

                    String line1 = Console.ReadLine();

                    while (!Int32.TryParse(line1, out N1))
                    {
                        Console.WriteLine(" Not a valid number, try again.");
                        line1 = Console.ReadLine();
                    }
                    Console.WriteLine(" Please enter Second number : ");

                    String line2 = Console.ReadLine();

                    while (!Int32.TryParse(line2, out N2))
                    {
                        Console.WriteLine(" Not a valid number, try again.");
                        line2 = Console.ReadLine();
                    }

                if (N1 < N2)
                {
                    Console.WriteLine(" This is Invalid");
                    Console.WriteLine(" First number must be greater than second number");
                                 
                }
                else
                {

                    result = GCD(N1, N2);

                    Console.WriteLine(" The GCD of " + N1 + " and " + N2 + " is " + result);
            
                }

                    Console.WriteLine("");
                    Console.WriteLine(" Do you want to try more![Y]");
                   (tryMore) = Console.ReadLine();

                } while (tryMore.ToUpper() == "Y") ;

            }
            
    }
}

/*
 *  Please enter first number :
182
 Please enter Second number :
74
 The GCD of 182 and 74 is 2

 Do you want to try more![Y]
*/