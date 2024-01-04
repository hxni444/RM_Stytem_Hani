using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsONClass
{
    internal class student
    {
        public int id;
        public string name;
        public int age;
        public char gender;
        public void Display()
        {
            Console.WriteLine($"Name:{name} id:{id} Gender:{gender}");
        }
    }
}
