using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace Assignment_4
{



    public class Furniture
    {

        protected int OrderId;
        protected string OrderDate;
        protected string FurnitureType;
        protected int Qty;
        protected int TotalAmt;
        protected string PaymentMode;

        public virtual void GetData()
        {
            Console.WriteLine("Enter order id:");
            OrderId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter order date:");
            OrderDate = Console.ReadLine();
            Console.WriteLine("Enter Furniture type(chair/cot):");
            FurnitureType = Console.ReadLine();
            Console.WriteLine("Enter order qty:");
            Qty = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Payment mode(credit/debit card):");
            PaymentMode = Console.ReadLine();
        }
        public virtual void ShowData()
        {
            
            Console.WriteLine($"ORDER ID:{OrderId}\nORDER DATE:{OrderDate}\n" +
                $"FURNITURE TYPE:{FurnitureType}\nORDER QTY:{Qty}\nPAYMENT MODE:{PaymentMode} ");
        }

    }
    public class Chair() :Furniture
    {
        protected string ChairType;
        protected string purpose;
        protected string RealType;
        protected string SteelChairType;
        protected string Color;
        protected int rate;


        public override void GetData()
        {
            base.GetData();
            Console.WriteLine("Enter chair type ( Wood/Steel/Plastic ):");
            ChairType = Console.ReadLine();
            Console.WriteLine("Enter Purpose:");
            purpose = Console.ReadLine();
            

            if(ChairType.Equals("wood", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Enter Wood type (Teak Wood/Rose Wood)");
                RealType = Console.ReadLine();
           }
            else if(ChairType.Equals("steel",StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Enter style type ( Gray Steel/Green Steel/Brown Steel)");
                RealType = Console.ReadLine();

            }
            else if (ChairType.Equals("plastic", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Enter colour( Green/Red/Blue/White)");
                Color = Console.ReadLine();

            }
            Console.WriteLine("Enter rate");
            rate= int.Parse(Console.ReadLine());    

        }
        public override void ShowData()
        {
            TotalAmt = Qty * rate;
            base.ShowData();
            if(ChairType.Equals( "steel", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"WOOD TYPE:{RealType}");
            }
            else if (ChairType.Equals("wood", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"WOOD TYPE:{RealType}");
            }
            else if( ChairType.Equals("plastic", StringComparison.OrdinalIgnoreCase) )
            {
                Console.WriteLine($"WOOD TYPE:{Color}");
            }
            Console.WriteLine($"RATE:{rate}\nTOTAL AMOUNT:{TotalAmt}");
            
        }

    }

    public class Cot():Furniture
    {
        protected string CotType;
        protected string RealType;
        
        protected int rate;

        public override void GetData()
        {
            base.GetData();
            Console.WriteLine("Enter chair type ( Wood/Steel/Plastic )");
            CotType = Console.ReadLine();
            


            if (CotType.Equals("wood", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Enter cot type (Teak Wood/Rose Wood)");
                RealType = Console.ReadLine();
            }
            else if (CotType.Equals("steel", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Enter style type ( Gray Steel/Green Steel/Brown Steel)");
                RealType = Console.ReadLine();

            }
            
            Console.WriteLine("Enter rate");
            rate = int.Parse(Console.ReadLine());
        }
        public override void ShowData()
        {
            TotalAmt = Qty * rate;
            base.ShowData();
            if (CotType.Equals("steel", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"WOOD TYPE:{RealType}");
            }
            else if (CotType.Equals("wood", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"WOOD TYPE:{RealType}");
            }
            
            Console.WriteLine($"RATE:{rate}\nTOTAL AMOUNT:{TotalAmt}");

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cot obj1 = new Cot(); 
            obj1.GetData();
            obj1.ShowData();
            Chair obj2 = new Chair();
            obj2.GetData();
            obj2.ShowData();
        }
    }
}
