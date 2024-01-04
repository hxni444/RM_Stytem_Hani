namespace HandsONClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            student obj1 = new student();
            obj1.age = 17;
            obj1.name = "Hani";
            obj1.Display();
            student obj2 = new student();
            obj2.age = 17;
            obj2.name = "loki";
            obj2.gender = 'N';
            obj2.Display();
            Console.WriteLine();
            student obj3 = new student()
            {
                id = 228,
                name = "thor",
                gender='m',
                age=125421,
            };
            obj3.Display();
            



            Console.WriteLine("---------------------------");
            //Array of Objects
            student[] stuArry = new student[3];
            //stuArry[0] = new student()
            //{
            //    id=4545,
            //    name="loki",
            //    age=17,
            //    gender='M'
            //};
            //stuArry[1] = new student()
            //{
            //    id = 4545,
            //    name = "loki",
            //    age = 17,
            //    gender = 'M'
            //};
            //stuArry[2] = new student()
            //{
            //    id = 4545,
            //    name = "loki",
            //    age = 17,
            //    gender = 'M'
            //};


            //for(int i = 0; i < stuArry.Length; i++)
            //{
            //    Console.Write("Enter id & name");
            //    stuArry[i] = new student()
            //    {
                   
            //         id = int.Parse(Console.ReadLine()),
            //         name = Console.ReadLine()
            //    };
            //}
            //foreach (student st in stuArry)
            //{
            //    st.Display();
            //}

            
                methods obj = new methods();
                obj.seta();
                obj.displa();

               

            

        }
    }
}
