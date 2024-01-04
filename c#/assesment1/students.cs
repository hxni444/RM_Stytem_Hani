namespace Assesment_1
{
    class Student { public int id; public string name; public int age; public byte std; public char section; }
    class StudentRepo
    {
        public Student[] students = new Student[5]; public int idx = 0; public void CreateStud(Student student) { if (idx <= students.Length) { students[idx] = student; idx++; } else { Console.WriteLine("Student is full"); } }

        public Student[] GetStudById(int id)
        {
            Student[] std = new Student[students.Length];
            int idx = 0;
            foreach (Student student in students)
            {
                if (student != null)
                {
                    if (student.id == id)
                    {
                        std[idx] = student;
                        idx++;
                    }
                }
            }
            return std;
        }
        public Student[] GetStudByName(string name)
        {
            Student[] std = new Student[students.Length];
            int idx = 0;
            foreach (Student student in students)
            {
                if (student != null)
                {
                    if (student.name == name)
                    {
                        std[idx] = student;
                        idx++;
                    }
                }
            }
            return std;
        }
        public Student[] GetStudByStd(byte std)
        {
            Student[] std1 = new Student[students.Length];
            int idx = 0;
            foreach (Student student in students)
            {
                if (student != null)
                {
                    if (student.std == std)
                    {
                        std1[idx] = student;
                        idx++;
                    }
                }
            }
            return std1;
        }
        public Student[] GetStudByStdAndSection(int std, char section)
        {
            Student[] std1 = new Student[students.Length];
            int idx = 0;
            foreach (Student student in students)
            {
                if (student != null)
                {
                    if (student.std == std && student.section == section)
                    {
                        std1[idx] = student;
                        idx++;
                    }
                }
            }
            return std1;
        }
        public Student[] GetStudByAge(int age)
        {
            Student[] std = new Student[students.Length];
            int idx = 0;
            foreach (Student student in students)
            {
                if (student != null)
                {
                    if (student.age == age)
                    {
                        std[idx] = student;
                        idx++;
                    }
                }
            }
            return std;
        }
        public Student[] GetAllStud()
        {
            return students;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentRepo StudentRepo = new StudentRepo();
            do
            {
                Console.WriteLine("1.Create Student");
                Console.WriteLine("2.Update Student");
                Console.WriteLine("3.Display student details based on ID");
                Console.WriteLine("4.Display student details based on Name");
                Console.WriteLine("5.Display students based on std");
                Console.WriteLine("6.Display students based on std and section");
                Console.WriteLine("7.Display students based on age.");
                Console.WriteLine("8.Display students details.");
                Console.WriteLine("9.Exit");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            Student student = new Student();
                            Console.WriteLine("Enter STUDENT ID:");
                            student.id = int.Parse(Console.ReadLine()); ;
                            Console.WriteLine("Enter the NAME:");
                            student.name = Console.ReadLine();
                            Console.WriteLine("Enter the AGE:");
                            student.age = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the standard:");
                            student.std = byte.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the SECTION:");
                            student.section = char.Parse(Console.ReadLine());
                            StudentRepo.CreateStud(student);
                        }
                        break;

                    case 3:
                        {
                            Console.WriteLine("Enter the STUDENT ID:");
                            int id = int.Parse(Console.ReadLine());
                            Student[] student = StudentRepo.GetStudById(id);
                            foreach (Student students in student)
                            {
                                if (students != null)
                                {
                                    Console.WriteLine($"STUDENT ID:{students.id} NAME:{students.name} AGE:{students.age} STD:{students.std} SECTION:{students.section}");
                                    Console.WriteLine();
                                }
                            }
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Enter the Student NAME:");
                            string name = Console.ReadLine();
                            Student[] students = StudentRepo.GetStudByName(name);
                            foreach (Student s in students)
                            {
                                if (s != null)
                                {
                                    Console.WriteLine($"STUDENT ID:{s.id} NAME:{s.name} AGE:{s.age} STD:{s.std} SECTION:{s.section}");
                                    Console.WriteLine();
                                }
                            }
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Enter the standard:");
                            byte std = byte.Parse(Console.ReadLine());
                            Student[] students = StudentRepo.GetStudByStd(std);
                            foreach (Student s in students)
                            {
                                if (s != null)
                                {
                                    Console.WriteLine($"STUDENT ID:{s.id} NAME:{s.name} AGE:{s.age} STD:{s.std} SECTION:{s.section}");
                                    Console.WriteLine();
                                }
                            }
                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine("Enter the STD:");
                            int std = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the SECTION:");
                            char section = char.Parse(Console.ReadLine());
                            Student[] students = StudentRepo.GetStudByStdAndSection(std, section);
                            foreach (Student s in students)
                            {
                                if (s != null)
                                {
                                    Console.WriteLine($"STUDENT ID:{s.id} NAME:{s.name} AGE:{s.age} STD:{s.std} SECTION:{s.section}");
                                    Console.WriteLine();
                                }
                            }
                        }
                        break;
                    case 7:
                        {
                            Console.WriteLine("Enter AGE:");
                            int age = int.Parse(Console.ReadLine());
                            Student[] students = StudentRepo.GetStudByAge(age);
                            foreach (Student s in students)
                            {
                                if (s != null)
                                {
                                    Console.WriteLine($"STUDENT ID:{s.id} NAME:{s.name} AGE:{s.age} STD:{s.std} SECTION:{s.section}");
                                    Console.WriteLine();
                                }
                            }
                        }
                        break;
                    case 8:
                        {
                            Student[] students = StudentRepo.GetAllStud();
                            foreach (Student s in students)
                            {
                                if (s != null)
                                {
                                    Console.WriteLine($"STUDENT ID:{s.id} NAME:{s.name} AGE:{s.age} STD:{s.std} SECTION:{s.section}");
                                    Console.WriteLine();
                                }
                            }
                        }
                        break;
                    case 9:
                        {
                            Environment.Exit(0);
                        }
                        break;
                    default:
                        Console.WriteLine("Enter valid option");
                        Console.WriteLine();
                        break;
                }
            } while (true);
        }
    }
}