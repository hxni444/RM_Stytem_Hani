using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    internal class _2darrysrch
    {
        static void Main()
        {
            string name = "hani";
            string pass = "12345";
            string[,] arr = new string[5, 2]
       {
            { "hani", "12345"},
            { "loki", "12345"},
            { "thor", "12345"},
            { "odin", "12345"},
            { "hela", "12345"},

       };
            for (int i = 0; i < 5; i++)
            {
                if (arr[i, 0] == name && arr[i, 1] == pass)
                {
                    Console.WriteLine("granted");
                    break;
                }
                else
                {
                    Console.WriteLine("not granted");
                    break;
                }
            }




        }
    }
}
