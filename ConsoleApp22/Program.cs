using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            Square sq = new Square();
            Rectangular rec = new Rectangular();
            int choose = 0;
            do
            {
                Console.WriteLine("reqem daxil edein");
                choose = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("----------");
                switch (choose)
                {
                    case 1:
                        {
                            sq.CalcArea();
                        }
                        break;
                    case 2:
                        {
                            rec.CalcArea();
                        }
                        break;
                    default:
                        break;
                }
            } while (choose!=0);
        }
    }
    abstract class Figure
    {
        
        public abstract void CalcArea();
    }
    class Square : Figure
    {
        int sahe = 0;

        public int side
        {
           
            get
            {
                
                return sahe;
            }
            set
            {
                side = 4;
                sahe = side*side;
               
            }
            
        }
        public override void CalcArea()
        {
            Console.WriteLine(sahe);
        }
    }
    class Rectangular:Figure
    {
        public int area = 0;
        public int width
        {
            get
            {
               
                return area; ;
            }
            set
            {
                area = width * length;
                Console.WriteLine(3);
            }
        }
        public int length
        {
            get
            {
               
                return length;
            }
            set
            {
                area = width * length;
                Console.WriteLine(5);
            }
        }
        
       
        public override void CalcArea()
        {
            Console.WriteLine(area);
        }
    }
}
