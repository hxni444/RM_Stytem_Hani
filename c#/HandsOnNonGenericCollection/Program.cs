using System.Collections;

namespace HandsOnNonGenericCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ArrayList elem = new ArrayList();
            /* elem.Add(1);
             elem.Add("loki");
             elem.Add("hola amigo");
           *//* int  x = elem.Count;
             Console.WriteLine(x);*//*
             elem.Add('x');
            *//* elem.RemoveAt(3);*//*
             elem.Remove("loki");

             char str = (char)elem[2];
             foreach(var k in elem)
             {
                 Console.WriteLine(k);
             }
             Console.WriteLine();
             Console.WriteLine(str);*/



            Hashtable ht = new Hashtable();
            
            ht.Add(1,"jan" );
            ht.Add(2, "feb");
            ht.Add(3, "march");
            ht.Add(4, "april");
            ht.Add(5, "may");
            ht.Add(6, "june");
            ht.Add(7, "july");
            
            foreach(int k in ht.Keys)
            {
                // Console.WriteLine(ht[k]);
                Console.WriteLine($"{k} {ht[k]}");
            }



        }
    }
}
