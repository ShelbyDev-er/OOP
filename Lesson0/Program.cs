using System;

class ContactInfo
{
    public int id;
    public string name;
    public string phoneNumber;
}

namespace ContactsManagementProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0, countContacts = 0;
            LinkedList<ContactInfo> listContact = new LinkedList<ContactInfo>();
            while (choice != 5)
            {
                DisplayMainMenu();
                choice = GetChoice();
                switch (choice)
                {
                    case 1:
                        countContacts = AddContact(listContact, countContacts);
                        break;
                    case 2:
                        UpdateContact(listContact, countContacts);
                        break;
                    case 3:
                        // DeleteContact();
                        break;
                    case 4:
                        DisplayAllContact(listContact, "DISPLAY CONTACTS");
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine(" Please Enter number between 1 and 5!");
                        break;
                }
            }
        }
        static ContactInfo GetContact(int idContact)
        {
            ContactInfo contact = new ContactInfo();
            contact.id = idContact;
            Console.Write(" Name: ");
            contact.name = Console.ReadLine();
            Console.Write(" Phone Number: ");
            contact.phoneNumber = Console.ReadLine();
            return contact;
        }
        static int AddContact(LinkedList<ContactInfo> listContact, int idContact)
        {
            DisplayTitle("ADD CONTACT");
            idContact++;
            ContactInfo contact = GetContact(idContact);
            listContact.AddLast(contact);
            return idContact;
        }
        static void UpdateContact(LinkedList<ContactInfo> listContact, int countContacts)
        {
            DisplayAllContact(listContact, "UPDATE CONTACT");
            Console.Write(" #ID CHOICE: ");
            int idChoice = Int16.Parse(Console.ReadLine());
            foreach (ContactInfo item in listContact)
            {
                if (item.id == idChoice)
                {
                    ContactInfo temp = item;
                    Console.Write(" Name: ");
                    temp.name = Console.ReadLine();
                    Console.Write(" Phone Number: ");
                    temp.phoneNumber = Console.ReadLine();
                    break;
                }
            }
        }
        static void DeleteContact(LinkedList<ContactInfo> listContact)
        {
            Console.WriteLine(" #ID CHOICE: ");
            int idChoice = Int16.Parse(Console.ReadLine());
        }
        static void DisplayAllContact(LinkedList<ContactInfo> listContact, string title)
        {
            DisplayTitle(title);
            DisplayContactsTitle();
            int id = 0;
            foreach (ContactInfo item in listContact)
            {
                id++;
                Console.WriteLine("   " + id + "   | " + item.name);
            }
        }
        static void DisplayContactsTitle()
        {
            DisplayLine();
            Console.WriteLine("| ID   | NAME                            ");
            DisplayLine();
        }
        static void DisplayMainMenu()
        {
            DisplayLine();
            Console.WriteLine(" ---       Contacts Manegement       --- ");
            DisplayLine();
            Console.WriteLine(" 1. Add Contact");
            Console.WriteLine(" 2. Edit Contact");
            Console.WriteLine(" 3. Delete Contact");
            Console.WriteLine(" 4. Display All Contacts");
            Console.WriteLine(" 5. Exit");
            DisplayLine();
        }
        static void DisplayTitle(string title)
        {
            DisplayLine();
            Console.WriteLine($" {title}");
            DisplayLine();
        }
        static void DisplayLine()
        {
            Console.WriteLine("=========================================");
        }
        static int GetChoice()
        {
            Console.Write(" #Choice: ");
            string temp = Console.ReadLine();
            int choice = Int16.Parse(temp);
            return choice;
        }
    }
}