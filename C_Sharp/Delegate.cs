using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class Delegate
    {
        public delegate void BankDelegate(string bankname, string interest);
        class Bank
        {
            public static void BankDetails(string bankname, string interest)
            {
                Console.WriteLine($"{bankname} and its interest is {interest}");
            }
            
            public static void Main()
            {
                Bank b1 = new Bank();

                //BankDelegate b1 = new BankDelegate(Bank.BankDetails("sbi", 2.7));
                BankDelegate b11 = new BankDelegate(BankDetails);
               
                b11.Invoke("SBI", "2.70%");
                b11("HDFC Bank", "3.00 % – 3.50 %");
                b11("Kotak Mahindra Bank", "3.50 %");
                b11("Axis Bank", "3.00 % – 3.50 %");
                b11("ICICI Bank", "3.00 % – 3.50 %");

            }
        }

        
    
        
    
    }
}
