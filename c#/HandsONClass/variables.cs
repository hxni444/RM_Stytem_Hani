using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsONClass
{
    internal class variables
    {
        public string  offcrName;
        public int offcrId;
        public static string branch;
        public static string city;
        public const string country = "uk";

        public string Display()
        {
            return $"officer name:{offcrName} officer id: {offcrId} branch:{branch} city:{city} country:{country}";
        }
        static void Main()
        {
            variables.branch = "ndm";
            variables.city = "kozhikode";
           // variables.country = "usa"; (cant do this 3)
            variables obj = new variables()
            {
                offcrName = "lopke",
                offcrId = 45445

            };


            Console.WriteLine(obj.Display());

        }
    }
    
}
