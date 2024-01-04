using System.Text;

namespace HandsOnStrings
{
    internal class mutable
    {
        static void Main(string[] args)
        {
           StringBuilder obj = new StringBuilder();
            obj.AppendLine("Hello EveryOne ");
            Console.WriteLine(obj);
            obj.Replace("hello", "hi");
            Console.WriteLine(obj);
          
        }
    }
}
