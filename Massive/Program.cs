using System;

namespace Massive
{
    class Program
    {
        static void Main(string[] args)
        {
            //создать масс на 6 элем,ввести с консоли вывести осортир по убыванию
            int[] mas = new int[6];
            for (int i = 0; i < 6; i++)
            {
                mas[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(mas);
            Array.Reverse(mas);
            foreach (var item in mas)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Test");
            //2 мер массив 3на 3 вывести макс элем каждого ряда
            int max = 0; 
            int[,] massive = new int[3,3];
            Random random = new Random();
            for(int i = 0; i <3; i++)
            {
                for(int j = 0; j <3; j++)
                {
                    massive[i,j] = random.Next(0, 20);
                }
                    }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    
                    if (massive[i, j] > max)
                    {
                        max = massive[i, j];
                    }

                    Console.Write(massive[i, j] + "  ");
                   
                }
                Console.WriteLine("Максиамальное в " + (i+1)  + " " + max);
                Console.WriteLine();
                max = 0;
            }
        }
    }
}
