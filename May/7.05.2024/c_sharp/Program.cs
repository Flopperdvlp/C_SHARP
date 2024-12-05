using System;
using System.Reflection;

namespace Project
{
    public class MenuItem
    {
        public string Name { get; set; }
        public double price { get; set; }
        public virtual double Price => (price);
        public string Info { get; set; }
        public int Idex { get; set; }
    }
    public class Menu
    {
        public List<MenuItem> list_of_menu_items = new List<MenuItem>();
        public void add(MenuItem menu_item)
        {
            list_of_menu_items.Add(menu_item);
        }
        public void remove_by_index(MenuItem menu_item, int index)
        {
            if (index >= 0 && index < menu.list_of_menu_items.Count)
            {

            }

        }
        public void Show_all_items()
        {
            foreach(var t in list_of_menu_items)
            {
                Console.WriteLine($"Menu item name: {t.Name}, item price: {t.Price}, info about item: {t.Info}.");
            }
        }
    }
    public class Order
    {
        List<MenuItem> list_of_customer_wishlist = new List<MenuItem>();
        public void Add_ingrediant_by_index(Menu menu, int index, MenuItem menuitem)
        {
            if (index >= 0 && index < menu.list_of_menu_items.Count)
            {
                menu.list_of_menu_items[index] = menuitem;
            }
            else
            {
                Console.WriteLine("Index didnt find");
            }
        }
    }
    public class IngredientDecorator : MenuItem
    {
        private readonly MenuItem menuitem;
        public IngredientDecorator(MenuItem menuItem)
        {
            menuitem = menuItem;
        }
        public override double Price => menuitem.Price + 10;
    }
    public class Cafe
    {
        public static void Main()
        {
            Menu menu = new Menu();
            int choice;
            do
            {
                Console.WriteLine("Choose one of the option: 1 - Доставкой, 2 - На вынос");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Menu: ");
                        menu.Show_all_items();
                        Console.WriteLine("Choose one of the option: 1 - Add, 2 - Remove, 3 - Show Menu");
                        choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter Name: ");
                                string name = Console.ReadLine();
                                Console.WriteLine("Enter price: ");
                                int price = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter Info: ");
                                string info = Console.ReadLine();
                                MenuItem newmenuitem = new MenuItem {
                                    Name = name,
                                    price = price,
                                    Info = info
                                };
                                menu.add(newmenuitem);
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            default:
                                break;
                            case 0:
                                break;
                        }
                        break;
                    case 2:
                        break;
                    default:
                        break;
                    case 0:
                        break;
                }
            } while (choice != 0);
        }
    }
}