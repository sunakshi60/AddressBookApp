using AddressBookApp.Models;

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

        Console.WriteLine(contact);

        Console.ReadLine();
    }
}
