using System;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;
/*
Створіть клас Bank зі списком рахунків та надайте наступні можливості:

Додавання нового рахунку до списку.
Виведення інформації про всі рахунки.
Пошук рахунку за номером.
Здійснення операцій зняття та поповнення коштів.
Створіть об'єкти SavingsAccount та CheckingAccount, додайте їх до Bank та використайте всі можливості системи, включаючи розрахунок відсотків та обробку переписки.*/
namespace Project
{
    public class Bank
    {
    }
    public abstract class Account
    {
        public string AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }
    }
    public class SavingsAccount : Account
    {
        public double InterestRate { get; set; }
        public void CalculateInterest()
        {
            // TODO -> обчислювати відсоткову виплату на рахунок.
        }
    }
    public class CheckingAccount : Account
    {
        public double OverdraftLimit { get; set; }
        public void Withdraw()
        {
            // TODO -> списання коштів (Withdraw), щоб враховувався ліміт переписки.
        }
    }
    public class Program
    {
        public static void Main()
        {
            Account account = new Account();
        }
    }
}