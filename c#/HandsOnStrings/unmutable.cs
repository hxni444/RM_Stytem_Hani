using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStrings
{
    internal class unmutable
    {
        static void Main(string[] args)
        {
            string str = "All gliters are not gold";
            Console.WriteLine("char at 5th index" + str[3] + "oky");
           // console.writeline("length: " + str.length);
           // console.writeline("uppercase: " + str.toupper());
          //  str.toupper();
           // console.writeline(str); //strings are not dynamic in nature
           // console.writeline(str.trim());
         //   console.writeline(str.replace("g", "g")); //replace chat
           // console.writeline(str.replace("gold", "diamond")); //replace sub-string
            Console.WriteLine(str.IndexOf('g'));
            Console.WriteLine(str.LastIndexOf('g'));
            Console.WriteLine(str.Remove(11));
            Console.WriteLine(str.Remove(4, 7));
            string[] str1 = str.Split(' '); //based of white space chat str is splied into string array
            foreach (string s in str1)
                Console.WriteLine(s);
            string[] ss = { "I", "Love", "Cricket" };
            string result = string.Join("-", ss);
            Console.WriteLine(result);
            string s1 = "David";
            string s2 = "David";
            if (s1.Equals(s2)) //Equals method return true when strings are equal
            {
                Console.WriteLine("strings are equal");
            }
            else
                Console.WriteLine("strings are not equal");


        }
    }

}

