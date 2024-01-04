using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    internal class strings
    {
        public static void Main()
        {
            string name = "hani al ziya";
             string[] fruit = { "banana", "tomato", "kiwi", "apple" };
        string[] flowers = { "rose", "jasmine", "sun flower", "dahliya", "hibiscus" };

        var rslt = from f in fruit
                   where f.Length> 5
                   select f;

          /*  foreach ( var f in rslt )
            {
                Console.WriteLine( f );
            }
*/
            var rslt2 = from f in flowers
                        orderby f
                        select f;

            var ch= from k in name
                    orderby k
                    select k;

            foreach( var f in ch)
            {
                Console.WriteLine( f );
            }
        }
       
    }
}
