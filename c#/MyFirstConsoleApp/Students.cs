using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Students
    {
        static void Main()
        {
            Console.WriteLine("hi students");
            Console.Write("Enter the student name:");
            string Sname=Console.ReadLine();
            Console.WriteLine("hello "+Sname); 
        }
    }
}
