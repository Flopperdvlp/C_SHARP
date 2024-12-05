using System;
using System.Threading.Tasks.Dataflow;
/*
Розробіть розширену версію програми для зоопарку, що дозволяє керувати тваринами в різних вольєрах та стежити за їхнім здоров'ям.
Додайте клас "Вольєра" (Enclosure), який має свою назву та можливість зберігати тварин у власній колекції.
Розширте клас "Тварина" з можливістю визначення вольєри, в якій вона знаходиться, а також додайте характеристику "Стан Здоров'я".
Додайте можливість відслідковувати та виводити інформацію про тварини у конкретній вольєрі.
Реалізуйте систему подій для тварин, так щоб вони могли повідомляти про стан свого здоров'я, а вольєри могли реагувати на події у тварин.
Додайте можливість лікування та годування тварин у зоопарку. Реалізуйте ці дії через виклик методів "Лікувати" та "Годувати", впливаючи на стан здоров'я та харчування тварин.
Введіть можливість симуляції часу в програмі та автоматичного оновлення стану тварин та вольєрів.
Використайте інтерфейси та абстрактні класи для максимальної гнучкості та зручності у розширенні функціоналу.
*/
namespace Project
{
    public class Zoo
    {
        public List<Animal> Animals { get; set; }
        public Zoo()
        {
            Animals = new List<Animal>();
        }
        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
            Console.WriteLine("Animal added to the zoo");
        }
    }
    public class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public Animal(string name, string species, int age)
        {
            Name = name;
            Species = species;
            Age = age;
        }
    }
    public class Enclosure
    {
        public string Name { get; set; }
        public List<Animal> animals { get; set; }
        public Enclosure(string name)
        {
            Name = name;
            animals = new List<Animal>();
        }
        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }
    }
    public class Program
    {
        public static void Main()
        {
            Zoo zoo = new Zoo();
            Enclosure enclosure = new Enclosure("1");
            Animal animal1 = new Animal("Gepard", "Cat", 3);
            zoo.AddAnimal(animal1);
        }
    }
}