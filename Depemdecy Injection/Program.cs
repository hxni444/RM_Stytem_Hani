namespace Depemdecy_Injection
{
    class Student
    {
        public int id;
        public string name;

        public Student(int id, string name)
        {
           this.id = id;
            this.name = name;   

        }
        
    }
    class Register
    {
        Student student;
        public Register(Student student)
        {
            this.student = student;

        }
        public void Disp()
        {
            Console.WriteLine($"ID:{student.id} Name:{student.name}");
        }

    }
    /*class piller
    {
        Register regi;
        public piller(Register regi)
        {
            this.regi = regi;
        }
        public void Disp()
        {
            Console.WriteLine($"ID:{regi.id} Name:{this.name}");
        }

    }*/
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Register reg = new Register(new Student(45,"Hani"));
            reg.Disp();
         

            



        }

    }
}
