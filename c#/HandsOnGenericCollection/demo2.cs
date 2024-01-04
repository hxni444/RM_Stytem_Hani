using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollection
{
    class student
    {
        public int id;
        public string name;

        public student(int id,string name) {
            this.id = id;
            this.name = name;
        }
    }
    internal class demo2
    {
        public static void Main()
        {
            List<student> obj = new List<student>()
            {
            new student(415, "hani"),  //we can addd to list like this
            new student(22, "hani"),
            new student(45, "hani"),
            new student(4, "hani"),
            new student(4225, "hani")
            };

            obj.Add(new student(12, "loki")); // or  we can add to list like this also

            Console.WriteLine(obj.Count);
            /*foreach(var k in obj)
            {
                Console.WriteLine(k.id);
            }*/



        }
    }
}
