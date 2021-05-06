using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangle
{


    class Rectangle
    {

        public int a, b;
       
        public bool Square
        {

            get { if (a == b) return true; else return false; }


        }
    
        public int A
        {
            get { return a; }
            set { a = value ; }
        }

        public int B
        {
            get { return b; }
            set { b = value; }
        }

        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void Output()
        {

            Console.WriteLine($"first side is{a}");
            Console.WriteLine($"second side is{b}");


        }
        public int Perimetr()
        {
            return 2 * (a + b);
        }

        public int Area()
        {
            return a * b;
        }
        
    }
    class Program
    {
        static int Check()
        {

            int w = 0;
            try
            {
                 w = int.Parse(Console.ReadLine());


            }
            catch (Exception)
            {
                Console.WriteLine("Dont enter symbol");
               w = int.Parse(Console.ReadLine());
            }


            while (w <= 0)
            {

                Console.WriteLine("enter bigger than zero");

                w = int.Parse(Console.ReadLine());
               
            }
            
            return w;


        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter first side");
            int a = Check();
            Console.WriteLine("enter second side");
            int  b = Check();
            Rectangle rectangle = new Rectangle(a, b);





            rectangle.Output();
            Console.WriteLine($"PErimetr is {rectangle.Perimetr()}");
            Console.WriteLine($"Area is {rectangle.Area()}");
            Console.WriteLine($"Rectangle is {rectangle.Square} ");
            Console.ReadKey();
        }
        
    }
}
