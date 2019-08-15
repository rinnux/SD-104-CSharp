using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            employee myEmployee = new employee();
            myEmployee.FirstName = "John";
            myEmployee.LastName = "Doe";
            myEmployee.Dept = null;

            AssignDept(myEmployee);
            Console.WriteLine(myEmployee.Dept);
            Console.ReadLine();
        }


        static void AssignDept (employee emp)
        {
            if (string.IsNullOrEmpty(emp.Dept))
            {
                emp.Dept = "Sale";
            }
        }

        class employee
        {
            public string FirstName;
            public string LastName;
            public string Dept;
        }
    }
}
