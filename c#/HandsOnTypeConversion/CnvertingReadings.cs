using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTypeConversion
{
    internal class CnvertingReadings
    {
        static void Main()
        {
            Console.WriteLine("ENter the Emp name");
            string Empname= Console.ReadLine();

            Console.WriteLine("Enter EmpID");
            int EmpID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Gender");
            char Gender = char.Parse(Console.ReadLine());

            Console.Write("Enter slary");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Emplyee Name:{Empname} Emplyolee id: {EmpID} Gender:{Gender} Empyolee Salary:{salary}");
        }
    }
}
