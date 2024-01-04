using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnets
{
    internal class qstion5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter limit of the aray");
            int ecount = 0, ocount = 0;

            int lim = int.Parse(Console.ReadLine());
            int[] arr = new int[lim];
            Console.WriteLine("Enter Numbers");   
            for(int i = 0; i < lim; i++) 
            {
                arr[i] = int.Parse(Console.ReadLine());
                
            }
             foreach(int s in arr) 
            {
                if (s % 2 == 0)
                {
                    ecount++;
                }
                else
                {
                    ocount++;
                }

            }
            Console.WriteLine("NUmber of even number is: " + ecount);
            Console.WriteLine("NUmber of odd Number is : "+ ocount);
            
        }
    }
}
