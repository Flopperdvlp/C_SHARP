using System;

namespace Project
{
    public static class Class
    {
        public static int MinIn2DArray(int[,] number)
        {
            int min = number[0, 0];
            for (int i = 0; i < number.GetLength(0); i++)
            {
                for (int j = 0; j < number.GetLength(1); j++)
                {
                    if (number[i, j] < min)
                    {
                        min = number[i, j];
                    }
                }
            }
            return min;
        }
        public static int MaxIn2DArray(int[,] number)
        {
            int max = number[0, 0];
            for (int i = 0; i < number.GetLength(0); i++)
            {
                for (int j = 0; j < number.GetLength(1); j++)
                {
                    if (number[i, j] > max)
                    {
                        max = number[i, j];
                    }
                }
            }
            return max;
        }
        public static int DifferenceIn2DArray(int[,] number)
        {
            int min = Class.MinIn2DArray(number);
            int max = Class.MaxIn2DArray(number);
            return max - min;
        }
    }
    class Program
    {
        static void Main()
        {
            int[,] number = {
                {5,3,2,4,2},
                {8,10,6,2,2},
                {13,15,11,14,15},
                {44,55,12,10,1}
                // {100,200,300,400,500},
                // {12,13,12,11,14}
            };
            Console.WriteLine("Min: " + Class.MinIn2DArray(number));
            Console.WriteLine("Max: " + Class.MaxIn2DArray(number));
            Console.WriteLine("Dif: " + Class.DifferenceIn2DArray(number));
        }
    }
}