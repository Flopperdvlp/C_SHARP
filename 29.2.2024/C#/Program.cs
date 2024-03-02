using System;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;
/*
Створіть об'єкти делегатів StudentActionDelegate та використовуйте їх для виведення інформації про кожного студента та збільшення їхнього середнього балу.
*/
namespace Project
{
    public class StudentList
    {
        public List<Student> List { get; set; }
        public StudentList()
        {
            List = new List<Student>();
        }
        public void add(Student student)
        {
            List.Add(student);
        }
        //TODO:public void delete(){}
        public void show(Student student)
        {
            Console.WriteLine("Student name: " + student.Name + "\nStudent surname: " + student.Surname + "\nStudent average grade: " + student.AverageGrade);
        }
        public void increasegrade(Student student, double amount)
        {
            student.AverageGrade += amount;
        }
        public void ProcessStudents(StudentActionDelegate actionDelegate)
        {
            foreach (var t in List)
            {
                actionDelegate(t);
            }
        }
    }
    public delegate void StudentActionDelegate(Student student);
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public double AverageGrade { get; set; }
        public Student(string name, string surname, double avarege_grade) { Name = name; Surname = surname; AverageGrade = avarege_grade; }
    }
    public class Program
    {
        public static void Main()
        {
            StudentList studentlist = new StudentList();
            Student student1 = new Student("Maxsim", "Orlov", 1.1);
            Student student2 = new Student("Gleb", "Snigurov", 2.6);
            Student student3 = new Student("Anastasiya", "Pavlovna", 8.8);
            studentlist.add(student1);
            studentlist.add(student2);
            studentlist.add(student3);
            StudentActionDelegate increasegrade = student => studentlist.increasegrade(student, 1.1);
            StudentActionDelegate show = student => studentlist.show(student);
            studentlist.ProcessStudents(increasegrade);
            studentlist.ProcessStudents(show);
        }
    }
}
