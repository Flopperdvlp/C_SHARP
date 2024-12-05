using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
/*Напишіть програму.
Програма має запитувати в адміністратора дані для додавання нового клієнту у базу даних:
-ПІП
-Вік
-Номер телефону
-Унікальний ID(за допомогою генерації)
Програма надає варіанти 
    створення, 
    редагування     
    читання даних 
із xml документу.
*/
namespace csharp
{
    public class Info
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string ID { get; set; }

        public Info() { }

        public Info(string name, string surname, string middlename, int age, string phonenumber, string id)
        {
            this.Name = name;
            this.Surname = surname;
            this.MiddleName = middlename;
            this.Age = age;
            this.PhoneNumber = phonenumber;
            this.ID = id;
        }
    }
    public class Add//FIXME: Есть проблема, оно не добавляет по имени! проблема почти решена
    {
        public void AddClient(string Path, Info newclient)
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement xmlElement = xmlDocument.CreateElement("People");
            xmlDocument.AppendChild(xmlElement);
            for (int i = 0; i <= 5; i++)
            {
                XmlElement person = xmlDocument.CreateElement("Person");
                XmlElement name = xmlDocument.CreateElement("Name");
                name.InnerText = "Person" + i;
                person.AppendChild(name);
                xmlElement.AppendChild(person);
            }
            xmlDocument.Save(Path);
            Console.WriteLine("XML FILE OK");
        }
    }
    public class Read
    {
        public void ReadFile(string Path)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(Path);
            XmlElement root = xmlDocument.DocumentElement;
            Console.WriteLine("XML DATA: ");
            foreach (XmlNode node in root.ChildNodes)
            {
                string name = node.SelectSingleNode("Name").InnerText;
                Console.WriteLine($"Name:{name}");
            }
        }
    }
    public class Edit
    {
        public void Append(string Path)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(Path);
            XmlElement root = xmlDocument.DocumentElement;
            for (int i = 4; i <= 5; i++)
            {
                XmlElement person = xmlDocument.CreateElement("Person");
                XmlElement name = xmlDocument.CreateElement("Name");
                name.InnerText = "Person" + i;
                person.AppendChild(name);
                root.AppendChild(person);
            }
            xmlDocument.Save(Path);
        }
    }
    public class Project
    {
        public static void Main()
        {
            string xmlFilePath = "data.xml";

            Console.WriteLine("Hello, please enter client information:");

            Console.WriteLine("Please enter client's name:");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter client's surname:");
            string surname = Console.ReadLine();

            Console.WriteLine("Please enter client's middle name:");
            string middleName = Console.ReadLine();

            Console.WriteLine("Please enter client's age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter client's phone number:");
            string phoneNumber = Console.ReadLine();

            string id = Guid.NewGuid().ToString();
            Info newClient = new Info(name, surname, middleName, age, phoneNumber, id);
            Add add = new Add();
            Read read = new Read();
            Edit edit = new Edit();
            add.AddClient(xmlFilePath, newClient);
            Console.WriteLine("Befor Appending");
            read.ReadFile(xmlFilePath);
            Console.WriteLine("After Appending");
            edit.Append(xmlFilePath);
            read.ReadFile(xmlFilePath);
        }
    }
}
