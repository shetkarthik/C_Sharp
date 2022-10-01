using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public class AgeValidationError:ApplicationException
    {
        public AgeValidationError(string message) : base(message)
        {

        }
    }
    internal class CustomExcep
    {
       public static void Main()
        {
            int age;

            try
            {
                Console.WriteLine("Enter the age of the user");
                age = Convert.ToInt32(Console.ReadLine());
                if(age < 22)
                {
                    throw (new AgeValidationError("Age is below 22"));
                }
                else
                {
                    Console.WriteLine("Age validated");
                }
            }
            catch(AgeValidationError e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
