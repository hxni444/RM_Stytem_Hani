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
            int[] arra = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, };

            var EvnNum = arra.Where(n => n % 2 != 0).Select(n => n);
            var EvnNumc = arra.Where(n => n % 2 != 0).Select(n => n);

            Console.WriteLine(EvnNumc);
            foreach ( var i in EvnNum )
            {
                
                Console.WriteLine(i);
            }

        }
    }
}
