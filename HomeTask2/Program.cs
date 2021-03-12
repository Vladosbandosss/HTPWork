using System;

namespace HomeTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Расчет кредита аннуитетным способом
            Console.WriteLine("Введите сумму кредита");
            double sumkredit = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите процент по кредиту");
            double persent = double.Parse(Console.ReadLine());
            double paypersent = (sumkredit * persent) / 100;
            double allpay = sumkredit + paypersent;
            //Console.WriteLine(allpay);
           
            double monthpay = allpay / 12;
            string resultat = String.Format("{0:f2}", monthpay);
            //Console.WriteLine(result2);
            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine("в " + i + " месяц платеж составит " + resultat);

            }
            Console.WriteLine("Общая сумма платежа - " + allpay);

           
            }


        }
    }

