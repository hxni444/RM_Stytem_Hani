using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnets
{
    internal class qstion12
    {
        static void Main() 
        {
            Console.WriteLine("Enter  Number 1 ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter  Number 2 ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter  Number 3 ");
            int c = int.Parse(Console.ReadLine());
            if(a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("number 1 is big");
                }
                else
                {
                    Console.WriteLine("number 3 is big");
                }
            }
            else
            {
                if(b > c)
                {
                    Console.WriteLine("number 2 is big");
                }
                else
                {
                    Console.WriteLine("number 3 is big");
                }
            }

        }
    }
}
