using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnets
{
    internal class qstion6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Temp in Farehiet");
            int f = Convert.ToInt32(Console.ReadLine());
            int c = (f-32)*5/9;
            Console.WriteLine("Temp in celsius is " + c);

        }
    }
}
