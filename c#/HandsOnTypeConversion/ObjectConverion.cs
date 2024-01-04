using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTypeConversion
{
    internal class ObjectConverion
    {
        static void Main(string[] args)
        {
            int x = 4455;
            object obj1 = x;

            object obj2 = 3.141617;
            double pi = (double)obj2;

            Console.WriteLine(obj1);
            Console.WriteLine(pi);
        }
    }
}
