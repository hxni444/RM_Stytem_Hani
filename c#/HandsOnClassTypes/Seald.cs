using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassTypes
{
     class a
    {
        public void m()
        {
            Console.WriteLine("lolooo");
        }
    }
    sealed class b:a
    {
       new public void m2()
        {

        }
    }
    internal class Seald
    {
        public static void Main()
        {
            a obj12 = new a();
            obj12.m();

            b obj2 = new b();

        }
        
        
        
    }
}
