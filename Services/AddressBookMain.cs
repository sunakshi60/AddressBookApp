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
    }
}