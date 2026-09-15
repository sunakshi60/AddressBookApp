using AddressBookApp.Exceptions;
using AddressBookApp.Models;
using AddressBookApp.Validation;

namespace AddressBookTests
{
    public class ContactTests
    {
        [Test]
        public void CreateContact_ShouldStoreContactDetails()
        {
            Contact contact = new Contact(
                "John",
                "Doe",
                "123 Main Street",
                "Chandigarh",
                "Punjab",
                "160001",
                "9876543210",
                "john@gmail.com"
            );

            Assert.That(contact.FirstName, Is.EqualTo("John"));
            Assert.That(contact.LastName, Is.EqualTo("Doe"));
            Assert.That(contact.City, Is.EqualTo("Chandigarh"));
            Assert.That(contact.Zip, Is.EqualTo("160001"));
            Assert.That(contact.PhoneNumber, Is.EqualTo("9876543210"));
            Assert.That(contact.Email, Is.EqualTo("john@gmail.com"));
        }

        [Test]
        public void ToString_ShouldReturnFormattedContact()
        {
            Contact contact = new Contact(
                "John",
                "Doe",
                "123 Main Street",
                "Chandigarh",
                "Punjab",
                "160001",
                "9876543210",
                "john@gmail.com"
            );

            string result = contact.ToString();

            Assert.That(
                result,
                Is.EqualTo(
                    "John Doe | 123 Main Street, Chandigarh, Punjab 160001 | 9876543210 | john@gmail.com"
                )
            );
        }

        [Test]
        public void IsValidName_ShouldReturnTrueForValidName()
        {
            bool result = ContactValidator.IsValidName("John");

            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValidName_ShouldReturnFalseForInvalidName()
        {
            bool result = ContactValidator.IsValidName("jo");

            Assert.That(result, Is.False);
        }

        [Test]
        public void IsValidAddressPart_ShouldReturnTrueForValidAddress()
        {
            bool result = ContactValidator.IsValidAddressPart("123 Main Street");

            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValidAddressPart_ShouldReturnFalseForShortAddress()
        {
            bool result = ContactValidator.IsValidAddressPart("abc");

            Assert.That(result, Is.False);
        }

        [Test]
        public void IsValidZip_ShouldReturnTrueForValidZip()
        {
            bool result = ContactValidator.IsValidZip("160001");

            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValidZip_ShouldReturnFalseForInvalidZip()
        {
            bool result = ContactValidator.IsValidZip("12345");

            Assert.That(result, Is.False);
        }

        [Test]
        public void IsValidPhone_ShouldReturnTrueForValidPhone()
        {
            bool result = ContactValidator.IsValidPhone("9876543210");

            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValidPhone_ShouldReturnFalseForInvalidPhone()
        {
            bool result = ContactValidator.IsValidPhone("98765");

            Assert.That(result, Is.False);
        }

        [Test]
        public void IsValidEmail_ShouldReturnTrueForValidEmail()
        {
            bool result = ContactValidator.IsValidEmail("john@gmail.com");

            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValidEmail_ShouldReturnFalseForInvalidEmail()
        {
            bool result = ContactValidator.IsValidEmail("john@gmail");

            Assert.That(result, Is.False);
        }

        [Test]
        public void Validate_ShouldNotThrowExceptionForValidContact()
        {
            Contact contact = new Contact(
                "John",
                "Doe",
                "123 Main Street",
                "Chandigarh",
                "Punjab",
                "160001",
                "9876543210",
                "john@gmail.com"
            );

            Assert.DoesNotThrow(() => ContactValidator.Validate(contact));
        }

        [Test]
        public void Validate_ShouldThrowExceptionForInvalidContact()
        {
            Contact contact = new Contact(
                "jo",
                "Doe",
                "123 Main Street",
                "Chandigarh",
                "Punjab",
                "160001",
                "9876543210",
                "john@gmail.com"
            );

            Assert.Throws<InvalidContactException>(
                () => ContactValidator.Validate(contact)
            );
        }
    }
}