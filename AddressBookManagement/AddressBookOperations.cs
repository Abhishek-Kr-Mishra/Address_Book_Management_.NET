using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookManagement
{
    class AddressBookOperations
    {
        Dictionary<string, AddressBookContactVariables> addressBookContainer = new Dictionary<string, AddressBookContactVariables>();
        public Dictionary<string, AddressBookContactVariables> Save(string email, AddressBookContactVariables addressBookVariables)
        {
            addressBookContainer.Add(email, addressBookVariables);
            return addressBookContainer;
        }
        public AddressBookContactVariables NewAddressBook()
        {
            AddressBookContactVariables addressBookContactVariables = new AddressBookContactVariables();
            Console.WriteLine("Enter the First Name");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter the Last Name");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter The Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter the city");
            string city = Console.ReadLine();
            Console.WriteLine("Enter the state");
            string state = Console.ReadLine();
            Console.WriteLine("Enter the Email Id of Contact");
            string email = Console.ReadLine();
            Console.WriteLine("Enter the zip Code");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Phone number");
            long phone = Convert.ToInt64(Console.ReadLine());
            addressBookContactVariables.SetfName(fName);
            addressBookContactVariables.SetlName(lName);
            addressBookContactVariables.SetAddress(address);
            addressBookContactVariables.SetCity(city);
            addressBookContactVariables.SetState(state);
            addressBookContactVariables.SetEmail(email);
            addressBookContactVariables.SetZip(zip);
            addressBookContactVariables.SetPhone(phone);
            return addressBookContactVariables;
        }

        public void printAllDetails()
        {
            foreach (KeyValuePair<string, AddressBookContactVariables> keyValuePair in addressBookContainer)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                                  keyValuePair.Key, keyValuePair.Value);
            }
        }

    }
}
