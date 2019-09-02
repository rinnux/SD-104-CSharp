using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ans = 0, v1 = 5, v2 = 8;
            ans = v2 % v1++;
            Console.WriteLine(ans);
            Console.ReadLine();
            int a = 0;
            int b = 100;
            int c = 100;
            int result;

            if (a > 10)
                if (b > 10)
                    if (c > 10)
                        result = 1;
                    else
                        if (b > 100)
                        result = 2;
                    else
                        result = 3;
                else
                    result = 4;
            else
                result = 5;
            Console.WriteLine(result);
            Console.ReadLine();

            for (int i = 0; i < 5; i++)
                Console.WriteLine(i + "\t");

            Console.ReadLine();

            int counter = 0;
            while (counter < 100)
            {
                Console.WriteLine(counter);
                counter += 5;

            }
            Console.ReadLine();
           
            int[] anArray = new int[10];
            int[] anotherArray = { 6, 7, 4, 5, 6, 2, 3, 5, 9, 1 };
            int total = 0;
            foreach (int val in anotherArray)
                total += val;
            Console.WriteLine(total);
            Console.ReadLine();

        }
    }  
}
