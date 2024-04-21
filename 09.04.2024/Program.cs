using System;
using System.Collections.Generic;
using System.Linq;
/*Система управління проектами:
Сутності: Проекти, Завдання, Команди, Замовники
Зв'язки: Кожен проект може мати багато завдань, кожна команда може працювати над багатьма проектами.
*/
namespace Program
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public List<Task> Tasks { get; set; }
        public List<Team> Teams { get; set; }
        public Project()
        {
            Tasks = new List<Task>();
            Teams = new List<Team>();
        }
    }
    public class Task
    {
        public int TaskId { get; set; }
        public string? TaskName { get; set; }
        public Project? Project { get; set; }
    }
    public class Team
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public List<Project> Projects { get; set; }
        public Team()
        {
            Projects = new List<Project>();
        }
    }
    public class Customer
    {
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
    }
    public class Mainn
    {
        static void Main()
        {
            Customer customer = new Customer { CustomerId = 1, CustomerName = "Customer 1" };
            Project project = new Project { ProjectId = 1, ProjectName = "Project 1" };
            Task task = new Task { TaskId = 1, TaskName = "Task 1", Project = project };
            Team team = new Team { TeamId = 1, TeamName = "Team 1" };
            project.Tasks.Add(task);
            team.Projects.Add(project);
            Console.WriteLine("Customer: " + customer.CustomerName);
            Console.WriteLine("Project: " + project.ProjectName);
            Console.WriteLine("Projects task:");
            foreach (var t in project.Tasks)
            {
                Console.WriteLine("- " + t.TaskName);
            }
            Console.WriteLine("team: " + team.TeamName);
            Console.WriteLine("Projects task:");
            foreach (var p in team.Projects)
            {
                Console.WriteLine("- " + p.ProjectName);
            }
        }
    }
}