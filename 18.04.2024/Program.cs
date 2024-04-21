using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
/*Технічне завдання: Система ведення обліку книг у бібліотеці
Мета проекту:
Розробити програму для ведення обліку книг у бібліотеці, яка дозволить користувачам додавати, редагувати та видаляти інформацію про книги у форматі JSON. 
Система повинна надати зручний інтерфейс для управління книжковим фондом бібліотеки.
Основні функціональні вимоги:
    Додавання нових книг: 
        Користувач повинен мати можливість додавати нові книги до бібліотечного фонду, вказуючи назву, автора, жанр, рік видання та інші характеристики.
    Редагування інформації про книги:  
        Користувач повинен мати можливість редагувати інформацію про існуючі книги, змінюючи атрибути, такі як назва, автор, жанр тощо.
    Видалення книг: 
        Користувач повинен мати можливість видаляти книги з бібліотечного фонду, які більше не потрібні або не доступні.
    Пошук книг: 
        Система повинна надати можливість здійснювати пошук книг за різними критеріями, такими як назва, автор, жанр тощо.
    Перегляд книжкового фонду: 
        Користувач повинен мати можливість переглядати всі книги, що зберігаються у бібліотеці, в зручному форматі.
    Інтерфейс користувача: 
        Інтерфейс користувача повинен бути простим та інтуїтивно зрозумілим, з можливістю додавання, редагування та видалення книг, а також здійснення пошуку та перегляду книжкового фонду.
    Збереження даних: 
        Зміни у JSON-файлі, що містить інформацію про книги, повинні зберігатись автоматично після внесення користувачем будь-яких змін.*/
namespace Program
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Zanr { get; set; }
        public string Age { get; set; }
        public int ID { get; set; }
    }
    public class BookManageer
    {
        List<Book> Books = new List<Book>();
        public void AddBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine("Book added");
        }
        public void RemoveBook(Book book)
        {
            Books.Remove(book);
        }
        public List<Book> GetAllBooks()
        {
            return Books;
        }
    }
    public class Mainn
    {
        static void Main()
        {
            Console.WriteLine("1 - Add book\n2 - Remove book\n3 - Edit book\n4 - Show all books\n5 - Find book");
            int Choice = Convert.ToInt32(Console.ReadLine());
            BookManageer bookManageer = new BookManageer();
            switch (Choice)
            {
                case 1:
                    Console.WriteLine("Enter book info");
                    Console.WriteLine("Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Author: ");
                    string author = Console.ReadLine();
                    Console.WriteLine("Zanr: ");
                    string zanr = Console.ReadLine();
                    Console.WriteLine("Age: ");
                    string age = Console.ReadLine();
                    Console.WriteLine("id: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Book newbook = new Book
                    {
                        Name = name,
                        Author = author,
                        Zanr = zanr,
                        Age = age,
                        ID = id,
                    };
                    bookManageer.AddBook(newbook);
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    break;
            }
        }
    }
}