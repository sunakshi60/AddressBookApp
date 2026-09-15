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
        AddressBookMain addressBookMain = new AddressBookMain();

        addressBookMain.AddAddressBook(addressBook);

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Edit Contact");
            Console.WriteLine("3. Delete Contact");
            Console.WriteLine("4. Show All Contacts");
            Console.WriteLine("5. Count Contacts");
            Console.WriteLine("6. Search Contacts");
            Console.WriteLine("7. View Contacts");
            Console.WriteLine("8. Count Contacts ");
            Console.WriteLine("9. Sort Contacts by Name ");
            Console.WriteLine("10. Sort Contacts by City / State /Zip");
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

                    if (addressBook.AddContact(contact))
                    {
                        Console.WriteLine("\nContact added successfully.");
                    }
                    else
                    {
                        Console.WriteLine("\nContact already exists");
                    }

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
            else if (choice == "5")
            {
                Console.WriteLine($"Total Contacts: {addressBookMain.CountContacts()}");
            }
            else if (choice == "6")
            {
                Console.WriteLine("Search By:");
                Console.WriteLine("1. City");
                Console.WriteLine("2. State");

                Console.Write("Enter your choice: ");
                string searchChoice = Console.ReadLine();

                if (searchChoice == "1")
                {
                    Console.Write("Enter a city to search: ");
                    string city = Console.ReadLine();
                    addressBookMain.SearchByCity(city);
                }
                else if (searchChoice == "2")
                {
                    Console.Write("Enter a state to search: ");
                    string state = Console.ReadLine();
                    addressBookMain.SearchByState(state);
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
            else if (choice == "7")
            {
                Console.WriteLine("View Contacts By:");
                Console.WriteLine("1. City");
                Console.WriteLine("2. State");

                Console.Write("Enter your choice: ");
                string viewChoice = Console.ReadLine();

                if (viewChoice == "1")
                {
                    addressBookMain.ViewByCity();
                }
                else if (viewChoice == "2")
                {
                    addressBookMain.ViewByState();
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
            else if (choice == "8")
            {
                Console.WriteLine("Count Contacts By:");
                Console.WriteLine("1. City");
                Console.WriteLine("2. State");

                Console.Write("Enter your choice: ");
                string countChoice = Console.ReadLine();

                if (countChoice == "1")
                {
                    addressBookMain.CountByCity();
                }
                else if (countChoice == "2")
                {
                    addressBookMain.CountByState();
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
            else if (choice == "9")
            {
                addressBookMain.SortByName();
            }
            else if (choice == "10")
            {
                Console.WriteLine("Sort By:");
                Console.WriteLine("1. City");
                Console.WriteLine("2. State");
                Console.WriteLine("3. Zip");

                Console.Write("Enter your choice: ");
                string sortChoice = Console.ReadLine();

                if (sortChoice == "1")
                {
                    addressBookMain.SortByCity();
                }
                else if (sortChoice == "2")
                {
                    addressBookMain.SortByState();
                }
                else if (sortChoice == "3")
                {
                    addressBookMain.SortByZip();
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
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
