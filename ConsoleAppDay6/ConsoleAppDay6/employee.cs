using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay6
{
    class employee
    {
        string firstName;
        string lastName;
        string dept;

        public employee(string firstName, string lastName, string dept)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dept = dept;

            if (string.IsNullOrEmpty(dept))
            {
                dept = "IT";
            }

            Console.WriteLine("First Name : " + firstName + " Last Name " + lastName + " Dept " + dept);
          //  Console.ReadLine();
        }
    }
}
