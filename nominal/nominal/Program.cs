using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_4_04
{
    class Money
    {
        public int first;
        public int second;

        
        public int One
        {
            set
            { first = value; }

            get
            { return first; }
        }

        public int Tue
        {
            set
            { second = value; }
            get
            { return second; }
        }
        public Money(int first, int second)
        {
            this.first = first;
            this.second = second;
        }
        public void Output()
        {

            Console.WriteLine("Номинал купюры = {0}, количество купюр = {1}", first, second);
        }

       
        public string Enough(int sum)
        {
            if (first * second > sum)
                return "Хватит";
            return "Не хватит";
        }

     
        public int Product(int price)
        {
            return ((first * second) / price);

        }
        class Program
        {
            static void Main(string[] args)
            {
                int first, second;

                Console.Write("Введите номинал купюры: ");
                first = int.Parse(Console.ReadLine());
                Console.Write("Введите количество купюр: ");
                second = int.Parse(Console.ReadLine());
                Money n = new Money(first, second);

                Console.WriteLine("\nВывести номинал и количество купюр: ");
                n.Output();

                Console.WriteLine("\nВведите сумму на которую небоходимо купить товар: ");
                int sum = int.Parse(Console.ReadLine());
                Console.WriteLine(n.Enough(sum));

                Console.WriteLine("\nВведите цену товара, который необходимо купить:");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("Вы можете купить {0} шт.\n", n.Product(price));
                Console.ReadKey();


            }
        }
    }
}