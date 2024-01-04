using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollection
{
    class Employee
    {
        public int id;
        public string name;
         
        public Employee(int id, string name) {
        this.id = id;
            this.name = name;   
        }

    }
    internal class dict
    {
        public static void Main()
        {
            Dictionary<int, string> obj = new Dictionary<int, string>();
            obj.Add(12,"hani");
            obj.Add(11, "loki");
            obj.Add(23, "thor");
            obj.Add(78, "odin");
            obj.Add(32, "hela");
            obj.Add(69, "friga");

            foreach(var k in obj.Keys)
            {
                Console.WriteLine(k + " "+ obj[k]);
            }
            Employee e1 = new Employee(45,"hani");
            Employee e2 = new Employee(15, "ob");
            Employee e3 = new Employee(41, "silvie");


            SortedDictionary<int, Employee> obj2 = new SortedDictionary<int, Employee>(); 

            obj2.Add(e1.id,e1);
            obj2.Add(e2.id,e2);
            obj2.Add(e3.id,e3);

            foreach(var k in obj2)
            {
                Console.WriteLine(k+ " "+ e1);
            }


            

       }
        

    }
}
