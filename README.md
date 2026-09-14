# Address Book App

A console-based Address Book application developed in C# and .NET.

## Project Objective

The application is developed incrementally using multiple Use Cases (UC1–UC12). Each Use Case is implemented in a separate Git feature branch and merged into the `main` branch after completion and testing.

## Technology

* C#
* .NET
* Visual Studio
* Git
* GitHub

## Current Progress

### UC1 – Create Contact

* Create a `Contact` class
* Store contact details
* Initialize a contact using a constructor
* Display contact details using `ToString()`

### UC2 – Validate Contact

* Validate contact details
* Add custom `InvalidContactException`
* Validate name, address, city, state, zip, phone number, and email
* Display clear validation error messages

### UC3 – Add Multiple Contacts

* Create an `AddressBook` class
* Store multiple contacts using a list
* Add contacts to the address book
* Display all contacts
* Add a console menu for address book operations

### UC4 – Edit Contact

* Find an existing contact using first name and last name
* Edit contact details
* Keep existing values when a field is left blank
* Validate updated contact details
* Update the contact if the new details are valid

### UC5 – Delete Contact

* Find an existing contact using first name and last name
* Delete the selected contact from the address book
* Display a message when the contact is not found
* Display a confirmation message after successful deletion

## Git Workflow

Each Use Case is developed in its own feature branch and merged into `main` after completion and testing.


### Development Workflow

For each Use Case:

1. Create a new feature branch from `main`
2. Implement the Use Case
3. Test the implementation
4. Commit the changes
5. Push the feature branch to GitHub
6. Merge the feature branch into `main`
7. Continue with the next Use Case

=======
A console-based Address Book application developed using C# and .NET.

The project is built incrementally using multiple Use Cases (UC1–UC12). Each Use Case is implemented in its own Git feature branch and merged into the `main` branch after completion.

## Project Objective

The objective of this project is to build an Address Book application that allows users to:

- Create contacts
- Edit existing contacts
- Delete contacts
- Display all contacts
- Prevent duplicate contacts
- Search contacts by city or state
- Group contacts by city or state
- Count contacts by city or state
- Sort contacts using different fields
- Manage multiple address books

## Technologies Used

- C#
- .NET
- Visual Studio
- Git
- GitHub
- LINQ
- Regular Expressions

## Project Structure

```text
AddressBook/
│
├── AddressBookApp/
│   ├── Exceptions/
│   │   └── InvalidContactException.cs
│   │
│   ├── Models/
│   │   └── Contact.cs
│   │
│   ├── Services/
│   │   ├── AddressBook.cs
│   │   └── AddressBookMain.cs
│   │
│   ├── Validation/
│   │   └── ContactValidator.cs
│   │
│   ├── Program.cs
│   ├── AddressBookApp.csproj
│   └── AddressBookApp.slnx
│
├── AddressBookTests/
│   └── UnitTest1.cs
│
└── README.md
>>>>>>> feature/UC1-create-contact
