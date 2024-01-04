using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsONClass
{
    internal class methods
    {
        public int a;
        public void seta()
        {
            a = 33;
        }
        public void displa()
        {
            Console.WriteLine(a);
        }
    }
        class test()
        {
            static void Main()
            {
                methods obj = new methods();
                obj.seta();
                obj.displa();



            }


        }
        
            
            
        
    
}
