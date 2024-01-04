using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    internal class _2dArry
    {
        static void Main(string[] args)
        {
            int[,] arry = new int[2,2];
            arry[0,0] = 1;
            arry[0,1] = 2;
            arry[1,0] = 4;
            arry[1,1] = 5;
            
            for (int i = 0;i<2;i++) 
            { 
                for (int j = 0; j < 2; j++)
                {
                    //  arry[i = Convert.ToInt32(Console.ReadLine()), j = Convert.ToInt32(Console.ReadLine())];
                    Console.Write(arry[i,j]);
                }
                Console.WriteLine();
            }











        }
    }
}
