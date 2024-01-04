namespace HandsOnConstructorsAnd_Properties
{

    class student
    {
        public static int Id;
        public string Name;
        public static string school;
        static string city;

        //copy constructor
        public student(student demo)
        {
           
        }

        //parameterized contructor (2 parameter)
        public student( string Name)
        {
            
            this.Name = Name;
        }


        //static constrctor
        static student()
        {
            city = "kochi";
            Id= new Random().Next();
        }

        //parameterized contructor (1 parameter)
        public student()
        {
            school = "crscent hss vanimel";
              
        }
        public void display()
        {
            Console.WriteLine($"id:{Id}\nname:{Name}\nschool:{school}\ncity: {city}");
            Console.WriteLine();

        }

        
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
          // student.city = "kochis";
            student.school = "perode";
            
            student onj = new student();// object 1
            onj.Name = "santhosh";
           
            student obj2 = new student("kumae"); //object 2
            
            

            student obj4 = new student( "rohith") { }; //object 3
          

            student[] starry = new student[5];
            starry[0] = onj;// shallow copy
            starry[1] = obj4;
            obj2.Name = "thor";
            starry[2] = new student(obj4);
            starry[2].Name = "frigga";
            
            starry[3] = new student(onj);
            starry[3].Name = "loki";
            starry[4] = new student(onj);
            starry[4].Name = "mohan";

            foreach (student s in starry)
            {
                s.display();
            }



        }
    }
}
