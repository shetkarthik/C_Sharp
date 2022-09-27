using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class ParamArray
    {
        public static void Main()
        {
            //int product = multiply(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            int product1 = multiply(5);
            Console.WriteLine(product1);
          

        }
        
        public static int multiply(params int[] numbers)
        {
            int pro = 0;
            //int mul = 5;
            int[] numarray = {1,2,3,4,5,6,7,8,9,10};
            //foreach (int i in numbers)
            //{
            //    pro = i * mul;
            //    Console.WriteLine($"{mul} * {i} = {pro}");
            //}
            foreach(int i in numarray)
            {
                pro = numbers[0] * i;
                Console.WriteLine($"{numbers[0]} * {i} = {pro}");
            }
            return pro;

        }



    }
}

