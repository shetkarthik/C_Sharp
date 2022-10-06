using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class Hash_Dict
    {
        class Hash
        {
            static public void Main()
            {

                
                Hashtable new_hash = new Hashtable();

              
                new_hash.Add("1", "John");
                new_hash.Add("2", "David");
                new_hash.Add("3", "Dexter");

                foreach (DictionaryEntry ele in new_hash)
                {
                    Console.WriteLine("{0} =>  {1}",
                                      ele.Key, ele.Value);
                }
            }
        }
    }
}
