using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConstructorsAnd_Properties
{
    internal class teacher
    {
        private int id;
        private string name;
        private int age;
        private int exp;
       


        public int ID
        {

            get
            {
                return id;

            }
            set
            {
                if (value > 0)
                {
                    id = value;
                }
                else
                {
                    Console.WriteLine("ENter valid id");
                }


            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != null)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("name cannot be null");
                }

            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(value > 18)
                {
                    age = value;    
                }
            }
        }
        public int Exp
        {
            get
            {
                return exp;
            }
            set
            {

                if (value > 2)
                {
                    exp = value;
                }


                else
                {
                    Console.WriteLine("Minimun 2 years of exp is needed");
                }

                   



            }
        }
    }


    class Teach_test
    {
        static void Main()
        {
            teacher obj = new teacher();
            obj.ID = -123;
            obj.Name = null;
            obj.Exp= 0;

            teacher obj2 = new teacher();
            obj2.ID = 123;
            obj2.Name = "frigga";
            obj2.Age = 18;
            obj2.Exp = 2;

            Console.WriteLine($"id:{obj.ID}\nname:{obj.Name}\n exp:{obj.Exp}");
            Console.WriteLine();
            Console.WriteLine($"id:{obj2.ID}\nname:{obj2.Name}\n exp:{obj2.Exp}");
        }
    }
}
