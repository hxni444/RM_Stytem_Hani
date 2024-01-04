namespace HandsOnInheritance
{
    class parent
    {
        protected int a, b;
        public parent(int a, int b)
        {
            this.a = a;
            this.b = b;

        }
    }
    class child : parent
    {
        public child() : base(2, 3)
        {

        }
        public child(int k, int u) : base(k, u)
        {

        }

        public void disp()
        {
            Console.WriteLine($"A={a} B={b}");
        }


    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            child obj = new child();
            obj.disp();
            child obj2 = new child(12,21);
            obj2.disp();


        }
    }
}
