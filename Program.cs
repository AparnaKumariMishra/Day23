using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC6_Add_Multiple_Addressbook
{
    internal class program
    {
        class Contact
        {
            public static void Main(String[] args)
            {
                Create_Contact AddressBook = new Create_Contact();
                AddressBook.AddMultipleContacts();
                AddressBook.AddUniqueContacts();
                AddressBook.DisplayUniqueContacts();
                Console.ReadLine();
            }
        }
    }
}
