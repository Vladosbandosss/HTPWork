using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTaskTest
{
    class Group
    {
        public int number;
        List<Student> students;
        private int neednumber;

        public Group(int number,List<Student>students)
        {
            this.number = number;
            this.students = students;

        }

        public Group(int neednumber)
        {
            this.neednumber = neednumber;
        }

        public void ChangeGroup(int neednumber)
        {
            number = neednumber;


        }
        public void ShowGroup()
        {
            foreach (var item in students)
            {
                Console.WriteLine(number);
            }
        }
        public void ShowStudentMarks()
        {
            foreach (var item in students)
            {
                item.ShowMarks();
                Console.WriteLine();
            }
            
            
          
        }
        public void ShowAverage()
        {
            foreach (var item in students)
            {
                item.ShowAverege();
            }
        }
        
    }
}
