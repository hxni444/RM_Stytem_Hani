﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonConditional
{
    internal class IfElseIf
    {
        static void Main()
        {
            byte m1 = 78, m2 = 89, m3 = 66, m4 = 56, m5 = 90, m6 = 77;
            int total = (m1 + m2 + m3 + m4 + m5 + m6);
            double avg = total / 6;
            string? grade = null;
            if (avg >= 70)
            {
                grade = "First Class";
            }
            else if (avg > 60 && avg <= 69)
            {
                grade = "Second Class";
            }
            else if (avg > 50 && avg <= 59)
            {
                grade = "Third Class";
            }
            else
            {
                grade = "Fail";
            }
            if (grade == "Fail")
            {
                Console.WriteLine("Sorry You are Fail!!");
            }
            else
            {
                Console.WriteLine($"Result:{grade} Total Marks:{total} Percentage:{avg:F2}%");
            }

        }
    }
}
