using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsONClass
{
    internal class overloading
    {
        static void add(int a, int b) {

            int c = 0;
            c = a + b;
            Console.WriteLine(c);
        }
        static void add(int a, int b, int d)
        {

            int c = 0;
            c = a + b + d;
            Console.WriteLine(c);
        }
        static void add(double a, double b)
        {

            double c = 0;
            c = a + b;
            Console.WriteLine(c);
        }

        static void Main()
        {
            add(1, 2);
            add(1, 2,3);
            add(1.2, 2.2);
        }
    }
}
