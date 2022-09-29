using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_Sharp
{
    internal class inherit
    {
        public class Bonus
        {
            protected int eid;
            protected string ename;
            protected int bonus;
         

            public void getDetails()
            {
                eid = 102;
                ename = "David";
                bonus = 12000;

                Console.WriteLine($"{eid}:{ename}:{bonus}");
            }

        }

        public class Staff:Bonus
        {
            int staffbonus;

            public void StaffBonus(int amount)
            {
                staffbonus = amount * 3;
                Console.WriteLine(staffbonus);
            }
        }
        public class NonStaff:Bonus
        {
            int nonstaffbonus;

            public void NonStaffBonus(int amount)
            {
                nonstaffbonus = amount * 2;
                Console.WriteLine(nonstaffbonus);
            }
        }

        public static void Main()
        {
            Bonus newbonus = new Bonus();
            newbonus.getDetails();
            Staff st = new Staff();
            st.StaffBonus(1200);
            NonStaff nst = new NonStaff();
            nst.NonStaffBonus(1000);
        }
    }
}


