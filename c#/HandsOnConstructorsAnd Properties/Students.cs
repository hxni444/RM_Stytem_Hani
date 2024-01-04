using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConstructorsAnd_Properties
{
    internal class Students
    {
        private int id;
        private string name;
        private int[] mark = { 50, 32, 44, 12, 78 };
        private int total;
      

        public int ID 
        {

            get
            {
                return id;

            }
            set
            {
                if(value>0)
                {
                    id = value;
                }
                else
                {
                    Console.WriteLine("ENter valid id");
                }
               

            }
        }
        public string  Name { get
            {
                return name;
            } set
            {
                if(value!= null)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("name cannot be null");
                }
                
            } }
        public int Mark 
        {
            get
            {
                return total;
            } 
            set
            {
                total = 0;
                foreach(int s in mark)
                {
                    total= total+s;
                }
            }
        }
        public string Grade
        { 
            get
            {

                if (total > 300)
               
                    return "a++";
                else
                
                    return "fail";
                
                

            }
        }
    }
    

    class Test
    {
        static void Main()
        {
            Students obj = new Students();
            obj.ID = -123;
            obj.Name = null;

            Students obj2 = new Students();
            obj2.ID = 123;
            obj2.Name = "frigga";

            Console.WriteLine($"id:{obj.ID}\nname:{obj.Name}\ngarde:{ obj.Grade}");
            Console.WriteLine();
            Console.WriteLine($"id:{obj2.ID}\nname:{obj2.Name}\ngarde:{obj2.Grade}");
        }
    }
}
