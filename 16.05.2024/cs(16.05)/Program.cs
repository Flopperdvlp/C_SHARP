using System;
namespace Project
{
    public interface IPeople
    {
        void Sub();
        void UnSub();
    }
    public class Phone : IPeople
    {
        public Phone()
        {
        }
        public void Sub()
        {
            Console.WriteLine("Sub");
        }
        public void UnSub()
        {
            Console.WriteLine("Un sub");
        }
    }
    public class Sport_news
    {
        public Sport_news()
        {
        }
        public void Sub(bool status)
        {
            if(status == true)
            {
                Console.WriteLine("Sport news: 1");
            }
            else
            {
                Console.WriteLine("Y un sub");
            }
        }
    }
    public class Program
    {
        public static void Main()
        {

            int choice, choice1;
            bool statusS = false, statusP = false, statusT = false;
            do
            {
                Console.WriteLine("Choose one of the news, you want to sub(1 - Sport, 2 - Politika, 3 - Technology, 4 - show all news): ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Do y want to subscribe sport news(1 - y, 2 - un sub): ");
                        choice1 = Convert.ToInt32(Console.ReadLine());
                        switch (choice1)
                        {
                            case 1:
                                statusS = true;
                                break;
                            case 2:
                                statusS = false;
                                break;
                            case 0:
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Do y want to subscribe politika news(1 - y, 2 - un sub): ");
                        choice1 = Convert.ToInt32(Console.ReadLine());
                        switch (choice1)
                        {
                            case 1:
                                statusP = true;
                                break;
                            case 2:
                                statusP = false;
                                break;
                            case 0:
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Do y want to subscribe technology news(1 - y, 2 - un sub): ");
                        choice1 = Convert.ToInt32(Console.ReadLine());
                        switch (choice1)
                        {
                            case 1:
                                statusT = true;
                                break;
                            case 2:
                                statusT = false;
                                break;
                            case 0:
                                break;
                        }
                        break;
                    case 4:
                        controller.Sport(statusS);
                        controller.Politika(statusP);
                        controller.Technology(statusT);
                        break;
                    case 0:
                        break;
                }
            } while (choice != 0);
        }
    }
}