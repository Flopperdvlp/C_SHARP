using System;
namespace Project
{
    class Student
    {
        public string Name {get; set; }
        public string Surname{get; set;}
        public int Age{get; set;}
        public Student(string name, string surname, int age){ Name = name; Surname = surname; Age = age; }
        public void Print()
        {
            if(Age > 18) Console.WriteLine("Больше 18 - " + Name + " " + Surname + " " + Age); 
            else if(Age < 18) Console.WriteLine("Меньше 18 - " + Name + " " + Surname + " " + Age); 
        }
    }
    class Program 
    {         
        static void Main(string[] args)
        {
            Student[] st = new Student[2];
            st[0] = new Student("Vlad", "Orlov", 19);
            st[1] = new Student("Ivan", "Ivanov", 17);
            //foreach(Student s in st) { s.Print(); }
            for (int i = 0; i < st.Length; i++){ st[i].Print(); }
        }
    }
}  