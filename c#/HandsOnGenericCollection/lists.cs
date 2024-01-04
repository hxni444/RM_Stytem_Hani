using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollection
{
    
    internal class lists
    {
        public static void Main()
        {
            List<int> val = new List<int>();
            val.Add(122);
            val.Add(13);
            val.Add(1);
            val.Add(5);
            val.Add(6);
            val.Add(144);

            int x = val[3];
            val.Sort();
            //val.Reverse();
            //Console.WriteLine(x);
            foreach(var k in val)
            {
               
                Console.WriteLine(k);
            }
        }
        
    }
}
