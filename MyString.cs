using System;
using System.Collections.Generic;
using System.Text;

namespace StringTest
{
    class MyString
    {
        public string str;
        public string Name { get; set; }
        public int Size { get; set; }
        public MyString(string str)
        {
            this.str = str;
        }
        public MyString(string name,int size)
        {
            Name = name;
            Size = size;
        }
        public void IfContains(string name,string res)//вводим строку и узнаем есть ли в ней буква
        {
            int count = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == res[0])
                {
                    count++;
                }
            }
            if (count > 0)
            {
                Console.WriteLine("есть");
            }
            else
            {
                Console.WriteLine("нету");
            }
            

        }
       public void HowMachGlass(string name)//высчит сколько глассных
        {
            string allglaas = "уеэоаыяию";
            int count = 0;
            for (int i = 0; i < name.Length; i++)
            {
                for (int j = 0; j < allglaas.Length; j++)
                {
                    if (name[i] == allglaas[j])
                    {
                        count++;
                    }
                }

            }
            Console.WriteLine("глассных в слове " + name + " " + count);
        }
    }
}
