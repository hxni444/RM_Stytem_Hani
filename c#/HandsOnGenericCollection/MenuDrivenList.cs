using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollection
{
    public class Teacher()
    {
        public int t_id;
        public string t_name;
        public string t_school;
        public string t_email;
        public string t_number;

    }

    interface Iteacher
    {
        public void AddTeacher(Teacher addTeacher);
        public List<Teacher> GetTeacherById(int srchid);
       /* public Teacher GetTeacherByName();
        public Teacher GetTeacherBySchool();*/

    }

    class TeacherMain : Iteacher 
    {
        List<Teacher> teachersObj = new List<Teacher>();
        public void AddTeacher(Teacher addTeacher)
        {
            foreach (var teacher in teachersObj) 
            {
                if (addTeacher != null)
                {
                    
                    teachersObj.Add(teacher);
                }

            }
        }
        public List<Teacher> GetTeacherById(int srchid)
        {
            List<Teacher> tchrid = new List<Teacher>();
            foreach(var k in teachersObj)
            {
                if(k != null)
                {
                    if(srchid == k.t_id)
                    {
                        tchrid.Add(k);
                    }
                }


            }
            return tchrid;
        }
    }
    
    internal class MenuDrivenList
    {
        public static void Main()
        {
            Teacher teacher = new Teacher();

            do
            {
                Console.WriteLine("Choose option");
                Console.WriteLine("1.Add Teacher");
                Console.WriteLine("2.Serach techer by id");
                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        {
                            
                            Console.WriteLine("Enter name:");
                            teacher.t_name = Console.ReadLine();
                            Console.WriteLine("Enter School name:");
                            teacher.t_school = Console.ReadLine();
                            Console.WriteLine("Enter number:");
                            teacher.t_number = Console.ReadLine();
                            teacher.t_email = teacher.t_name + "@gmail.com";
                            teacher.t_id = new Random.Next(100,500);
                            TeacherMain teacherMain = new TeacherMain();
                            teacherMain.AddTeacher(teacher);


                        }
                        break;
                        case 2:
                        {
                            TeacherMain teacherMain = new TeacherMain();
                            Console.WriteLine("Enter Id");
                            int id = int.Parse(Console.ReadLine());
                            List<Teacher> list = new List<Teacher>();
                            list = teacherMain.GetTeacherById(id);
                            if (list != null)
                            {
                                Console.WriteLine($"TEACHER NAME:{teacher.t_name}\nTEACHER ID:{teacher.t_id}\nMAIL ID:{teacher.t_email}" +
                                    $"\nTEACHER NUMBER:{teacher.t_number}\nTEACHER SCHOOL:{teacher.t_school}");
                            }
                            


                        }
                        break;
                }

                

            } while (true);
            





        }
    }
}
