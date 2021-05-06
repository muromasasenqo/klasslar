using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите  данные для A");
            bool result1 = Int32.TryParse(Console.ReadLine(), out a);
            if (result1 == false)
            {
                Console.WriteLine("Ведите корректные данные");
            }
            int b;
            Console.WriteLine("Введите  данные для B");
            bool result2 = Int32.TryParse(Console.ReadLine(), out b);
            if (result2 == false)
            {
                Console.WriteLine("Ведите корректные данные");
            }


            int x;
            Console.WriteLine("Введите  данные для X");
            bool result3 = Int32.TryParse(Console.ReadLine(), out x);
            if (result3 == false)
            {
                Console.WriteLine("Ведите корректные данные");
            }
            int y;
            Console.WriteLine("Введите  данные для Y");
            bool result4 = Int32.TryParse(Console.ReadLine(), out y);


            Point n = new Point(x, y, a, b);
            n.Coord();
            n.Distance();
            Console.WriteLine($"Расстояние ={n.Distance()}");
            Console.WriteLine("Кордината точки на векторах A и B = {0}", n.OnVector());
            Console.ReadKey();
        }


    
        class Point
        {
            public int x;
            public int y;
            public int a;
            public int b;



           
            public int A
            { 

                get
                {
                    return a;
                }
                set
                {
                    a = value;
                }
            }
            public int B
            {

                get
                {
                    return b;
                }
                private set
                {
                    b = value;
                }
            }
            public int X
            {
                get
                {
                    return x;
                }
                private set
                {
                    x = value;
                }
            }
            public int Y
            {

                get
                {
                    return y;
                }
                private set
                {
                    y = value;
                }
            }



            public Point()
            { 

            }

            public Point(int x, int y, int a, int b)
            { 
                this.x = x;
                this.y = y;
                this.a = a;
                this.b = b;
            }

            public void Value()
            { 

                Console.WriteLine($"Расстояние ={Distance()}");

            }

            public void Coord()
            { 

                Console.WriteLine("x = {0}, y = {1}", x, y);
            }

            public double Distance()
            { 
                return Math.Sqrt(x * x + y * y);
            }

           
            public void Vector()

            {
                this.x += a;
                this.y += b;
            }
            public double OnVector()
            {
                return ((x + a) + (y + b));
            }

          
            
            public int ScalX
            {
                set
                {
                    x *= value;
                }

            }

            public int ScalY
            {
                set
                {
                    y *= value;
                }

            }
        }
    }
}