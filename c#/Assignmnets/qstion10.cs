using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnets
{
    internal class qstion10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number for Multi table");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 20; i++)
            {
                
                Console.WriteLine($"{i}*{num}={i*num}");
            }
        }
    }
}
