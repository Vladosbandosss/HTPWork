using System;
using System.Linq;

namespace DopHomtask
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Пример использования XOR (исключающее ИЛИ)
            //2.Использование операторов CHECKED-UNCHECKED
            //3.Проверка, является ли введенная строка палиндромом

            //Task1
            bool isColdWater = true;
            bool isHotWater = true;
            if (isColdWater == true ^ isHotWater == false)
            {
                Console.WriteLine("Какая-та вода есть");
            }if(isColdWater==true ^ isHotWater == true)
            {
                Console.WriteLine("либо все хорошо,либо все очень плохо");
            }

            //Task2 

            try
            {
                
                int a = 600;
                byte b = checked((byte)a);
                Console.WriteLine(b);

            }
            catch(Exception ex)
            {
                Console.WriteLine("переполнил");
            }

            //Task 3
            string word = Console.ReadLine();
            Console.WriteLine(word);
            char[] test = word.Reverse().ToArray();
            Console.WriteLine(test);
            string word2 = new string(test);
            if (word == word2)
            {
                Console.WriteLine("строка является палиндромом ");
            }

        }
    }
}
