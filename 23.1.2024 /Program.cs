using System;
namespace Project
{
    class Program
    {         
        static void Main(string[] args)
        {
            Console.WriteLine("Генератор паролей");
            Console.WriteLine("Введите длину пароля: ");
            int length = Convert.ToInt32(Console.ReadLine());
            void Generator(int length){
                string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+-=[]{}|;:',.<>/?~`";
                Random random = new Random();
                char[] password = new char[length];
                for (int i = 0; i < length; i++){
                    password[i] = characters[random.Next(characters.Length)];
                }
                Console.WriteLine("Пароль: " + new string(password));
                Console.ReadKey();
                return;
            }
            Generator(length);
            return;
        }
    }
}  