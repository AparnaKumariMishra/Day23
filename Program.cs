using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC4_Remove_Contact
{
    internal class program
    {
        class Contact
        {
            public static void Main(String[] args)
            {
                Create_Contact AddressBook = new Create_Contact();
                AddressBook.AddPerson();
                AddressBook.Display();
                AddressBook.RemoveContact();
                Console.ReadLine();
            }
        }
    }
}
