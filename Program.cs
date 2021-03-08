using System;

namespace StringTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString myString = new MyString("Hi");
            MyString myString1 = new MyString("Stroka", 5);
            myString.HowMachGlass("аба");
            myString.IfContains("волк", "a");
            myString.IfContains("волк", "о");
        }
    }
}
