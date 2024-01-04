namespace HandsOnClassTypes
{
    internal class Program
    {
        static class Converter
        {
            public static int a;
            public static double RupToDol(double rupee)
            {
                return rupee/78.5;
            }
            public static double DolToRup(double dollar)
            {
                return dollar * 78.5;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
             Console.WriteLine(Converter.DolToRup(12));
            Console.WriteLine(Converter.DolToRup(12));
        }
    }
}
