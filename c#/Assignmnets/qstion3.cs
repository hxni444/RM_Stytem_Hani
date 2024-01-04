using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnets
{
    internal class qstion3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 2 numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = a+1; i < b; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
