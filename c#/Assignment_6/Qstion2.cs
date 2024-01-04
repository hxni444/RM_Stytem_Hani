using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    internal class Qstion2
    {
        public static void Main()
        {
            ArrayList stu = new ArrayList()
            {
                "Hari",
                "Mohan",
                "Rishad",
                "Rahun","vishnu","Siddarth","Mahesh","Nihal","Lekshmi","Lokesh"

            };
           stu.Sort();
           stu.Reverse(); 
            foreach (string i in stu) 
            {
                Console.WriteLine(i);
            }
            



        }
    }

    
}
