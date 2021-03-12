using System;

namespace OperatorsHTP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Test operators");
            int oper = 5 > 6 ? 7 : 6;
            string result = 1 > 0 ? "plus" : "minus";
            Console.WriteLine(oper);
            Console.WriteLine(result);
            Random random = new Random();

            int[] array = new int[50];
            for (int i = 0; i < array.Length; i++)
            {
                array[i]= random.Next(0, 50);
            }
            Console.WriteLine("ВЫВОЖУ МАССИВ");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            int[] res = Array.FindAll(array, x => x > 9 &&  x % 5 == 0);
            Console.WriteLine("ВЫВОЖУ СОРТ МАССИВ");
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }



            Console.WriteLine("введи число");
            int resultat = int.Parse(Console.ReadLine());
            for (int i = 0; i < resultat+1; i++)
            {
                Console.WriteLine(i);
            }

            bool test = true;
            int say = -20;
            while (test)
            {
                Console.WriteLine(say);
                say -= 20;
                if (say <-100)
                {
                    test = false;
                }
            }

            Console.WriteLine("вводи wasd");
            //определение пемещения
            string number = Console.ReadLine();
            switch (number.ToUpper())
            {
                case "W": Console.WriteLine("Вверх");
                    break;
                case "S":
                    Console.WriteLine("Вниз");
                    break;
                case "A":
                    Console.WriteLine("Влево");
                    break;
                case "D":
                    Console.WriteLine("Вправо");
                    break;
                default: Console.WriteLine("херь");
                    break;
            }



        }
    }
}
