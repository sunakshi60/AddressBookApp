using AddressBookApp.Models;
using AddressBookApp.Validation;

namespace AddressBookApp.Services
{
    public class AddressBook
    {
        private List<Contact> contacts = new();

        public IReadOnlyList<Contact> Contacts => contacts;

        public void AddContact(Contact contact)
        {
            ContactValidator.Validate(contact);
            contacts.Add(contact);
        }

        public void EditContact(string firstName, string lastName)
        {
            Contact contact = contacts.FirstOrDefault(
                c => c.FirstName == firstName && c.LastName == lastName
            );

            if (contact == null)
            {
                Console.WriteLine("Contact not found");
                return;
            }

            Console.WriteLine($"Editing: {contact}");

            Console.Write("Enter new first name (or press Enter to keep): ");
            string newFirstName = Console.ReadLine();

            Console.Write("Enter new last name (or press Enter to keep): ");
            string newLastName = Console.ReadLine();

            Console.Write("Enter new address (or press Enter to keep): ");
            string newAddress = Console.ReadLine();

            Console.Write("Enter new city (or press Enter to keep): ");
            string newCity = Console.ReadLine();

            Console.Write("Enter new state (or press Enter to keep): ");
            string newState = Console.ReadLine();

            Console.Write("Enter new zip (or press Enter to keep): ");
            string newZip = Console.ReadLine();

            Console.Write("Enter new phone number (or press Enter to keep): ");
            string newPhoneNumber = Console.ReadLine();

            Console.Write("Enter new email (or press Enter to keep): ");
            string newEmail = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(newFirstName))
                contact.FirstName = newFirstName;

            if (!string.IsNullOrWhiteSpace(newLastName))
                contact.LastName = newLastName;

            if (!string.IsNullOrWhiteSpace(newAddress))
                contact.Address = newAddress;

            if (!string.IsNullOrWhiteSpace(newCity))
                contact.City = newCity;

            if (!string.IsNullOrWhiteSpace(newState))
                contact.State = newState;

            if (!string.IsNullOrWhiteSpace(newZip))
                contact.Zip = newZip;

            if (!string.IsNullOrWhiteSpace(newPhoneNumber))
                contact.PhoneNumber = newPhoneNumber;

            if (!string.IsNullOrWhiteSpace(newEmail))
                contact.Email = newEmail;

            ContactValidator.Validate(contact);

            Console.WriteLine("Contact updated.");
        }

        public void DeleteContact(string firstName,string lastName)
        {
            Contact contact = contacts.FirstOrDefault(
                c => c.FirstName == firstName && c.LastName == lastName
            );

            if (contact == null)
            {
                Console.WriteLine("Contact not founs.");
                return;
            }

            contacts.Remove(contact);

            Console.WriteLine("Contact deleted");
        }

        public void PrintAll()
        {
            foreach (Contact contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }
    }
}