namespace HandsOnLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = {0, 45, 125, 458, 8, 54, 12, 68, 65, 65, };
            var rslt= from x in n
                      where x>30
                      select x;


            rslt = from x in n
                   select x * x;


            rslt = from x in n
                   where x%2==0
                   select x;

            rslt= from x in n
                  where x>100&& x>45
                  select x;

            rslt = from x in n
                   orderby x
                   select x;


            foreach( var x in rslt )
            {
                Console.WriteLine(x);
            }
        }
    }
}
