
//This program find the phone number by name using parallel array
// Lab_6
// Author: Warin Yoongram

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6___Parallel_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] Names = { "Rick Sanchez", "Morty Smith", "Jerry Smith", "Beth Smith", "Summer Smith" };
            String[]Phone = { "555-1334", "555-3882", "555-8211", "555-1617", "555-2803" };
            string strSearch;

            //promt user
            Console.WriteLine("Type a name to search for in the phone book: ");
            strSearch = Console.ReadLine();

            for(int n =0;n<Names.Length;n++)
            {
                if (Names[n].IndexOf(strSearch)> -1)
                {
                    Console.WriteLine(Names[n] + "-> " + Phone[n]);
                }
            }
            Console.ReadLine();

        }
    }
}

/*
Type a name to search for in the phone book:
Smith
Morty Smith-> 555-3882
Jerry Smith-> 555-8211
Beth Smith-> 555-1617
Summer Smith-> 555-2803 */

