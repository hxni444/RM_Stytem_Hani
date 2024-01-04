namespace HandOnInterfaces
{
    internal class Program
    {
        interface  ishape
        {
            public void area() { }
           
        }
        class circle : ishape 
        {
            public double r;
            public circle(double r) { {  this.r = r; } }
            public void area()
            {
                Console.WriteLine($"CIRCLE AREA:{Math.PI*Math.Sqrt(r)}");
            }
            public  void Getshape()
            {
                Console.WriteLine("circle");
            }
        }
        class rectangle : ishape 
        {
            public int l;
            public int b;
            public rectangle(int l,int b)
            {
                this.l = l;
                this.b = b; 

            }
            public void area()
            {
                Console.WriteLine($" RECTANGLE AREA:{l * b}");
            }
        }
        static void Main(string[] args)
        {
           rectangle obj = new rectangle(12,12);
            obj.area();
            circle obj2 = new circle(12);
            obj2.area();

            ishape obj3 = new circle(24);
            obj3.area();
            
        
        }
    }
}
