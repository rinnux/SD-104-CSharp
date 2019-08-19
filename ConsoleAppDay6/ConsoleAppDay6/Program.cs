using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay6
{
    class Program
    {
        static void Main(string[] args)
        {
            employee myEmployee = new employee("Warin","Yoongram","");
            card myCard = new card ("A", "Heart", 15);
            Console.WriteLine(myCard.Value);
            myCard.Value = 25;
            Console.WriteLine(myCard.Value);


            Console.ReadLine();
        }
    }
}
