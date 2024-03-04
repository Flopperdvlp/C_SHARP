using System;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;
using System.IO;
using System.Reflection;
using Project;
/*Створіть клас Calculator<T>, який містить узагальнені методи для виконання основних арифметичних операцій (додавання, віднімання, множення, ділення) над значеннями типу T. Обов'язково обробляйте випадок ділення на нуль.*/
namespace Project
{
    public class Calculator<T>
    {
        public T Add(T first, T second)
        {
            dynamic a = first;
            dynamic b = second;
            return a + b;
        }
        public T Minus(T first, T second)
        {
            dynamic a = first;
            dynamic b = second;
            return a - b;
        }
        public T Multiply(T first, T second)
        {
            dynamic a = first;
            dynamic b = second;
            return a * b;
        }
        public T Divide(T first, T second)
        {
            dynamic a = first;
            dynamic b = second;
            if (b == 0)
            {
                Console.WriteLine("You cant do this!");
            }
            return a / b;
        }
    }
}
public class Program
{
    static void Main()
    {
        Calculator<int> intCalculator = new Calculator<int>();
        Console.WriteLine("Adding: " + intCalculator.Add(2, 2));
        Console.WriteLine("Minusing: " + intCalculator.Minus(5, 1));
        Console.WriteLine("Multiply: " + intCalculator.Multiply(1, 5));
        Console.WriteLine("Divideing: " + intCalculator.Divide(5, 0));
    }
}