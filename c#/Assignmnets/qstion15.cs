using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class qstion15
    {
        static void Main()
        {
            int count = 0;
            Console.Write("Enter a word:");
            string str = Console.ReadLine();

            foreach(char k in str)
            {
                count++;
            }
            Console.Write(count);

        }
    }
}
