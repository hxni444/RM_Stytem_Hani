using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsONClass
{
    internal class staticMethods
    {
        public static int[] marks;
         public static int totals;

        public static int Total()
        {
            int totl = 0;
            foreach (int k in marks)
            {
                totl += k;
                totals = totl;
               
            }
            return totl;
        }
        public static string Rank()
        {
            string rnk="/0";
             if (totals> 60)
            {
                rnk = "a++";
            }
            return rnk;
        }

        static void Main()
        {
            staticMethods.marks = new int[] { 45, 44, 21, 21, 11 };
            Console.WriteLine(staticMethods.Total());
        }
    }
}
