using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class Validate
    {
        public static void mobile()
        {
            Console.WriteLine("mobile validation");
            string mobile = "9989898999";
            string res = mobile.Substring(0, 1);
            if (res == "8" || res == "9")
            {
            var validate_mobile = Regex.IsMatch(mobile, @"([0-9]{10})$");
             Console.WriteLine(validate_mobile);
            }
            else
            {
                Console.WriteLine(false);
            }
          
        }
        public static void Main()
        {
            
            mobile();

        }
    }
}
