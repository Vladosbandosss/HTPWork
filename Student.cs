using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTaskTest
{
    class Student
    {
        int group;
        public Student(string name, string surname, List<int> add,int group)
        {
            _name = name;
            _surname = surname;
            marks = add;
            this.group = group;
        }
        public void ShowStudGroup()
        {
            Console.WriteLine(group);
        }
        public void ChangeGroup(int res)
        {
            group = res;
        }

        private string _name;

        public string NAME
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _surname;

        public string SURNAME
        {
            get { return _surname; }
            set { _surname = value; }
        }


       
        List<int> marks;
        public Student(string name,string surname,List<int>add)
        {
            _name = name;
            _surname = surname;
            marks = add;
        }
        //выводит оценки
        public void ShowMarks()
        {
            foreach (var item in marks)
            {
                Console.Write(item + " ");
            }
            
        }
        //Средний балл
        public void ShowAverege()
        {
            int res = 0;
            int count = marks.Count;
            for (int i = 0; i < marks.Count; i++)
            {
                
                res += marks[i];
            }
            int finres = res / count;
            Console.WriteLine("Средний балл " + finres);
        }

    }
}
