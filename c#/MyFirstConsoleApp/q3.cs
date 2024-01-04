using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class q3
    {
        static void main()
        {
            Console.Write("Enter 2 numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            for(int i = a;i < b; i++) 
            {
                Console.Write(i);
            }
        }
    }
}
