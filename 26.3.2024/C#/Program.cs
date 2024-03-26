using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using System.IO;
using System.Xml;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using System.Linq;
namespace Project
{
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public double Balance { get; set; }
        public string Status { get; set; }
        public string DateOfReg { get; set; }
    }
    public class UserManagementSystem
    {
        private readonly string filePath;
        private XDocument xDocument;
        public UserManagementSystem(string filePath)
        {
            this.filePath = filePath;
            if (File.Exists(filePath))
            {
                xDocument = XDocument.Load(filePath);
            }
            else
            {
                xDocument = new XDocument(new XElement("users"));
            }
        }
        public void AddUser(User user)
        {
            XElement xElement = new XElement("user",
                new XElement("name", user.Name),
                new XElement("password", user.Password),
                new XElement("email", user.Email),
                new XElement("age", user.Age),
                new XElement("balance", user.Balance),
                new XElement("status", user.Status),
                new XElement("birth_date", user.BirthDate.ToString("yyyy-MM-dd")),
                new XElement("country", user.Country));

            xDocument.Element("users").Add(xElement);
            xDocument.Save(filePath);
        }
        public void DeleteUser(string name)
        {
            XElement user = FindByName(name);
            if (user != null)
            {
                user.Remove();
                xDocument.Save(filePath);
            }
        }
        private XElement FindByName(string name)
        {
            return xDocument.Descendants("user")// щоб знайти всі елементи <user> у документі XML, а потім застосовуємо метод FirstOrDefault
                .FirstOrDefault(x => (string)x.Element("name") == name);//щоб знайти перший елемент, для якого ім'я користувача співпадає з переданим іменем
        }
        /*TODO:public void EditUser()
        {
        }*/
        public List<User> GetAllUsers()
        {
            return xDocument.Descendants("user").Select(x => new User
            {
                Name = (string)x.Element("name"),
                Password = (string)x.Element("password"),
                Email = (string)x.Element("email"),
                Age = (int)x.Element("age"),
                Balance = (double)x.Element("balance"),
                Status = (string)x.Element("status"),
                BirthDate = DateTime.ParseExact((string)x.Element("birth_date"), "yyyy-MM-dd", null),
                Country = (string)x.Element("country")
            }).ToList();
        }
    }
    public class Program
    {
        public static void Main()
        {
            UserManagementSystem userManagementSystem = new UserManagementSystem("data.xml");
            User user = new User
            {
                Name = "John",
                Password = "12345",
                Email = "john.doe@example.com",
                Age = 30,
                Balance = 100.50,
                Status = "Online",
                BirthDate = new DateTime(1990, 5, 15),
                Country = "Canada"
            };
            userManagementSystem.AddUser(user);
            List<User> allUsers = userManagementSystem.GetAllUsers();
            Console.WriteLine("All Users:");
            foreach (var User in allUsers)
            {
                Console.WriteLine($"{user.Name}, {user.Email}, {user.Age}, {user.Balance}");
            }
        }
    }
}