using System;

namespace Hometask1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            //Реализуем неявное преобразование 
            byte probr = 5;
            short probrtoshort = probr;
            int probrtoint = probrtoshort;
            long probttolong = probrtoint;
            //реализуем явное преобразование
            long longprobr = 100;
            int intpreopbraz = (int)longprobr;
            short shortpreobr = (short)intpreopbraz;
            byte bytepreobraz = (byte)shortpreobr;
            //готово
            //суффиксы
            double dob = 2.5d;
            float flo = 3f;
            uint unt = 5u;
            long lon = 7l;
            decimal dec = 5m;
            //2 дз  игра -загадываете число от 1 до 1000 а программа пытается отгадать

            int minNumber = 1;
            int maxNumber = 1000;
            int result = 500;
            bool playgame = true;
            Console.WriteLine("привет,загадай число от 1 до 1000,а я буду его отгадывать," +
                "если твое число меньше чем я покажу жми 1 вниз,если больше - 2," +
                "если я угадал - жми 3");
            while (playgame)
            {
                
                Console.WriteLine("Ты загадал" + result + "верно? ");
                int answer = int.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        maxNumber = result;

                        break;
                    case 2:
                        minNumber = result;
                        break;
                     case 3:
                        Console.WriteLine("я выйграл");
                        playgame = false;
                        break;

                    default:
                        break;
                }
                result = (maxNumber + minNumber)/2;




            }
            



        }
    }
}
