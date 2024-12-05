using System;
using System.Linq;
/*
Опис проекту:
Програма повинна надавати можливість виконання різноманітних операцій з колекціями даних, таких як фільтрація, сортування, групування, преобразування та агрегація за допомогою LINQ.
Функціональні вимоги:
Користувач повинен мати можливість ввести дані для створення колекції (наприклад, числа або рядки) через консоль.
Програма повинна надавати меню, що дозволяє обирати операцію для виконання над введеною колекцією (фільтрація, сортування, групування тощо).
Після обрання операції користувач повинен мати змогу ввести необхідні параметри (наприклад, умову фільтрації, критерії сортування).
Програма повинна виводити результати обробки колекції на екран користувача.
*/
namespace Project
{
    public class Collection
    {
        public int Number { get; set; }
        public string Smth { get; set; }
        public Collection(int number, string smth)
        {
            Number = number;
            Smth = smth;
        }
    }
    public class Service
    {
        private List<Collection> collections;
        public Service()
        {
            collections = new List<Collection>();
        }
        public void Add(int number, string smth)
        {
            collections.Add(new Collection(number, smth));
        }
        public void Filtr()
        {
            var a = collections.Where(x => x.Number > 6);
            Console.WriteLine(a);
            foreach (var b in collections)
            {
                Console.WriteLine(b.Number);
            }
            Console.WriteLine("Начальника, ничего не работает начальника!");
        }
    }
    public class Program
    {
        public static void Main()
        {
            Service service = new Service();
            int choice;
            Console.WriteLine("==========================");
            Console.WriteLine("| Choose 1 of the option |");
            Console.WriteLine("|      1 - Filtr         |");
            Console.WriteLine("|      2 - Sort          |");
            Console.WriteLine("|      3 - Group         |");
            Console.WriteLine("==========================");
            service.Add(12, "a");
            service.Add(14, "b");
            service.Add(5, "c");
            service.Filtr();
        }
    }
}
