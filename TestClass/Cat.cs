using System;
using System.Collections.Generic;
using System.Text;

namespace TestClass
{
    class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        
        public Cat(string name,int age)
        {
            Name = name;
            Age = age;
        }
        public void Info()
        {
            Console.WriteLine("имя " + Name + " возраст " + Age);
        }


    }
}
