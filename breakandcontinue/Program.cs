using System;

namespace breakandcontinue
{
    class Program
    {
        static void Main(string[] args)
        {
            //продемонстрировать циклы for while break continue 

            //демонстрация break for
            for (int i = 0; i < 100; i++)
            {
                string msg = Console.ReadLine();
                if (msg == "exit")
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("test1");
            //демонстрация цикла continue for
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    continue;
                }
                Console.WriteLine(i);//2 пропустила
            }
            Console.WriteLine("test2");
            //демонстрация цикла while c break
            while (10 > 1)
            {
                string msg = Console.ReadLine();
                if (msg == "exit")
                {
                    break;
                }
                Console.WriteLine(1);
            }
            Console.WriteLine("test3");

            //демонстрация цикла while с continue
            int number = 0;
            while (number < 5)
            {
                
                number++;
                if (number == 2)
                {
                    continue;
                }
                Console.WriteLine(number);

            }
            Console.WriteLine("test4");
            //ввести с клавиатуры число больше 0 ,вывести все числа от 0 до n которые простые

            Console.WriteLine("введите число больше 0");
            int chislo = int.Parse(Console.ReadLine());
            for (var i = 0u; i < chislo; i++)
            {
                if (IsPrimeNumber(i))
                {
                    Console.Write($"{i} ");
                }
            }




        }
        public static bool IsPrimeNumber(uint n)
        {
            var result = true;

            if (n > 1)
            {
                for (var i = 2u; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
