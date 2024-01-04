using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandOnInterfaces
{
    interface icomp
    {
        void display();
        void m1();
    }
    interface icomp2
    {
        void m2();
        void display();
    }
    class shop : icomp, icomp2
    {
       void icomp.display()
        {
            Console.WriteLine("this is comp1");
            
        }

        public void m1()
        {
          
        }

        public void m2()
        {
           
        }

         void icomp2.display()
        {
            Console.WriteLine("this is comp2");

        }
    }

    internal class multilevel
    {
        public static void Main(string[] args) 
        {
            icomp obj = new shop();
            obj.display();
            icomp2 obj2 = new shop();
            obj2.display();
            obj2.m2();
            obj.m1();
        
        }
    }
}
