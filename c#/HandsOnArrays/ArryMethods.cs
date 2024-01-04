using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    internal class ArryMethods
    {

        static void Main()
        {
            int[] arry = { 1, 2, 3, 4, 5, 6, 7, };
           int  x= arry.Length;
            Array.Sort(arry);

            int pos = Array.BinarySearch(arry, 7);
            if (pos>=0)
            {
                Console.WriteLine("found at index " + pos);
                
            }
            else 
            { 
                Console.WriteLine("not found"); 
            }

        }
    }
}
