using AddressBookApp.Models;
using System.Collections.Generic;
using System.Linq;


namespace AddressBookApp.Services
{
    public class AddressBookMain
    {
        private List<AddressBook> addressBooks = new();

        public void AddAddressBook(AddressBook addressBook)
        {
            addressBooks.Add(addressBook);
        }

        public int CountContacts()
        {
            return addressBooks.Sum(addressBook => addressBook.Contacts.Count);
        }

        public void SearchByCity(string city)
        {
            var contacts = addressBooks
                .SelectMany(b => b.Contacts)
                .Where(c => c.City.Equals(city, StringComparison.OrdinalIgnoreCase))
                .ToList();

            Console.WriteLine($"Found {contacts.Count} contact(s):");

            foreach(Contact contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }

        public void SearchByState(string state)
        {
            var contacts = addressBooks
                .SelectMany(b => b.Contacts)
                .Where(c => c.State.Equals(state, StringComparison.OrdinalIgnoreCase))
                .ToList();

            Console.WriteLine($"Found {contacts.Count} contact(s):");

            foreach (Contact contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }
    }
}