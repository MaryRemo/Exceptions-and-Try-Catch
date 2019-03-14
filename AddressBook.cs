using System;
using System.Collections.Generic;

namespace ExceptionsAndTryCatch
{
    public class AddressBook
    {
        public Dictionary<string, Contact> addressBook {get; set;} = new Dictionary<string, Contact>();

        public void AddContact(Contact contact)
        {
            addressBook.Add(contact.Email, contact);
        }

        public Contact GetByEmail(string email)
        {
            try
            {
                Contact returnContact = addressBook[email];
                return returnContact;
            }
            catch(KeyNotFoundException)
            {
                return null;
            }
        }
    }
}