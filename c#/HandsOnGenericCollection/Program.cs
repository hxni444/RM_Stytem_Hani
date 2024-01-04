namespace HandsOnGenericCollection
{
    class Generic<t, c>
    {
        public t a;
        public t b;
        public int x;
        public c cah;

        public void func(t a)
        {
            Console.WriteLine(this.a);
            Console.WriteLine(cah);
        }
        public void func2(int x)
        {
            Console.WriteLine(this.x + 2);
        }
        public c charerc
        {
            get { return cah; }
            set
            {
                cah = value;
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Generic<int, char> obj = new Generic<int, char>();
                obj.a = 1;
                obj.b = 2;
                obj.func(12);
                obj.charerc = 'h';
                Console.WriteLine(obj.charerc);
                obj.func2(5);
            }
        }
    }
}
