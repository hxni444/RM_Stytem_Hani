using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnets
{
    internal class qstion13
    {
        static void Main()
        {
            Console.WriteLine("Enter the numbers");
            int[] arr = new int[5];
            int temp = 0;
            for(int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            foreach(int s in arr)
            {
                if(temp < s)
                {
                    temp = arr[s];     
                }
            }
        } 
    }
}
