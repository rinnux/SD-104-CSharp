/*
Project:    Lab 2 Calculate Batting Average
Date:        08/15/2019
Author:     You the big new programmer
Notes:      This program reads in a baseball player's name,
            number of hits and number of at bats.
            The player's batting average is calculated and displayed
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Calculate_Batting_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            //varibalbe declaration
            string strPlayerName;
            double dblHits, nAtBats;
            double dblBattingAverage;
            //prompt for name an receive
            Console.WriteLine("This program calclates a baseball player's batting average");
            Console.WriteLine("<--------------------------------===>");
            Console.WriteLine("Enter the player's name: ");
            strPlayerName = Console.ReadLine();
            //promt for hits
            Console.WriteLine("Eenter the player's # of hits");
            dblHits = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the palyer's # of at bats: ");
            nAtBats = Convert.ToInt32(Console.ReadLine());
            //Calculation
            dblBattingAverage = dblHits / nAtBats;
            Console.WriteLine(strPlayerName + "'s batting average is " + dblBattingAverage);
            Console.ReadLine();


                
        }
    }
}
/*

This program calclates a baseball player's batting average
<--------------------------------===>
Enter the player's name:
warin yoongram
Eenter the player's # of hits
318
Enter the palyer's # of at bats:
14
warin yoongram's batting average is 22.7142857142857
*/