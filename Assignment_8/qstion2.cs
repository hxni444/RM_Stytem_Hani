using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    class Player
    {
        public string Name { get; set; }    
        public string country { get; set; }

        public Player(string Name,string Country)
        {
            this.Name = Name;
            this.country = Country;
        }

    }
    internal class qstion2
    {
        public static void Main()
        {
            List<Player> List1 = new List<Player>()
            {
                new Player("Hari","UK"),
                new Player("Laaher","INDIA"),

            };
            List<Player> List2 = new List<Player>()
            {
                new Player("Rohan","UK"),
                new Player("Mike","US"),

            };
            
            
            

            var ls = from p1 in List1
                     from p2 in List2
                     where p1.country !=p2.country
                     select new {Name1=p1.Name,Name2=p2.Name};

            foreach (var k in ls)
            {
                Console.WriteLine($"{k.Name1} and {k.Name2}");
            }
        }
    }
}
