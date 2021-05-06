
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaniye_5_04
{
    
    class ArrayInt
    {
        private int[] IntArray; 
        private int n; 


  
        public ArrayInt(int n)
        {
            this.n = n;
            this.IntArray = new int[n];
        }
      
        public void ReadArray()
        {
            Console.WriteLine($"Введите элементы массива");
            for (int i = 0; i < IntArray.Length; i++)
            {
                Console.Write("IntArray[{0}] = ", i);
                IntArray[i] = Convert.ToInt32(Console.ReadLine());
            }
        }   
        public void Show()

        {
            for (int i = 0; i < IntArray.Length; i++)
            {
                int value = (int)IntArray.GetValue(i);
                Console.WriteLine(value);
            }

            Console.WriteLine("\nОтсортировать элементы массива в порядке возрастания:");


        }

        public void Sort()
        {
            int temp;
            for (int j = 0; j <= IntArray.Length - 2; j++)
            {
                for (int i = 0; i <= IntArray.Length - 2; i++)
                {
                    if (IntArray[i] > IntArray[i + 1])
                    {
                        temp = IntArray[i + 1];
                        IntArray[i + 1] = IntArray[i];
                        IntArray[i] = temp;
                    }
                }
            }
        }



        class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("Введите размер массива: ");
                int n = Convert.ToInt32(Console.ReadLine());

                ArrayInt obj = new ArrayInt(n);
                Console.WriteLine("\nВведите элементы массива с клавиатуры:\n");


                obj.ReadArray();
                obj.Show();
                obj.Sort();
                obj.Show();

                Console.ReadKey();
            }
        }
    }
}