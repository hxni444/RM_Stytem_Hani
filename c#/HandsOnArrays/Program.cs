namespace HandsOnArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {


                Console.WriteLine("Enter name, World!");
                string name = Console.ReadLine();
                bool flag = false;
                string[] str =
                {
                    "hani",
                    "loki",
                    "thor",

                 };
                foreach (string f in str)
                {
                    if (f == name)
                    {
                        flag = true;
                        break;
                    }


                }
                if (flag)
                {
                    Console.WriteLine("yo r  hero");
                }
                else
                {
                    Console.WriteLine("you are not a hero");
                }
            }
            while(true);
        }
    }
}
