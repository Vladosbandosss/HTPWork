using System;
using System.Collections.Generic;

namespace HomeTaskTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student("Влад", "Булахов", new List<int> {5,7,9,1,7,5 });
            Student student1 = new Student("Влад1", "Булахов1", new List<int> { 1, 1, 1, 1, 1, 1 });
            //student.ShowMarks();
            //student.ShowAverege();
            Group group = new Group(1, new List<Student> { student, student1 });
            // group.ShowAverage();
            //group.ShowStudentMarks();
            //group.ShowGroup();
            // group.ChangeGroup(2);
            // group.ShowGroup();
            Console.WriteLine("Тест");
            group.ShowGroup();
            group.ChangeGroup(5);
            group.ShowGroup();
            Student student3 = new Student("Влад", "Булахов", new List<int> { 5, 7, 9, 1, 7, 5 },2);
            student3.ShowStudGroup();
            student3.ChangeGroup(3);
            student3.ShowStudGroup();
        }
    }
}
