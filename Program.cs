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
            public int ZipCode;
            public string number;
            public string email;
        
           public Contact (string FirstName, string LastName, string address, string city, int ZipCode, string number, string email)
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


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
            Contact obj1 = new Contact("Prince", "Bhagat","Simri Bakhtiyarpur","Saharsa",852127,"8769944633","hrprem16@gmail.com");

            Address_Book book1 = new Address_Book();
            book1.addContact(obj1);
            book1.display();


        }
    }
}