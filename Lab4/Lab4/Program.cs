// This program perform to  find the largest and smallest number
// Lab4
// Author : Warin Yoongram

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarations
            int nLargest;
            int nSmallest;
            int nCurrent;
            String strEntry;

            //first integer
            Console.WriteLine("Eneter an integer1");
            nLargest = nSmallest = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another interger or Q to Quit");

            strEntry = Console.ReadLine();
            //loop
            while (strEntry != "Q")
            {
                nCurrent = Convert.ToInt32(strEntry);
                //check to see if input should replace largest or smallest
                if (nCurrent > nLargest)
                {
                    nLargest = nCurrent;
                }
                else if (nCurrent < nSmallest)
                {
                    nSmallest = nCurrent;
                }

                Console.WriteLine("Enter another interger or Q to Quit");
                strEntry = Console.ReadLine();

            }


            Console.WriteLine("The largest value you entered was " + nLargest + ".");
            Console.WriteLine("The smallest value you entered was " + nSmallest + ".");
            Console.ReadLine();

        }
    }
}


//Result
/*
Eneter an integer1
25
Enter another interger or Q to Quit
-47
Enter another interger or Q to Quit
85
Enter another interger or Q to Quit
Q
The largest value you entered was 85.
The smallest value you entered was -47.
*
*/
