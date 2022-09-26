using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class Employee
    {
        public static void Main()
        {
            int level;
            Console.WriteLine("Enter the job level");
            level = Convert.ToInt32(Console.ReadLine());

            if(level == 1)
            {
                Console.WriteLine("High level posted");
            }
            else if (level == 2)
            {
                Console.WriteLine("Medium posted");
            }
            else
            {
                Console.WriteLine("Low level posted");
            }



        }
    }
}
