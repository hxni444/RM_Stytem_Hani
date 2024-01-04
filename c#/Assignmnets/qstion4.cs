using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnets
{
    internal class qstion4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a%2==0) 
            {
                Console.WriteLine("EVEN");
            }
            else 
            {
                Console.WriteLine("odd");
             }
        }
    }
}
