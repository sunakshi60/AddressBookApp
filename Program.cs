using AddressBookApp.Models;
using AddressBookApp.Validation;
using AddressBookApp.Exceptions;
using AddressBookApp.Services;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Address Book App");
        AddressBook addressBook = new AddressBook();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Edit Contact");
            Console.WriteLine("3. Delete Contact");
            Console.WriteLine("4. Show All Contacts");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                try
                {
                    Console.Write("Enter first name: ");
                    string firstName = Console.ReadLine();

                    Console.Write("Enter last name: ");
                    string lastName = Console.ReadLine();

                    Console.Write("Enter address: ");
                    string address = Console.ReadLine();

                    Console.Write("Enter city: ");
                    string city = Console.ReadLine();

                    Console.Write("Enter state: ");
                    string state = Console.ReadLine();

                    Console.Write("Enter zip: ");
                    string zip = Console.ReadLine();

                    Console.Write("Enter phone number: ");
                    string phoneNumber = Console.ReadLine();

                    Console.Write("Enter email: ");
                    string email = Console.ReadLine();

                    Contact contact = new Contact(
                        firstName,
                        lastName,
                        address,
                        city,
                        state,
                        zip,
                        phoneNumber,
                        email
                    );

                    addressBook.AddContact(contact);

                    Console.WriteLine("Contact added successfully.");
                }
                catch (InvalidContactException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            else if (choice == "2")
            {
                Console.WriteLine("Enter first name to edit: ");
                string firstName = Console.ReadLine();

                Console.WriteLine("Enter last name to edit: ");
                string lastName = Console.ReadLine();

                try
                {
                    addressBook.EditContact(firstName, lastName);
                }
                catch(InvalidContactException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            else if(choice == "3")
            {
                Console.Write("Enter first name to delete: ");
                string firstName = Console.ReadLine();

                Console.Write("Enter last name to delete: ");
                string lastName = Console.ReadLine();

                addressBook.DeleteContact(firstName, lastName);
            }
            else if (choice == "4")
            {
                addressBook.PrintAll();
            }
            else if(choice == "0")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
        Console.ReadLine();
    }
}
