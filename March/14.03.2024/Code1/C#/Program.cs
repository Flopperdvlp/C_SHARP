using System;
using System.Collections.Generic;
using System.Linq;
namespace Program
{
    public class Chair
    {
        public string Color { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
    }
    public class Mainn
    {
        static Random random = new Random();
        static void Main()
        {
            List<Chair> chairs = GenerateChairs(100);
            Console.WriteLine("Початковий список стільців:");
            Sort(chairs);
            PrintChairs(chairs);
        }
        //!----------------------------------------------------------------------------!//
        static List<Chair> GenerateChairs(int count)
        {
            List<Chair> chairs = new List<Chair>();
            string[] colors = { "червоний", "зелений", "синій" };
            string[] names = { "Максим", "Іван", "Сергій" };
            for (int i = 0; i < count; i++)
            {
                Chair chair = new Chair
                {
                    Number = i + 1,
                    Color = colors[random.Next(0, colors.Length)],
                    Name = names[random.Next(0, names.Length)]
                };
                chairs.Add(chair);
            }
            return chairs;
        }
        //!----------------------------------------------------------------------------!//
        static void PrintChairs(List<Chair> chairs)
        {
            foreach (var t in chairs)
            {
                Console.WriteLine("Chair number: " + t.Number + " | " + " Chair color: " + t.Color + " | " + " Chair name: " + t.Name);
            }
        }
        //!----------------------------------------------------------------------------!//
        static void Sort(List<Chair> chairs)
        {
            chairs.Sort((x, y) =>
            {
                if (x.Color == "червоний" && y.Color == "зелений")
                    return -1;
                if (x.Color == "зелений" && y.Color == "червоний")
                    return 1;
                if (x.Name == "Максим" && y.Name == "Іван")
                    return 1;
                if (x.Name == "Іван" && y.Name == "Максим")
                    return -1;
                return x.Number.CompareTo(y.Number);
            });
        }
    }
}