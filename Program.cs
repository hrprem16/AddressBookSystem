using System;
namespace Addressbook
{
    public class program
    {
        class Contact
        {
            public string FirstName;
            public string LastName;
            public string address;
            public string city;
            public string ZipCode;
            public string number;
            public string email;

            public Contact(string FirstName, string LastName, string address, string city, string ZipCode, string number, string email)
            {
                this.FirstName = FirstName;
                this.LastName = LastName;
                this.address = address;
                this.city = city;
                this.ZipCode = ZipCode;
                this.number = number;
                this.email = email;
            }
        }
        class Address_Book
        {
            List<Contact> contacts;//created list of contact class
            public Address_Book()
            {
                contacts = new List<Contact>();
            }
            public void addContact(Contact contact)
            {
                contacts.Add(contact);
            }
            public void display()
            {

                foreach (var contact in contacts)
                {
                    Console.WriteLine($"Name : {contact.FirstName} {contact.LastName}");
                    Console.WriteLine($"Address : {contact.address},{contact.city},{contact.ZipCode}");
                    Console.WriteLine($"Contact : {contact.number}");
                    Console.WriteLine($"Email : {contact.email}");
                }
            }
            public void editContact(string FirstName,Contact contact)
            {
                Contact existing = contacts.Find(c => contact.FirstName.Equals(FirstName));
                if (existing == null)
                {
                    Console.WriteLine("Contact not found");
                }
                else
                {
                    existing.FirstName = contact.FirstName;
                    existing.LastName = contact.LastName;
                    existing.address = contact.address;
                    existing.city = contact.city;
                    existing.ZipCode = contact.ZipCode;
                    existing.number = contact.number;
                    existing.email = contact.email;

                }
            }
            public void deleteContact(string FirstName)
            {
                Contact Existing = contacts.Find(c => c.FirstName.Equals(FirstName));
                if (Existing == null)
                {
                    Console.WriteLine("Contact not found");
                }
                else
                {
                    contacts.Remove(Existing);
                    Console.WriteLine("Contact deleted Successfully");
                }
;            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
            Contact obj1 = new Contact("Prince", "Bhagat", "Simri Bakhtiyarpur", "Saharsa", "852127", "8769944633", "hrprem16@gmail.com");

            Address_Book book1 = new Address_Book();
            book1.addContact(obj1);
            book1.display();
            Contact obj2=new Contact("Prince", "Kumar", "Sonbarsa", "Saharsa","603023", "8677448899", "prine123@gmail.com");
            Console.WriteLine("Enter the first name of the contact to edit: ");
            string firstname = Console.ReadLine();
            book1.editContact(firstname, obj2);
            book1.display();
            Console.WriteLine("Enter the first name of the contact to delete: ");
            string Firstname = Console.ReadLine();
            book1.deleteContact(Firstname);

        }
    }
}