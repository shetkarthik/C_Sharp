using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class Excep
    {
        public static void Main()
        {
            try
            {
                byte data = byte.Parse("b");
                Console.WriteLine(data);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Provide an argument");
            }
            catch (FormatException)
            {
                Console.WriteLine("Entered value is not a number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Data is out of range");
            }
        }
    }
}
