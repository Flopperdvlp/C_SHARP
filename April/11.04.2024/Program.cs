using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using System.IO;
using System.Xml;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using System.Linq;
/*
Створіть програму.
Програма має зберігати у xml файлі інформацію про групи академії itstep. 
Програма має надавати можливість додавати, видаляти та змінювати групи. 
    У групі має бути student list (масив студентів) та викладач. 
    У кожного студента має бути ПІБ, телефон, рік народження та оцінки з програмування, 3д моделюванню, та робототехніці. 
Програма має надавати можливість додавати, видаляти та змінювати інформацію про студентів. 
    Викладач має тільки ПІБ який теж можна змінити. Програма має виводити інформацію в консоль по заданій групі, студенту або викладачу.
*/
namespace Project
{
    public class Student
    {
        public string PIB { get; set; }
        public string PhoneNumber { get; set; }
        public string ProgramingGrade { get; set; }
        public string Modeling { get; set; }
        public string Roboechnik { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
    public class Teacher
    {
        public string PIB { get; set; }
    }
    public class Group
    {
        public string name { get; set; }
        public List<Student> ListOfStudent { get; set; } = new List<Student>();
        public List<Group> groups { get; set; } = new List<Group>();
        public Teacher teacher { get; set; }
    }
    public class Groups
    {
        private string filePath;
        public Groups(string filepath)
        {
            this.filePath = filepath;
        }
        public void Add(Group lists, Student chto)
        {
            lists.ListOfStudent.Add(chto);
        }
        public void Remove(Group lists, int index)
        {
            if (index >= 0 && index < lists.ListOfStudent.Count)
            {
                lists.ListOfStudent.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("По этому индексу нету ничего");
            }
        }
        public void Load(Group lists)
        {
            if (File.Exists(filePath))
            {
                XDocument xDocument = XDocument.Load(filePath);
                foreach (XElement xElement in xDocument.Root.Elements("Students"))
                {
                    Student info_About = new Student
                    {
                        PIB = xElement.Element("PIB").Value,
                        PhoneNumber = xElement.Element("Phonenumber").Value,
                        ProgramingGrade = xElement.Element("Programinggrade")?.Value,
                        Modeling = xElement.Element("Modelinggrade").Value,
                        Roboechnik = xElement.Element("Roboechnikgrade").Value,
                        DateOfBirth = DateTime.Parse(xElement.Element("Dateofbirth").Value)
                    };
                    lists.ListOfStudent.Add(info_About);
                }
                foreach (XElement xElement in xDocument.Root.Elements("Group"))
                {
                    Group group = new Group
                    {
                        name = xElement.Element("Name").Value,
                        teacher = new Teacher { PIB = xElement.Element("Teacher").Value }
                    };
                    lists.groups.Add(group);
                }
            }
        }
        public void Save(Group lists)
        {
            XDocument doc = new XDocument(new XElement("Groups"));
            foreach (Group group in lists.groups)
            {
                XElement xElement = new XElement("Group",
                    new XElement("Name", group.name),
                    new XElement("Teacher", group.teacher.PIB)
                );
                doc.Root.Add(xElement);
            }
            foreach (Student info_About in lists.ListOfStudent)
            {
                XElement noteElement = new XElement("Students",
                    new XElement("PIB", info_About.PIB),
                    new XElement("Phonenumber", info_About.PhoneNumber),
                    new XElement("Programinggrade", info_About.ProgramingGrade),
                    new XElement("Modelinggrade", info_About.Modeling),
                    new XElement("Robotechgrade", info_About.Roboechnik),
                    new XElement("Dateofbirth", info_About.DateOfBirth.ToString("yyyy-MM-dd HH:mm:ss"))
                );
                doc.Root.Add(noteElement);
            }
            doc.Save(filePath);
        }
        public void Edit()
        {
        }
        public void Show(Group group)
        {
            Console.WriteLine("Group" + group.name);
        }
    }
    public class Program
    {
        public static void Main()
        {
            Group group1 = new Group
            {
                name = "Group 1",
                teacher = new Teacher()
            };
            Student student = new Student
            {
                PIB = "Gleb Renkas Sergeevich",
                PhoneNumber = "0937905130",
                ProgramingGrade = "12",
                Modeling = "12",
                Roboechnik = "12"
            };
            Groups groups = new Groups("data.xml");
            groups.Load(group1);
            groups.Add(group1, student);
            groups.Save(group1);
        }
    }
}