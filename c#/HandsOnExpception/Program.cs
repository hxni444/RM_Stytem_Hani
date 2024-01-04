namespace HandsOnExpception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b;
                Console.WriteLine("Enter 2 number");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                if (b == 0)
                {
                    throw new DivideByZeroException("b value should not be zero");
                }
                else
                {
                    int c = a / b;
                    Console.WriteLine(c);


                }
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
        }
    }
}
