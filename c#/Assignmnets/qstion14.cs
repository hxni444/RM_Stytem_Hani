using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class qstion14
    {
        static void Main()
        {
            Console.WriteLine("Enter 10 marks");
            int[] arr = new int[10];
            int max = 0, min = 0;
            float total=0;
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            for(int i = 0;i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                     min = arr[i];
                }

                total = total + arr[i];

            }
            //int temp = 0;

            //accending code
            /*for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] > arr[i+1])
                {
                    temp = arr[i+1];
                    arr[i + 1] = arr[i];
                    arr[i] = arr[i + 1];
                }
                
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            */

            float avg = total / 10;
            Console.WriteLine("min vale is: " +min);
            Console.WriteLine("max vale is: " + max);
            Console.WriteLine("Total: " + total);
            //Console.WriteLine("Avergare: " + avg);
            Console.WriteLine($"Avrerage = {avg:f3} ");


        }
    }
}
