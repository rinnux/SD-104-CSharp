using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            employee employee1 = new employee();
            employee1.name = " Warin";
            employee1.lastName = "Yoongram";
            employee1.department = null;

            currentDepartment(employee1);
            Console.WriteLine(employee1.department);
            Console.ReadLine();
        }

        static void currentDepartment(employee isEmployed)
        {
            if(isEmployed == null)
            {
                Console.WriteLine("He is in IT Department");
              
            }
            else
            {
                Console.WriteLine("He is in HR Department");
            }
        }
    }
    
   
    class employee
    {
        public string name;
        public string lastName;
        public string department;
    }
}
