using System;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;
/*Створіть узагальнений метод Swap, який обмінює значення двох змінних типу T. Використайте параметр типу для забезпечення гнучкості обміну різних типів даних.*/
namespace Project
{
    public class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T t = a;
            a = b;
            b = t;
        }
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Befor swap a = " + a + ", b = " + b);
            Swap(ref a, ref b);
            Console.WriteLine("After swap a = " + a + ", b = " + b);
            string first = "Hello";
            string second = "How are y?";
            Console.WriteLine("Befor swap first = " + first + ", second = " + second);
            Swap(ref first, ref second);
            Console.WriteLine("Befor swap first = " + first + ", second = " + second);
        }
    }
}