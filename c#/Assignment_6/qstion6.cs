namespace Assignment_6
{
    internal class qstion6
    {
        public static void Main()
        {
            Dictionary<string, string> employee = new Dictionary<string, string>();
           

            /*employee.Add("Sarnkar", "Junior Programmer");
              employee.Add("Soman", "Program Managers");
              employee.Add("Sashi", "Senior Programmer");
              employee.Add("Lokesh", "Project Manager");
              employee.Add("Vijay", "Team Lead");*/

            string Ename, desg;
           
           
            while (true)
            {
                Console.WriteLine("Enter name :    / trype Exit to Finsih");
                Ename = Console.ReadLine();
                if (Ename.ToLower() == "exit") break;

                Console.WriteLine("Enter Desigation (Program Managers, Project Manager, Team Lead, Senior Programmer, Junior Programmer) :");
                desg = Console.ReadLine();
                desg.ToLower();
                
                employee.Add(desg, Ename);

            }

            string[] designationsOrder = { "Program Managers", "Project Manager", "Team Lead", "Senior Programmer", "Junior Programmer" };

            Console.WriteLine("\nEmployees sorted by designation:");
            foreach (var k in designationsOrder)
            {

                var D = k.ToLower();
                if (employee.ContainsKey(D))
                {
                  
                    Console.WriteLine(employee[D]+"-"+D.ToUpper());
                  
                }
            }
        }
    }
}

  

    

