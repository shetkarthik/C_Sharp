using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_Sharp
{
    internal class outkey
    {
        public static void Main()
        {
            int sid;
            string sname;
            string sdep;
            Details(out sid, out sname,out sdep);
            Console.WriteLine($"Student Id is {sid}");
            Console.WriteLine($"Student Name is{sname}");
            Console.WriteLine($"Student Department is {sdep}");
        }

        public static void Details(out int id,out string name,out string dep )
        {
            Console.WriteLine("Enter Student ID");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student name");
            name = Console.ReadLine();
            Console.WriteLine("Department");
            dep = Console.ReadLine();

        }
    }
}
