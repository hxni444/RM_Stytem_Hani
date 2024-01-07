using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    internal class qstion1
    {
        public static void Main()
        {
            int[] num = { 122, 11, 5, 11, 2, 55, 7,8,9,10, 93, };
            var reslt = num.Where(x => x*x*x >100 && x*x*x<1000);

            foreach (var k in reslt)
            {
                Console.WriteLine(k);
            }
        }
    }
}
