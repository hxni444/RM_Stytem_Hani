using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            Console.Write("Enter a word:");
            string str = Console.ReadLine();
            for (int i = 0, j = 1; i < str.Length / 2; i++, j++)
            {
                if (str[i] == str[str.Length - j])
                {
                    flag = 1;
                }

            }
            if (flag == 1)
            {
                Console.WriteLine("plindrome");
            }
            else
            {
                Console.WriteLine("not");
            }
        }
    }
}
