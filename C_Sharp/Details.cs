using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_Sharp
{
    internal class Details
    {
        public static void Main()
        {
            Console.WriteLine("Enter Employee ID");
            int empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee name");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Designation");
            string des = Console.ReadLine();

            Details d = new Details();
            d.displayDetails(empid, userName, age, des);
        }

        public void displayDetails(int empid,string name,int age,string des)
        {
            Console.WriteLine("Employee Details");
            Console.WriteLine($"Employee Id is {empid}");   
            Console.WriteLine($"Employee Name is{name}");   
            Console.WriteLine($"Employee age is {age}");   
            Console.WriteLine($"Employee Designation is {des}");   

        }

       
    }
}
