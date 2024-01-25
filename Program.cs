using System;
namespace Addressbook
{
    class program
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
                this.address = LastName;
                this.address = address;
                this.city = city;
                this.ZipCode = ZipCode;
                this.number = number;
                this.email = email;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
            Contact ob1 = new Contact("Prince", "Bhagat","Simri Bakhtiyarpur","Saharsa",852127,"8769944633","hrprem16@gmail.com");
        }
    }
}