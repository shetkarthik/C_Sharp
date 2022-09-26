using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class Enum
    {
        enum Employee
        {
            David,
            Sachin = 101,
            John = 102,
            Dexter = 103,
           
        }
        public static void Main()
        {
            Console.WriteLine(Employee.David);
            int methods = (int)Employee.Sachin;
            Console.WriteLine(methods);
            var empname = (Employee)103;
            Console.WriteLine(empname);
            int id = (int)Employee.John;
            Console.WriteLine(id);

        }

    }

 
}
