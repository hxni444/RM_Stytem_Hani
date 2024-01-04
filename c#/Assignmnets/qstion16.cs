using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class qstion16
    {
        static void Main()
        {
            Console.WriteLine("Enter a word");
            string str = Console.ReadLine();
            for(int i = str.Length-1;i>=0;i--)
            {
                Console.Write(str[i]);
            }
        }
    }
}
