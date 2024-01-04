namespace HandsOnTypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //conversion in between value types
            int inti = 1254;
            float flt=(float)inti;
            double doble = 556.23;
            inti = (int)doble;
            long lng = 45465484654842;
            inti = (int)lng;
            
            //TASK - 1
            decimal dc = 34.145845454545m;
            inti = (int)dc;
            byte byt = (byte)dc;
            short shrt = (short)dc;
            lng = (long)dc;
            doble=(double)dc;

            Console.WriteLine(dc);
            Console.WriteLine(inti);
            Console.WriteLine(byt);
            Console.WriteLine(shrt);
            Console.WriteLine(lng);
            Console.WriteLine(doble);

            //task - 2
            string s1 = "3.1416";
            float pi = float.Parse(s1);
            Console.WriteLine(pi);

            double p = 3.1416;
            string s2= p.ToString();
            Console.WriteLine(s2);

            


        }
    }
}
