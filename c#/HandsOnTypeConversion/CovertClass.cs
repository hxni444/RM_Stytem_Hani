using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTypeConversion
{
    internal class CovertClass
    {
        static void Main(string[] args)
        {
            int i = 25698;
            string s= Convert.ToString(i);
            Console.WriteLine(s);

            string s2 = "5.236";
            decimal dec = Convert.ToDecimal(s2);
            Console.WriteLine(dec);
        }
    }
}
