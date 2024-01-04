using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassTypes
{
    partial class par
    {
        public void dem()
        {

        }
    }
    partial class par
    {
        public void dem1()
        {

        }
    }
    partial class par
    {
        public void dem2()
        {

        }
    }
    partial class par
    {
       new public void dem3()
        {
            Console.WriteLine("lolcal");
        }
    }
    internal class partl
    {
        public static void main(string[] args)
        {
            par obj = new par();
            obj.dem2();
        }
        
    }
}
