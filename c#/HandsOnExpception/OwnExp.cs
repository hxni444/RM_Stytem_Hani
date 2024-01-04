using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExpception
{
    class myexp : Exception
    {
        int age;
        string message;
        public AgeExption(int age)
        {
            message = $"{age} is not applicable to write the xxam";
        }
        public override string Message 
        {
            get { return message; }
        }
    }
    internal class OwnExp
    {
        public void Applyxam(int ag)
        {
            try
            {
                if(ag>=12 && ag <= 16)
                {
                    Console.WriteLine("Applied for xam success!!");
                }
                else
                {
                    throw new AgeExption(age);
                }
            }
            catch(AgeExption e) 
           
            {
                Console.WriteLine(e.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }

    class test_student 
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter age");
                int age = int.Parse(Console.ReadLine());
                Applyxam()

            }
        }
    }

}
