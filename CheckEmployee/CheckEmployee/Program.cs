using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
            employee1.setNames();
        }

        static void currentDepartment(employee isEmployed)
        {
          //  if(isEmployed.department == null)
            if(string.IsNullOrEmpty(isEmployed.department))
            {
                Console.WriteLine("He is in IT Department");
              
            }
            else
            {
                Console.WriteLine("He is in HR Department");
            }
        }


        class employee
        {
            public string name;
            public string lastName;
            public string department;
        }

        class private setNames()
        {

        }
    }
    
   
}
