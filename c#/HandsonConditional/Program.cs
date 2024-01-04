namespace HandsonConditional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            byte age = byte.Parse(Console.ReadLine());
            if ( age > 18)
            {
                Console.WriteLine(name + " u can write the xam");
            }
            else
            {
                Console.WriteLine("sorry You cant");
            }
            Console.WriteLine("Thankyou");
        }
    }
}
