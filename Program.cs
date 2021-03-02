using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            //изменить а на А
            string test = "абвгдаваа";
             string result="";
            for (int i = 0; i < test.Length; i++)
            {
                if (test[i].Equals('а'))
                {
                    string a;
                    a = test[i].ToString().ToUpper();
                    result += a;
                    a = "";

                }
                else
                {
                    string a;
                    a = test[i].ToString();
                    result += a;
                    a = "";

                }

            }
            Console.WriteLine(result);
            //посчитать глассных в строке
            string allglaas = "уеэоаыяию";
            Console.WriteLine("введите строку");
            string stroka = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < stroka.Length; i++)
            {
                for (int j = 0; j < allglaas.Length; j++)
                {
                    if (stroka[i] == allglaas[j])
                    {
                        count++;
                    }
                }

            }
            Console.WriteLine("глассных в слове " + stroka + " " + count);

            //определить значение и номер из 8 массивов последнего отрицательного элемента
            Random random = new Random();
            int[] mas = new int[8];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = random.Next(-10, -1);
            }
            foreach (var item in mas)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
           int[] testarr = new int[8];
            Array.Copy(mas, testarr,8);
           Array.Sort(testarr);
            int chislo = testarr[0];
            int finresind = Array.FindIndex(mas, x => x == chislo);
            Console.WriteLine("индекс " + finresind + " число " + chislo);
            Console.WriteLine();
            //в двухмерном массиве все элем после макс заменить на 0 (не получилось но трохи работает после максимума меняет на 0,но н етак как надо)
            int[,] bigarr = new int[5, 10];
           
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    bigarr[i, j] = random.Next(0, 30);
                }

            }
            Console.WriteLine();
            int max = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (bigarr[i, j] > max)
                    {
                        max = bigarr[i, j];
                    }
                    Console.Write(bigarr[i, j] + " ");  
                }
                Console.WriteLine( "  макс значение " + max );
                for (int d = 0; d < 10; d++)
                {
                    Console.Write(bigarr[i, d] + " ");

                    if (bigarr[i, d] == max)
                    {
                       for(int k = 0; k < d; k++)
                        {
                            Console.Write(0 + " ");
                        }
                        break;
                    }
                    
                }
                Console.WriteLine("");


                Console.WriteLine();
                max = 0;

            }
            /*for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(bigarr[i,j] + " ");

                }
                Console.WriteLine();
            }
            */







                }
    }
}
