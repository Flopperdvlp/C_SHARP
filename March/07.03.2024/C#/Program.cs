using System;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;
namespace Project
{
    public class Sklad
    {
        public List<Product> listtovarov { get; set; }
        public Sklad(List<Product> products)
        {
            listtovarov = products;
        }
        public void BuyTovar()
        {
            foreach (var t in listtovarov)
            {
                if (t.Quantity == 0)
                {
                    Console.WriteLine("Product: " + t.Name + " end");
                    t.ReplenishStock(10);
                }
            }
        }
    }
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Id { get; set; }
        public int Quantity { get; set; }
        public Product(string name, double price, string id, int quantity)
        {
            Name = name;
            Price = price;
            Id = id;
            Quantity = quantity;
        }
        public void ReplenishStock(int quantity)
        {
            Quantity += quantity;
        }
    }
    public class Program
    {
        static void Main()
        {
            List<Product> initialProduct = new List<Product>
            {
            new Product("Apple", 12.10, "1D3", 2),
            new Product("Banana", 16.50, "2D3", 0)
            };
            Sklad sklad = new Sklad(initialProduct);
            sklad.BuyTovar();
        }
    }
}