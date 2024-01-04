using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "The quick brown fox jumps over the lazy dog";

            //qstion a
            Console.WriteLine(str[12]);
            Console.WriteLine("--------------------");
            //qstion b
            if (str.Contains("is"))
            {
                Console.WriteLine("yes there is is");
            }
            else
            {
                Console.WriteLine("there is no yes");
            }
            
            //c)Add the string “and killed it” to the existing string.
            string killed = "and killed it";
            Console.WriteLine("--------------------");
            Console.WriteLine(str + killed);
            //d)Check whether the String ends with the word “dogs”.
            Console.WriteLine("--------------------");
            int lindex = str.LastIndexOf("d");
            if (str.Substring(lindex) == "dogs") 
            {
                Console.Write("contains");
            }
            else
            {
                Console.WriteLine("not contains dogs");
            }

            //e)Check whether the String is equal to “The quick brown Fox jumps over the lazy Dog”.
            Console.WriteLine("--------------------");
            if (str.Equals("The quick brown Fox jumps over the lazy Dog"))
            {
                Console.WriteLine("equals");
            }
            else
            {
                Console.WriteLine("not Equals"); 
            }

            //g)Find the length of the String.
            Console.WriteLine("--------------------");
            Console.WriteLine ("length of the string is "+str.Length);
            //h)Check whether the String matches to “The quick brown Fox jumps over the lazy Dog”.
            Console.WriteLine("--------------------");
            if (str =="The quick brown Fox jumps over the lazy Dog")
            {
                Console.WriteLine("matches");
            }
            else
            {
                Console.WriteLine("Not matches");
            }

            //i)Replace the word “The” with the word “A”.
            Console.WriteLine("--------------------");
            Console.WriteLine(str.Replace("The", "A"));
            //j)Split the above string into two such that two animal names do not come together.
            Console.WriteLine("--------------------");
         
            String[] strlist = str.Split(" ");

            for (int i = 0; i < strlist.Length; i++)
            {
                if (strlist[i] == "fox")
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write(" " + strlist[j]);

                    }
                    Console.WriteLine();
                    for (int k = i + 1; k < strlist.Length; k++)
                    {
                        Console.Write(" " + strlist[k]);
                    }
                }


                //foreach (string name in strlist)
                //{
                //    Console.Write(" " + strlist[name]);
                //}
                    
              


            }
            Console.WriteLine();




            //k)Print the animal names alone separately from the above string.
            Console.WriteLine("--------------------");
            String[] strlist2 = { "fox", "dog" };
            string[] wordlist = str.Split(" ");
            foreach (String k in wordlist)
            {
                  foreach(String s in strlist2)
                {
                    if(k==s) {
                        {
                            Console.WriteLine(s);
                        } }
                }
            }
            //l)Print the above string in completely lower case.
            Console.WriteLine("--------------------");
            Console.WriteLine(str.ToLower());
            //m)Print the above string in completely upper case.
            Console.WriteLine("--------------------");
            Console.WriteLine(str.ToUpper());
            //n)Find the index position of the character “a”.
            Console.WriteLine("--------------------");
            Console.WriteLine(str.IndexOf("a"));
            //o)Find the last index position of the character “e”.
            Console.WriteLine("--------------------");
            Console.WriteLine(str.LastIndexOf("e"));
            //p)Prompt the user to enter the home directory of Tomcat server.To the path that user enters, add another path to WebApps/ MyApps / Images  directory and display it in the console. Use verbatim string literals. 
            Console.WriteLine("--------------------");
            Console.WriteLine("Write a string:");
            string input = Console.ReadLine();
            Console.WriteLine( input +  @"WebApps/ MyApps / Images");
            //q)Write a C# code that has a constant string that represents poem lines 
            Console.WriteLine("--------------------");
            const string poem = "I WANDER'D lonely as a cloud\r\nThat floats on high o'er vales and hills, ";
            Console.WriteLine( poem );

        }
        }
}
