//This program calculate the BMI
// Lab3
//Author Warin Yoongram

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            double dblHeight;
            double dblWeight;
            double dblBMI;

            //user input
            Console.WriteLine("Enter your Height in inches: ");
            dblHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Weight in pounds: ");
            dblWeight = Convert.ToInt32(Console.ReadLine());

            //calculations
            dblBMI = (dblWeight * 703) / (dblHeight * dblHeight);


            //issue result and message
            Console.WriteLine("Your BMI is " + dblBMI);
            if(dblBMI < 18.5)
            {
                Console.WriteLine("BMI < 18.5 -Underweight");
            }
            else if(dblBMI <= 24.9)
            {
               Console.WriteLine("BMI  between 18.5 and 24.9 – Normal");

            }
            else if(dblBMI <= 29.9)
            {
                Console.WriteLine("BMI between 25 and 29.9 – Overweight");

            }
            else
            {
                Console.WriteLine("BMI >=30 -Obese");
            }
            Console.ReadLine();

        }
    }
}

/*Test result
Enter your Height in inches:
70
Enter your Weight in pounds:
120
Your BMI is 17.2163265306122

BMI< 18.5 -Enter your Height in inches:
60
Enter your Weight in pounds:
125
Your BMI is 24.4097222222222
BMI  between 18.5 and 24.9 - Normal

Enter your Height in inches:
72
Enter your Weight in pounds:
195
Your BMI is 26.4438657407407
BMI between 25 and 29.9 - Overweight

Enter your Height in inches:
65
Enter your Weight in pounds:
215
Your BMI is 35.7739644970414
BMI >=30 -Obese

*/
