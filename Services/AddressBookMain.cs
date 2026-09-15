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

        public void ViewByCity()
        {
            var contacts = addressBooks
                .SelectMany(b => b.Contacts)
                .GroupBy(c => c.City);

            Console.WriteLine("--- By City ---");

            foreach(var group in contacts)
            {
                Console.WriteLine($"{group.Key}:");

                foreach(Contact contact in group)
                {
                    Console.WriteLine(contact.FirstName + " " + contact.LastName);
                }
            }
        }

        public void ViewByState()
        {
            var contacts = addressBooks
                .SelectMany(b => b.Contacts)
                .GroupBy(c => c.State);

            Console.WriteLine("--- By State ---");

            foreach (var group in contacts)
            {
                Console.WriteLine($"{group.Key}:");

                foreach (Contact contact in group)
                {
                    Console.WriteLine(contact.FirstName + " " + contact.LastName);
                }
            }
        }

        public void CountByCity()
        {
            var cityCounts = addressBooks
                .SelectMany(b => b.Contacts)
                .GroupBy(c => c.City)
                .Select(g => new { City = g.Key, Count = g.Count() });

            Console.WriteLine("By City:");

            foreach(var city in cityCounts)
            {
                Console.WriteLine($"{city.City} = {city.Count}");
            }
        }

        public void CountByState()
        {
            var stateCounts = addressBooks
                .SelectMany(b => b.Contacts)
                .GroupBy(c => c.State)
                .Select(g => new { State = g.Key, Count = g.Count() });

            Console.WriteLine("By State:");

            foreach (var state in stateCounts)
            {
                Console.WriteLine($"{state.State} = {state.Count}");
            }
        }

        public void SortByName()
        {
            var contacts = addressBooks
                .SelectMany(b => b.Contacts)
                .OrderBy(c => c.FirstName)
                .ThenBy(c => c.LastName);

            Console.WriteLine("---Sorted By Name---");

            foreach(Contact contact in contacts)
            {
                Console.WriteLine(contact.ToString());
            }
        }
    }
}