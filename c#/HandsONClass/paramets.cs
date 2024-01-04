using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsONClass
{
    internal class paramets
    {
        public int Add(int a, int b)
        {
            return a + b;

        }
        public string greet(string name)
        {
            return "hello" + name;
        }

        //public int sumarr(params int[] arr)
             public int sumarr( int[] arr)
        {
            int result = 0;
            foreach (int i in arr)
            {
                result += i;

            }
            return result;
        }

        public string[] bikes()
        {
            string[] bikes = { "kokok", "lokol" };
            return bikes;
        }
        static void Main()
        {
            paramets obj = new paramets();
            int x = obj.Add(45, 5);
            Console.WriteLine(x);

            int r= obj.sumarr(new int[] { 1,11,1,1 });

           // int r = obj.sumarr(11, 1, 11, 1);

            Console.WriteLine(r);
            string[] str = obj.bikes();
            foreach (string s in str)
            {
                Console.WriteLine(s);

            }

        }
    }
}
