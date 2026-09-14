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

### Branch Structure

```text
main
 │
 ├── feature/UC1-create-contact
 │
 ├── feature/UC2-validate-contact
 │
 ├── feature/UC3-add-multiple-contacts
 │
 ├── feature/UC4-edit-contact
 │
 ├── feature/UC5-delete-contact
 │
 ├── feature/UC6
 │
 ├── feature/UC7
 │
 ├── feature/UC8
 │
 ├── feature/UC9
 │
 ├── feature/UC10
 │
 ├── feature/UC11
 │
 └── feature/UC12
```

### Development Workflow

For each Use Case:

1. Create a new feature branch from `main`
2. Implement the Use Case
3. Test the implementation
4. Commit the changes
5. Push the feature branch to GitHub
6. Merge the feature branch into `main`
7. Continue with the next Use Case


