using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        private double a, b, c;
        public bool isValid
        {
            get => a + b > c && b + c > a && a + c > b && a > 0 && b > 0 && c > 0;
        }
        public double A
        {
            get => a;
            set { if (value > 0) a = value; }
        }

        public double B
        {
            get => b;
            set { if (value > 0) b = value; }
        }

        public double C
        {
            get => c;
            set { if (value > 0) c = value; }
        }

        public Triangle(int a, int b, int c )
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double Perimetr()
        {
            return a + b + c;
        }
        public double Area()
        {
            double p = Perimetr() / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }


        public void Output()
        {
            Console.WriteLine($"a = {a}, b = {b}, c = {c}");
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
            int b = Check();
            Console.WriteLine("enter third side");
            int c = Check();
            Triangle rectangle = new Triangle(a, b, c );
            rectangle.Output();
            Console.WriteLine($"PErimetr is {rectangle.Perimetr()}");
            Console.WriteLine($"Area is {rectangle.Area()}");
            Console.WriteLine($"Rectangle is {rectangle.isValid} ");
            Console.ReadKey();


        }
    }
}
