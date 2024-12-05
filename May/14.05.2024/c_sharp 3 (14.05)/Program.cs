using System;
namespace C_sharp
{
    public class Contact
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone_number { get; set; }
    }
    public class Contact_Manager
    {
        public List<Contact> list_of_contacts { get; set; }
        public Contact_Manager()
        {
            list_of_contacts = new List<Contact>();
        }
        public void Add_contact(Contact contact)
        {
            list_of_contacts.Add(contact);
            Console.WriteLine("Contact added");
        }
        public void Remove_Contact(Contact contact)
        {
            list_of_contacts.Remove(contact);
            Console.WriteLine("Contact deleted");
        }
    }
    public class Controller
    {

    }
    public class Project
    {
        public static void Main()
        {
            int Choose;
            do
            {
                Console.WriteLine("Choose 1 of the ption(1 - Add, 2 - Delet, 3 - Edit): ");
                Choose = Convert.ToInt32(Console.ReadLine());
                switch (Choose)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 0:
                        break;
                    default:
                        break;
                }
            } while (Choose != 0);
            Contact new_contact = new Contact
            {
                Name = "asd",
                Surname = "sd",
                Phone_number = "123"
            };
            Contact_Manager contact_manager = new Contact_Manager();
            contact_manager.Add_contact(new_contact);
            contact_manager.Remove_Contact(new_contact);
        }
    }
}