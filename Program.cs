using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Address_Book;

namespace program
{
    class Contact
    {
        public static void Main()
        {
            UC1Create_Contact AddressBook = new UC1Create_Contact();
            AddressBook.GetContactDetails();
            Console.ReadLine();
        }
    }
}

