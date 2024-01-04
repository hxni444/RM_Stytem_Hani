using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnets
{
    internal class qstion9
    {
        static void Main()
        {
            int[] arr = new int[11];
            arr[0] = 0;
            arr[1] = 1;
            int t1 = 0, t2 = 1;
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            for (int i = 2; i < arr.Length-1; i++)
            {
                arr[i] = t1 + t2;
                t1 = t2;
                t2 = arr[i];
                Console.WriteLine(arr[i]);  
            }

        }
    }
}
