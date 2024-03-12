using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;
/*
Створіть документацію до вашого коду, використовуючи коментарі та докстрінги. Опишіть призначення кожного класу та методу, а також прийняті аргументи та повернені значення.
Додайте обмеження обобщеного класу CollectionManager<T>, щоб тип T реалізував інтерфейс IComparable<T>. Це дозволить вам використовувати функції порівняння для сортування колекцій
Реалізуйте функціонал сортування колекції за допомогою методу (SortCollection). Забезпечте можливість сортування за зростанням та спаданням значень.
Проведіть тестування різних сценаріїв використання вашого програмного продукту. Переконайтеся, що всі функції працюють коректно та програма обробляє різні ситуації.
Напишіть короткий звіт, в якому ви описуєте ваш підхід до вирішення завдання, труднощі, з якими ви зіткнулися, та рішення, які ви прийняли. Також включіть приклади використання вашого коду*/
namespace Project
{
    public class CollectionManager<T>
    {
        private List<T> list;
        public CollectionManager()
        {
            list = new List<T>();
        }
        public void add(T item)
        {
            list.Add(item);
        }
        public void remove(T item)
        {
            list.Remove(item);
        }
        public void show()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
    public class Program
    {
        static void Main()
        {
            int choice = 0;
            Console.WriteLine("Выберите 1 из 3: 1 - int, 2 - string, 3 - object");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    CollectionManager<int> intCollectionManager = new CollectionManager<int>();
                    intCollectionManager.add(1);
                    intCollectionManager.add(2);
                    intCollectionManager.show();
                    break;
                case 2:
                    CollectionManager<string> stringCollectionManager = new CollectionManager<string>();
                    stringCollectionManager.add("Hello");
                    stringCollectionManager.add("World");
                    stringCollectionManager.show();
                    break;
                case 3:
                    CollectionManager<object> objectCollectionManager = new CollectionManager<object>();
                    objectCollectionManager.add(123);
                    objectCollectionManager.add("asd");
                    objectCollectionManager.show();
                    break;
                default:
                    break;
            }
        }
    }
}