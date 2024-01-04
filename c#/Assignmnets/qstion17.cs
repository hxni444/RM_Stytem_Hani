using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class qstion17
    {
        static void Main()
        {

            Console.WriteLine("Enter first Word");
            string a = Console.ReadLine();
            Console.WriteLine("Enter second Word");
            string b = Console.ReadLine();
            if (a == b)
            {
                Console.WriteLine("same");
            }
            else
            {
                Console.WriteLine("not same");
            }
        }
    }
}
