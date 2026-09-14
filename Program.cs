using AddressBookApp.Models;
using AddressBookApp.Validation;
using AddressBookApp.Exceptions;

class Program
{
    static void Main(string[] args)
    {
        Contact contact = new Contact(
        "John",
        "Doe",
        "12 MG Road",
        "Pune",
        "Maharashtra",
        "411001",
        "9876543210",
        "john.doe@mail.com"
        );

        try
        {
            ContactValidator.Validate(contact);
            Console.WriteLine(contact);
        }
        catch (InvalidContactException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Console.ReadLine();
    }
}
