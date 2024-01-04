using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnets
{
    internal class qstion8
    {
        static void Main(string[] args)
        {
            Console.Write("Emter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i; 
            }
            Console.WriteLine(fact);    
        }
    }
}
