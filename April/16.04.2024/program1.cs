using System;
using System.Xml.Linq;
namespace Code1
{
    public class Mainn
    {
        public static void Main()
        {
            XDocument xmlDoc = XDocument.Load(@"/Users/gleb/Desktop/Code1/a.xml");
            foreach (var company in xmlDoc.Descendants("Company"))
            {
                string companyName = company.Element("Name").Value;
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine($"\n            Company: {companyName}\n");
                Console.WriteLine("╔═════════════════════════════════════════");
                Console.WriteLine("{0,-12}{1,-16}{2,-16}", "║ Employee ║", " Department      ║", " Projects  ");
                foreach (var employee in company.Descendants("Employee"))
                {
                    string employeeName = employee.Element("Name").Value;
                    string department = employee.Element("Department").Value;
                    Console.Write($"║ {employeeName,-9}");
                    Console.Write($"║ {department,-16}");
                    string[] projects = GetProjects(employee);
                    Console.WriteLine("║ " + string.Join(", ", projects));
                }
                Console.WriteLine("╚═════════════════════════════════════════");
            }
        }
        static string[] GetProjects(XElement employee)
        {
            var xmlNodeList = employee.Elements("Projects").Elements("ProjectID");
            string[] projects = new string[xmlNodeList.Count()];
            for (int i = 0; i < xmlNodeList.Count(); i++)
            {
                projects[i] = xmlNodeList.ElementAt(i).Value;
            }
            return projects;
        }
    }
}