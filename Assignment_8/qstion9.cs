using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    internal class qstion9
    {
        public static void Main()
        {
            int[] arry = { 1, 2, 3, 4, 5, 6, 7, 8, };
            var data = from i in arry
                       where i % 2 != 0
                       select i;

            foreach (var i in data)
            {
                Console.WriteLine(i);
            }
           
            Console.WriteLine("NUmber of odd is " +data.Count());
        }
    }
}
