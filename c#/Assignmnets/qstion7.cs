using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnets
{
    internal class Number0_625
    {
        static void Main(string[] args)
        {
            int counter = 1;
            Console.WriteLine(0);
            for (int i = 1; i <= 625; i=i+counter)
            {
                Console.WriteLine(i);
                counter = counter + 2;
            }
        }
    }
}
