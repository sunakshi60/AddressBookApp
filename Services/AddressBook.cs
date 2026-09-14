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

        public void PrintAll()
        {
            foreach (Contact contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }
    }
}