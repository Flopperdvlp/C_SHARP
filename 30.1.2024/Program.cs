using System;

namespace Project
{
    class Task
    {
        public string Title { get; set; }
        public List<Task> SubTasks {get; set;} = new List<Task>(); 
    }
    class Program 
    {
        static void Main()
        {
            List<Task> tasks = new List<Task>();
            Task task1 = new Task {Title = "Сделать чай"};
            task1.SubTasks.Add(new Task { Title = "Налить воду в чайник"});
            tasks.Add(task1);
            DisplayTasks(tasks, "");
        }
        static void DisplayTasks(List<Task> tasks, string indent)
        {
            foreach (var task in tasks)
            {
                Console.WriteLine(indent + task.Title);
                DisplayTasks(task.SubTasks, indent + "  ");
            }
        }
    }
}  