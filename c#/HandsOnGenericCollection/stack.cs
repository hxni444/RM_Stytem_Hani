using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollection
{
    internal class stack
    {
        public static void Main()
        {
            Stack<int> ints = new Stack<int>();
            ints.Push(45);
            ints.Push(15);
            ints.Push(52);
            ints.Push(1);
            ints.Push(451);
            ints.Push(47);

            foreach (int i in ints)
            {

              Console.WriteLine(i);
            }
            ints.Pop();
            ints.Pop();
            ints.Pop();
            Console.WriteLine();
            
            ints.Push(69);
            foreach (int i in ints)
            {

                Console.WriteLine(i);
            }

            Console.WriteLine();    
            Console.WriteLine(ints.Peek());
        }
        
      
    }
}
