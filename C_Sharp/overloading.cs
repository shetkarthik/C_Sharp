using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class overloading
    {

        public void add(int a,int b)
        {
            int sum = a + b;
            Console.WriteLine(sum);
        } 
        public void add(float a,float b)
        {
            float sum = a + b;
            Console.WriteLine(sum);
        }

        public void add(string first,string second)
        {
            string sum = first + second;
            Console.WriteLine(sum);
        }


        public static void Main()
        {
            overloading o = new overloading();

            o.add(2, 5);
            o.add(1.2F, 1.3F);
            o.add("Hello", "World");

        }
    }
}
